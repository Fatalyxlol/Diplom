using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Drawing;
using static System.Windows.Forms.LinkLabel;

namespace Kangaroo
{
    enum Command
    {
        step, space, right, left
    }

    internal class Interpreter
    {
        private static void AddCommands(List<Command> commands, ref string input, string pattern, Command commandType)
        {
            var match = Regex.Match(input, pattern);
            int count = Int32.Parse(match.Groups[1].Value) /
                (commandType == Command.right || commandType == Command.left ? 15 : 1);
            for (int i = 0; i < count; i++)
                commands.Add(commandType);
            input = Regex.Replace(input, pattern, "");
        }

        public static List<Command> execute(string input, Kangaroo kangaroo)
        {
            Kangaroo tempKangaroo = new Kangaroo(kangaroo.position, kangaroo.rotate);
            tempKangaroo.length = kangaroo.length;
            List<Command> allCommands = new List<Command>();
            List<Command> commands = new List<Command>();

            bool isWhile = false;
            bool isEdge = true;
            int count = 1;

            string step = @"^\s*Вперёд (\d+)";
            string space = @"^\s*Прыжок (\d+)";
            string right = @"^\s*Направо (\d+)";
            string left = @"^\s*Налево (\d+)";
            string repeat = @"^\s*Повтори (\d+)\s*\[";
            string ifthen = @"^\s*Если впереди( не)? край\s*\[";
            string endelse = @"^\s*\]\s*Иначе\s*\[";
            string whilethen = @"^\s*Пока впереди( не)? край\s*\[";
            string end = @"^\s*]";

            while (true)
            {
                if (Regex.IsMatch(input, step, RegexOptions.IgnoreCase))
                    AddCommands(commands, ref input, step, Command.step);
                else if (Regex.IsMatch(input, space, RegexOptions.IgnoreCase))
                    AddCommands(commands, ref input, space, Command.space);
                else if (Regex.IsMatch(input, right, RegexOptions.IgnoreCase))
                    AddCommands(commands, ref input, right, Command.right);
                else if (Regex.IsMatch(input, left, RegexOptions.IgnoreCase))
                    AddCommands(commands, ref input, left, Command.left);
                else if (Regex.IsMatch(input, repeat, RegexOptions.IgnoreCase))
                {
                    allCommands.AddRange(commands);
                    commands.Clear();
                    var match = Regex.Match(input, repeat);
                    count = Int32.Parse(match.Groups[1].Value);
                    input = Regex.Replace(input, repeat, "");
                }
                else if (Regex.IsMatch(input, ifthen, RegexOptions.IgnoreCase))
                {
                    allCommands.AddRange(commands);
                    commands.Clear();
                    Tuple<bool, PointF> tryMove = Form.TryMove(tempKangaroo);
                    var match = Regex.Match(input, ifthen);
                    if (!tryMove.Item1 && match.Groups[1].Value == " не" ||
                        tryMove.Item1 && match.Groups[1].Value == "")
                        count = 0;
                    input = Regex.Replace(input, ifthen, "");
                }
                else if (Regex.IsMatch(input, endelse, RegexOptions.IgnoreCase))
                {
                    if (count == 0)
                        count = 1;
                    else
                    {
                        for (int i = 0; i < count; i++)
                            allCommands.AddRange(commands);
                        count = 0;
                    }
                    commands.Clear();
                    input = Regex.Replace(input, endelse, "");
                }
                else if (Regex.IsMatch(input, whilethen, RegexOptions.IgnoreCase))
                {
                    allCommands.AddRange(commands);
                    commands.Clear();
                    Tuple<bool, PointF> tryMove = Form.TryMove(tempKangaroo);
                    var match = Regex.Match(input, whilethen);
                    if (!tryMove.Item1 && match.Groups[1].Value == " не" ||
                        tryMove.Item1 && match.Groups[1].Value == "")
                        count = 0;
                    else
                    {
                        isWhile = true;
                        isEdge = match.Groups[1].Value == "";
                    }
                    input = Regex.Replace(input, whilethen, "");
                }
                else if (Regex.IsMatch(input, end, RegexOptions.IgnoreCase))
                {
                    if (isWhile)
                    {
                        int j = 0;
                        int bound = 100;
                        while (j < bound)
                        {
                            allCommands.AddRange(commands);
                            for (int i = 0; i < commands.Count; i++)
                            {
                                if (commands[i] == Command.step || commands[i] == Command.space)
                                    Form.MoveKangaroo(tempKangaroo);
                                else if (commands[i] == Command.right)
                                    tempKangaroo.rotate = (tempKangaroo.rotate + 1) % 24;
                                else if (commands[i] == Command.left)
                                    tempKangaroo.rotate = (tempKangaroo.rotate + 23) % 24;
                            }
                            Tuple<bool, PointF> tryMove = Form.TryMove(tempKangaroo);
                            if (!tryMove.Item1 && !isEdge || tryMove.Item1 && isEdge)
                                break;
                            j++;
                        }
                    }
                    else
                        for (int i = 0; i < count; i++)
                            allCommands.AddRange(commands);
                    commands.Clear();
                    count = 1;
                    input = Regex.Replace(input, end, "");
                }
                else
                    break;
            }
            allCommands.AddRange(commands);
            return allCommands;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Kangaroo
{
    public partial class Form : System.Windows.Forms.Form
    {
        private static Bitmap map;
        private static Graphics graphics;
        private Pen penDraw;
        private Pen penGrid;

        private Kangaroo kangaroo;
        private bool isKangarooPlaced = false;
        private bool isGridMode = true;
        private bool isProgrammer = false;
        private bool isArrow = false;
        private int countLinesGrid;

        private List<Line> lines;

        private int lastCommand = 1;

        private int defaultGridStep = 1;
        private int defaultDrawStep = Kangaroo.width / 2;

        private float cellLength;

        private int secondFigureIndex = 0;

        public Form()
        {
            InitializeComponent();
            pictureBox.Height = pictureBox.Width;
            map = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(map);

            penDraw = new Pen(Color.White, 3);
            penGrid = new Pen(Color.Blue, 1);
            colorDraw.BackColor = penDraw.Color;
            colorGrid.BackColor = penGrid.Color;

            lines = new List<Line>();
            kangaroo = new Kangaroo(new PointF(), 0);
            kangaroo.length = Int32.Parse(step.Text);
            countLinesGrid = Int32.Parse(countGrid.Text);

            if (isGridMode)
            {
                cellLength = FindCellLength();
                kangaroo.length *= cellLength;
            }
            Render();
        }

        private float FindCellLength()
        {
            return (map.Width - 2 * Kangaroo.width) / (float)(countLinesGrid + 1);
        }

        public static Tuple<bool, PointF> TryMove(Kangaroo kangaroo)
        {
            var radAngle = -kangaroo.rotate * 15 * Math.PI / 180f;
            PointF position = kangaroo.position;
            PointF addPosition = new PointF((float)Math.Cos(radAngle) * kangaroo.length,
                (float)Math.Sin(radAngle) * kangaroo.length);

            PointF newPosition = new PointF(position.X + addPosition.X,
                position.Y - addPosition.Y);
            double eps = 0.001f;
            if (newPosition.X < -eps || map.Width - 2 * Kangaroo.width - newPosition.X < -eps ||
                newPosition.Y < -eps || map.Width - 2 * Kangaroo.width - newPosition.Y < -eps)
                return new Tuple<bool, PointF>(false, new PointF());
            return new Tuple<bool, PointF>(true, newPosition);
        }

        public static void MoveKangaroo(Kangaroo kangaroo, List<Line> lines = null)
        {
            Tuple<bool, PointF> tryMove = TryMove(kangaroo);
            if (!tryMove.Item1)
                return;

            PointF position = kangaroo.position;
            kangaroo.position = tryMove.Item2;

            if (!kangaroo.isUp && lines != null)
                lines.Add(new Line(position, kangaroo.position));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isArrow)
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        kangaroo.rotate = 0;
                        f2_Click(sender, e);
                        break;

                    case Keys.Down:
                        kangaroo.rotate = 6;
                        f2_Click(sender, e);
                        break;

                    case Keys.Left:
                        kangaroo.rotate = 12;
                        f2_Click(sender, e);
                        break;

                    case Keys.Up:
                        kangaroo.rotate = 18;
                        f2_Click(sender, e);
                        break;
                }

            switch (e.KeyCode)
            {
                case Keys.F1:
                    f1_Click(sender, e);
                    break;

                case Keys.F2:
                    f2_Click(sender, e);
                    break;

                case Keys.F3:
                    f3_Click(sender, e);
                    break;

                case Keys.F4:
                    f4_Click(sender, e);
                    break;

                case Keys.F5:
                    f5_Click(sender, e);
                    break;

                case Keys.F6:
                    f6_Click(sender, e);
                    break;

                case Keys.F7:
                    f7_Click(sender, e);
                    break;
            }
            
            Render();
        }

        private void Render()
        {
            graphics.Clear(pictureBox.BackColor);
            if (isGridMode)
                DrawGrid();
            else
                DrawEdges();
            foreach (var line in lines)
                DrawLine(penDraw, line.point1, line.point2);
            if (isKangarooPlaced)
                DrawImage(kangaroo.kenguruSprites[kangaroo.rotate], kangaroo.position, kangaroo.tiles[kangaroo.rotate]);
            pictureBox.Image = map;
            pictureBox.Refresh();
        }

        private void DrawImage(Image image, PointF position, PointF tile)
        {
            graphics.DrawImage(image, position.X + Kangaroo.width - tile.X, position.Y + Kangaroo.width - tile.Y);
        }

        public static void DrawLine(Pen pen, PointF pos1, PointF pos2)
        {
            graphics.DrawLine(pen, pos1.X + Kangaroo.width, pos1.Y + Kangaroo.width,
                pos2.X + Kangaroo.width, pos2.Y + Kangaroo.width);
        }

        public void DrawPoints(Brush brush, PointF[] points)
        {
            int l = 2;
            for (int i = 0; i < points.Length; i++)
                graphics.FillEllipse(brush, Kangaroo.width + points[i].X - l,
                    Kangaroo.width + points[i].Y - l, l * 2, l * 2);
            pictureBox.Image = map;
        }

        private void DrawGrid()
        {
            for (int i = 0; i < countLinesGrid + 2; i++)
            {
                DrawLine(penGrid, new PointF(i * cellLength, 0),
                    new PointF(i * cellLength, map.Height - 2 * Kangaroo.width));
                DrawLine(penGrid, new PointF(0, i * cellLength),
                    new PointF(map.Width - 2 * Kangaroo.width, i * cellLength));
            }
        }

        private void DrawEdges()
        {
            var x = map.Width - 2 * Kangaroo.width;
            var y = map.Height - 2 * Kangaroo.width;
            DrawLine(penGrid, new PointF(0, 0), new PointF(0, y));
            DrawLine(penGrid, new PointF(0, 0), new PointF(x, 0));
            DrawLine(penGrid, new PointF(x, y), new PointF(0, y));
            DrawLine(penGrid, new PointF(x, y), new PointF(x, 0));
        }

        private void pictureBoxMouseClick(object sender, MouseEventArgs e)
        {
            if (!isKangarooPlaced)
            {
                isKangarooPlaced = !isKangarooPlaced;
                kangaroo.position = new PointF(e.Location.X - Kangaroo.width,
                    e.Location.Y - Kangaroo.width);
                if (kangaroo.position.X < 0)
                    kangaroo.position.X = 0;
                if (kangaroo.position.Y < 0)
                    kangaroo.position.Y = 0;
                if (kangaroo.position.X > map.Width - 2 * Kangaroo.width)
                    kangaroo.position.X = map.Width - 2 * Kangaroo.width;
                if (kangaroo.position.Y > map.Height - 2 * Kangaroo.width)
                    kangaroo.position.Y = map.Height - 2 * Kangaroo.width;
                if (isGridMode)
                {
                    for (int i = 0; i < countLinesGrid + 1; i++)
                    {
                        if (kangaroo.position.X > (i - 0.5f) * kangaroo.length &&
                            kangaroo.position.X < (i + 0.5f) * kangaroo.length)
                            kangaroo.position.X = i * kangaroo.length;
                        if (kangaroo.position.Y > (i - 0.5f) * kangaroo.length &&
                            kangaroo.position.Y < (i + 0.5f) * kangaroo.length)
                            kangaroo.position.Y = i * kangaroo.length;
                    }
                }
                Render();
            }
        }

        private void colorDraw_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialogDraw.ShowDialog();
            penDraw.Color = colorDialogDraw.Color;
            colorDraw.BackColor = colorDialogDraw.Color;
            Render();
        }

        private void colorGrid_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialogGrid.ShowDialog();
            penGrid.Color = colorDialogGrid.Color;
            colorGrid.BackColor = colorDialogGrid.Color;
            Render();
        }

        private void checkBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
            isGridMode = checkBoxGrid.Checked;
            if (isGridMode)
            {
                countGrid.Visible = true;
                step.Text = defaultGridStep.ToString();
            }
            else
            {
                countGrid.Visible = false;
                step.Text = defaultDrawStep.ToString();
            }
            buttonClear_Click(sender, e);
        }

        private void countGrid_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(countGrid.Text, out int count) && count > 0 && count < 90)
                countLinesGrid = count;
            cellLength = FindCellLength();
            kangaroo.length = cellLength;
            buttonClear_Click(sender, e);
        }

        private void f1_Click(object sender, EventArgs e)
        {
            if (isProgrammer)
            {
                textBox.Text += "Вперёд ";
                panelButtons.Visible = false;
                panelNumber.Visible = true;
                return;
            }
            if (!isKangarooPlaced)
                return;
            MoveKangaroo(kangaroo, lines);
            Render();
        }

        private void f2_Click(object sender, EventArgs e)
        {
            if (isProgrammer)
            {
                textBox.Text += "Прыжок ";
                panelButtons.Visible = false;
                panelNumber.Visible = true;
                return;
            }
            if (!isKangarooPlaced)
                return;
            secondFigureIndex = lines.Count;
            kangaroo.isUp = true;
            MoveKangaroo(kangaroo, lines);
            kangaroo.isUp = false;
            Render();
        }

        private void f3_Click(object sender, EventArgs e)
        {
            if (isProgrammer)
            {
                textBox.Text += "Направо ";
                panelButtons.Visible = false;
                panelNumber.Visible = true;
                return;
            }
            if (!isKangarooPlaced)
                return;
            if (isGridMode)
                kangaroo.rotate = (kangaroo.rotate + 1) % 24;
            else
                kangaroo.rotate = (kangaroo.rotate + 6) % 24;
            Render();
        }

        private void f4_Click(object sender, EventArgs e)
        {
            textBox.Text += "Повтори ";
            panelButtons.Visible = false;
            panelNumber.Visible = true;
            lastCommand = 4;
        }

        private void f5_Click(object sender, EventArgs e)
        {
            textBox.Text += "]\n";
        }

        private void f6_Click(object sender, EventArgs e)
        {
            textBox.Text += "Если ";
            panelButtons.Visible = false;
            panelEdges.Visible = true;
        }

        private void f7_Click(object sender, EventArgs e)
        {
            textBox.Text += "]\nИначе [\n";
        }

        private void f8_Click(object sender, EventArgs e)
        {
            textBox.Text += "Пока ";
            panelButtons.Visible = false;
            panelEdges.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            isKangarooPlaced = false;
            kangaroo.rotate = 0;
            lines.Clear();
            graphics.Clear(pictureBox.BackColor);
            Render();
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text (*.txt)|*.txt";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
                textBox.Text = new StreamReader(openFileDialog.FileName).ReadToEnd();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text (*.txt)|*.txt";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    writer.Write(textBox.Text);
        }

        private void checkBoxProgrammer_CheckedChanged(object sender, EventArgs e)
        {
            isProgrammer = checkBoxProgrammer.Checked;
            if (isProgrammer)
            {
                panelForProgrammer.Visible = true;
                textBox.Visible = true;
                panel1.Visible = true;
            }
            else
            {
                panelForProgrammer.Visible = false;
                textBox.Visible = false;
                panel1.Visible = false;
            }
        }

        private void step_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(step.Text, out int newStep) && newStep > 0)
            {
                kangaroo.length = newStep;
                if (isGridMode)
                    kangaroo.length *= cellLength;
            }
        }

        private void checkBoxArrow_CheckedChanged(object sender, EventArgs e)
        {
            isArrow = checkBoxArrow.Checked;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBoxNumber.Text, out int res))
                textBox.Text += res;
            else
                textBox.Text += "1";
            if (lastCommand == 4)
                textBox.Text += " [";
            textBox.Text += "\n";
            lastCommand = 1;
            panelNumber.Visible = false;
            panelButtons.Visible = true;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            var commands = Interpreter.execute(textBox.Text, kangaroo);
            for (int i = 0; i < commands.Count; i++)
            {
                if (commands[i] == Command.step)
                    MoveKangaroo(kangaroo, lines);
                else if (commands[i] == Command.space)
                {
                    secondFigureIndex = lines.Count;
                    kangaroo.isUp = true;
                    MoveKangaroo(kangaroo, lines);
                    kangaroo.isUp = false;
                }
                else if (commands[i] == Command.right)
                    kangaroo.rotate = (kangaroo.rotate + 1) % 24;
                else if (commands[i] == Command.left)
                    kangaroo.rotate = (kangaroo.rotate + 23) % 24;

                if (sender.Equals(run))
                {
                    Thread.Sleep(200);
                    Render();
                }
            }
            Render();
        }

        private void isEdge_Click(object sender, EventArgs e)
        {
            panelEdges.Visible = false;
            panelButtons.Visible = true;
            textBox.Text += (sender.Equals(isEdge) ? "впереди край" : "впереди не край") + " [\n";
        }

        private void FindCount(Line[] lines)
        {
            var tuple = Task6.CountPointsInside(lines, countLinesGrid, cellLength);
            var pointsInside = tuple.Item1;
            var pointsOnLine = tuple.Item2;
            DrawPoints(Brushes.Red, pointsInside);
            DrawPoints(Brushes.Black, pointsOnLine);
            pictureBox.Refresh();
            MessageBox.Show("Внутри: " + pointsInside.Count() +
                "\nВнутри и на границе: " + (pointsInside.Count() + pointsOnLine.Count()), "Количество точек:", MessageBoxButtons.OK);
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            FindCount(lines.ToArray());
        }

        private void buttonCross_Click(object sender, EventArgs e)
        {
            var cross = Cross.FindCrossFigure(lines.ToArray(), secondFigureIndex);
            if (cross == null)
                return;
            for (int i = 0; i < cross.Length - 1; i++)
                DrawLine(new Pen(Color.Red, 3), cross[i], cross[i + 1]);
            DrawLine(new Pen(Color.Red, 3), cross[cross.Length - 1], cross[0]);
            pictureBox.Image = map;
            List<Line> tempLines = new List<Line>();
            for (int i = 0; i < cross.Length - 1; i++)
                tempLines.Add(new Line(cross[i], cross[i + 1]));
            tempLines.Add(new Line(cross[cross.Length - 1], cross[0]));
            FindCount(tempLines.ToArray());
        }

        private void buttonUnity_Click(object sender, EventArgs e)
        {
            var cross = Cross.FindCrossFigure(lines.ToArray(), secondFigureIndex, true);
            if (cross == null)
                return;
            for (int i = 0; i < cross.Length - 1; i++)
                DrawLine(new Pen(Color.Red, 3), cross[i], cross[i + 1]);
            DrawLine(new Pen(Color.Red, 3), cross[cross.Length - 1], cross[0]);
            pictureBox.Image = map;
            List<Line> tempLines = new List<Line>();
            for (int i = 0; i < cross.Length - 1; i++)
                tempLines.Add(new Line(cross[i], cross[i + 1]));
            tempLines.Add(new Line(cross[cross.Length - 1], cross[0]));
            FindCount(tempLines.ToArray());
        }


    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Kangaroo
{
    struct MyPoint
    {
        public PointF point;
        public bool isCross;
        public MyPoint(PointF point, bool isCross = false)
        {
            this.point = point;
            this.isCross = isCross;
        }
    }

    internal class Cross
    {
        static double eps = 0.01f;

        private static PointF[] CreateFigure(Line[] lines, int index1, int index2)
        {
            if (index1 >= index2)
                return new PointF[0];
            List<PointF> res = new List<PointF>();
            for (int i = index1; i < index2; i++)
                res.Add(lines[i].point1);
            res.Add(lines[index2 - 1].point2);
            if (Math.Abs(res[0].X - res[res.Count - 1].X) < eps &&
                Math.Abs(res[0].Y - res[res.Count - 1].Y) < eps)
                res.RemoveAt(res.Count - 1);

            var fixLines = new List<Line>();
            for (int i = 0; i < res.Count - 1; i++)
                fixLines.Add(new Line(res[i], res[i + 1]));
            var resLines = Task6.FixLines(fixLines.ToArray());
            var resPoints = new List<PointF>();
            for (int i = 0; i < resLines.Length; i++)
                resPoints.Add(resLines[i].point1);
            resPoints.Add(resLines[resLines.Length - 1].point2);

            return resPoints.ToArray();
        }

        static Tuple<bool, PointF> CrossLines(Tuple<PointF, PointF> line1,
            Tuple<PointF, PointF> line2)
        {
            PointF s1 = new PointF();
            PointF s2 = new PointF();

            s1.X = line1.Item2.X - line1.Item1.X;
            s1.Y = line1.Item2.Y - line1.Item1.Y;
            s2.X = line2.Item2.X - line2.Item1.X;
            s2.Y = line2.Item2.Y - line2.Item1.Y;

            float s = (-s1.Y * (line1.Item1.X - line2.Item1.X)
                + s1.X * (line1.Item1.Y - line2.Item1.Y)) / (-s2.X * s1.Y + s1.X * s2.Y);
            float t = (s2.X * (line1.Item1.Y - line2.Item1.Y)
                - s2.Y * (line1.Item1.X - line2.Item1.X)) / (-s2.X * s1.Y + s1.X * s2.Y);

            if (s >= 0 && s <= 1 && t >= 0 && t <= 1)
            {
                double x = line1.Item1.X + (t * s1.X);
                double y = line1.Item1.Y + (t * s1.Y);
                return new Tuple<bool, PointF>
                    (true, new PointF((float)x, (float)y));
            }
            else
                return new Tuple<bool, PointF>
                    (false, new PointF(-1, -1));
        }

        private static bool IsPointInside(PointF point, PointF[] points)
        {
            int count = 0;
            PointF point2 = new PointF(0, point.Y);
            Tuple<bool, PointF> isCross;
            for (int j = 0; j < points.Length - 1; j++)
            {
                isCross = CrossLines(
                    new Tuple<PointF, PointF>(point, point2),
                    new Tuple<PointF, PointF>(points[j], points[j + 1]));
                if (isCross.Item1)
                    count++;
            }
            isCross = CrossLines(new Tuple<PointF, PointF>(point, point2),
                new Tuple<PointF, PointF>(points[0], points[points.Length - 1]));
            if (isCross.Item1)
                count++;
            return count % 2 == 1;
        }

        static double FindLength(PointF point1, PointF point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) +
                Math.Pow(point1.Y - point2.Y, 2));
        }

        static PointF[] FindMinPoints(List<PointF> points, PointF first)
        {
            PointF[] res = points.ToArray();
            for (int i = 0; i < res.Length - 1; i++)
                for (int j = i; j < res.Length - 1; j++)
                {
                    if (FindLength(res[j], first) > FindLength(res[j + 1], first))
                    {
                        PointF c = res[j];
                        res[j] = res[j + 1];
                        res[j + 1] = c;
                    }
                }
            return res;
        }

        private static MyPoint[] CreateCrossFigure(PointF[] figure, PointF[] figure2)
        {
            List<MyPoint> newFigure = new List<MyPoint>();
            PointF[] fixFigure = new PointF[figure.Length + 1];
            for (int i = 0; i < figure.Length; i++)
                fixFigure[i] = figure[i];
            fixFigure[fixFigure.Length - 1] = figure[0];

            PointF[] fixFigure2 = new PointF[figure2.Length + 1];
            for (int i = 0; i < figure2.Length; i++)
                fixFigure2[i] = figure2[i];
            fixFigure2[fixFigure2.Length - 1] = figure2[0];

            for (int i = 0; i < fixFigure.Length - 1; i++)
            {
                List<PointF> tempCross = new List<PointF>();
                newFigure.Add(new MyPoint(fixFigure[i], false));
                for (int j = 0; j < fixFigure2.Length - 1; j++)
                {
                    var cross = CrossLines(
                        new Tuple<PointF, PointF>(fixFigure[i], fixFigure[i + 1]),
                        new Tuple<PointF, PointF>(fixFigure2[j], fixFigure2[j + 1]));
                    if (cross.Item1)
                        tempCross.Add(cross.Item2);
                }
                if (tempCross.Count == 1)
                    newFigure.Add(new MyPoint(tempCross[0], true));
                else if (tempCross.Count > 1)
                {
                    var crossPoints = FindMinPoints(tempCross, fixFigure[i]);
                    foreach (var point in crossPoints)
                        newFigure.Add(new MyPoint(point, true));
                }
            }
            return newFigure.ToArray();
        }

        public static PointF[] FindCrossFigure(Line[] lines, int secondFigureIndex, bool isUnity = false)
        {
            PointF[] figure1 = CreateFigure(lines, 0, secondFigureIndex);
            PointF[] figure2 = CreateFigure(lines, secondFigureIndex, lines.Length);

            if (figure1.Length < 3 || figure2.Length < 3)
                return null;

            var fixFigure1 = CreateCrossFigure(figure1, figure2);
            var fixFigure2 = CreateCrossFigure(figure2, figure1);

            if (fixFigure1.Length == figure1.Length)
                return null;

            for (int l = 0; l < figure1.Length - 1; l++)
                Form.DrawLine(new Pen(Color.White, 3), figure1[l], figure1[l + 1]);
            Form.DrawLine(new Pen(Color.White, 3), figure1[figure1.Length - 1], figure1[0]);

            for (int l = 0; l < figure2.Length - 1; l++)
                Form.DrawLine(new Pen(Color.White, 3), figure2[l], figure2[l + 1]);
            Form.DrawLine(new Pen(Color.White, 3), figure2[figure2.Length - 1], figure2[0]);

            int k = 0;
            while (IsPointInside(fixFigure1[0].point, figure2))
            {
                var cyclePoints = new List<MyPoint>();
                for (int j = 1; j < fixFigure1.Count(); j++)
                    cyclePoints.Add(fixFigure1[j]);
                cyclePoints.Add(fixFigure1[0]);
                fixFigure1 = cyclePoints.ToArray();
                k++;
                if (k > figure1.Length)
                    return null;
            }

            List<PointF> res = new List<PointF>();

            int firstIndex = 0;
            if (!isUnity)
            {
                while (fixFigure1[firstIndex].isCross == false)
                    firstIndex++;
            }

            res.Add(fixFigure1[firstIndex].point);

            int firstIndex2;
            if (!isUnity)
            {
                firstIndex2 = 0;
                for (int j = 0; j < fixFigure2.Count(); j++)
                    if (fixFigure2[j].isCross &&
                        Math.Abs(fixFigure1[firstIndex].point.X - fixFigure2[j].point.X) < eps &&
                        Math.Abs(fixFigure1[firstIndex].point.Y - fixFigure2[j].point.Y) < eps)
                    {
                        firstIndex2 = j;
                        break;
                    }
            }
            else
                firstIndex2 = -1;
            int i = firstIndex + 1;

            bool isFirst = true;
            while (!(isFirst && i == firstIndex) && !(!isFirst && i == firstIndex2)/* && ((isFirst && i < fixFigure1.Length) || (!isFirst && i < fixFigure2.Length))*/)
            {
                if (isFirst)
                {
                    res.Add(fixFigure1[i].point);
                    if (fixFigure1[i].isCross)
                    {
                        isFirst = false;
                        for (int j = 0; j < fixFigure2.Count(); j++)
                            if (fixFigure2[j].isCross &&
                                Math.Abs(fixFigure1[i].point.X - fixFigure2[j].point.X) < eps &&
                                Math.Abs(fixFigure1[i].point.Y - fixFigure2[j].point.Y) < eps)
                            {
                                i = j;
                                break;
                            }
                    }
                }
                else
                {
                    res.Add(fixFigure2[i].point);
                    if (fixFigure2[i].isCross)
                    {
                        isFirst = true;
                        for (int j = 0; j < fixFigure1.Count(); j++)
                            if (fixFigure1[j].isCross &&
                                Math.Abs(fixFigure1[j].point.X - fixFigure2[i].point.X) < eps &&
                                Math.Abs(fixFigure1[j].point.Y - fixFigure2[i].point.Y) < eps)
                            {
                                i = j;
                                break;
                            }
                    }
                }
                i++;
                if (isFirst)
                    i = i % fixFigure1.Count();
                else
                    i = i % fixFigure2.Count();
            }
            return res.ToArray();
        }
    }
}

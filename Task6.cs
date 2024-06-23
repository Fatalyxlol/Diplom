using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    public enum Condition
    {
        inter, notInter, on
    }

    public class Task6
    {
        static double eps = 0.01f;

        static public Condition IntersectCondition(Line line, Line vector)
        {
            int o1 = Orientation(line, vector.point1);
            int o2 = Orientation(line, vector.point2);
            int o3 = Orientation(vector, line.point1);
            int o4 = Orientation(vector, line.point2);

            if (o1 == 0 && OnSegment(line, vector.point1))
                return Condition.on;

            if (o1 == 0 || o2 == 0 || o3 == 0 || o4 == 0)
                return Condition.notInter;

            if (o1 == o2 || o3 == o4)
                return Condition.notInter;

            return Condition.inter;
        }

        static int Orientation(Line line, PointF p)
        {
            float d1 = p.X - line.point1.X;
            float d2 = line.point2.Y - line.point1.Y;
            float d3 = p.Y - line.point1.Y;
            float d4 = line.point2.X - line.point1.X;
            d1 = Math.Abs(d1) < eps ? 0 : d1;
            d2 = Math.Abs(d2) < eps ? 0 : d2;
            d3 = Math.Abs(d3) < eps ? 0 : d3;
            d4 = Math.Abs(d4) < eps ? 0 : d4;
            double val = d1 * d2 - d3 * d4;
            if (Math.Abs(val) < eps)
                return 0;
            return (val > 0) ? 1 : -1;
        }

        static bool OnSegment(Line line, PointF p)
        {
            if (p.X - eps <= Math.Max(line.point1.X, line.point2.X) && p.X + eps >= Math.Min(line.point1.X, line.point2.X) &&
                p.Y - eps <= Math.Max(line.point1.Y, line.point2.Y) && p.Y + eps >= Math.Min(line.point1.Y, line.point2.Y))
                return true;
            return false;
        }

        private static PointF[] AllPoints(int countLinesGrid, float cellLength)
        {
            List<PointF> points = new List<PointF>();
            for (int i = 0; i < countLinesGrid + 2; i++)
                for (int j = 0; j < countLinesGrid + 2; j++)
                    points.Add(new PointF(i * cellLength, j * cellLength));
            return points.ToArray();
        }

        private static bool IsPointBetween(Line line, PointF point)
        {
            if (line.point1.X < line.point2.X)
                return point.X + eps >= line.point1.X && point.X <= line.point2.X + eps;
            else
                return point.X <= line.point1.X + eps && point.X + eps >= line.point2.X;
        }

        private static double FindAngle(Line line)
        {
            PointF point = new PointF(line.point2.X - line.point1.X,
                line.point2.Y - line.point1.Y);
            float length = (float)Math.Sqrt(point.X * point.X + point.Y * point.Y);
            PointF normal = new PointF(point.X / length, point.Y / length);
            double angle = Math.Acos(normal.X);
            if (normal.Y > 0)
                angle = -angle;
            return angle;
        }

        public static Line[] FixLines(Line[] lines)
        {
            if (lines.Length < 2)
                return lines;

            lines = DeleteCopyLines(lines);

            List<Line> fixLines = new List<Line>();
            Line line = lines[0];
            double lastAngle = FindAngle(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                double newAngle = FindAngle(lines[i]);
                if (Math.Abs(lastAngle - newAngle) < eps)
                {
                    line.point2 = lines[i].point2;
                }
                else
                {
                    fixLines.Add(line);
                    line = lines[i];
                }
                lastAngle = newAngle;
            }
            fixLines.Add(line);
            return fixLines.ToArray();
        }

        static bool isEqualLines(Line line1, Line line2)
        {
            return Math.Abs(line1.point1.X - line2.point1.X) < eps &&
                Math.Abs(line1.point1.Y - line2.point1.Y) < eps &&
                Math.Abs(line1.point2.X - line2.point2.X) < eps &&
                Math.Abs(line1.point2.Y - line2.point2.Y) < eps;
        }

        private static Line[] DeleteCopyLines(Line[] lines)
        {
            List<Line> fixLines = lines.ToList();
            for (int i = 0; i < fixLines.Count - 1; i++)
            {
                for (int j = i + 1; j < fixLines.Count; j++)
                {
                    if (isEqualLines(fixLines[i], fixLines[j]))
                    {
                        fixLines.RemoveAt(j);
                        j--;
                    }
                }
            }
            return fixLines.ToArray();
        }

        private static bool IsOdd(int[] conditions)
        {
            int even = 0;
            int odd = 0;
            foreach (int condition in conditions)
            {
                if (condition % 2 == 1)
                    odd++;
                else
                    even++;
            }
            return odd >= even;
        }

        public static Tuple<PointF[], PointF[]> CountPointsInside(Line[] lines, int countLinesGrid, float cellLength)
        {
            Line[] fixLines = FixLines(lines);
            PointF[] points = AllPoints(countLinesGrid, cellLength);
            List<PointF> pointsInside = new List<PointF>();
            List<PointF> pointsOnLine = new List<PointF>();
            for (int i = 0; i < points.Length; i++)
            {
                int[] countIntersect = new int[5];
                for (int j = 0; j < fixLines.Length; j++)
                {
                    Line[] vectors = new Line[5];
                    vectors[0] = new Line(points[i],
                        new PointF(points[i].X + 1000, points[i].Y + 900));
                    vectors[1] = new Line(points[i],
                        new PointF(points[i].X, points[i].Y + 1000));
                    vectors[2] = new Line(points[i],
                        new PointF(points[i].X + 1000, points[i].Y));
                    vectors[3] = new Line(points[i],
                        new PointF(points[i].X - 1000, points[i].Y + 900));
                    vectors[4] = new Line(points[i],
                        new PointF(points[i].X - 1000, points[i].Y - 900));

                    Condition[] conditions = new Condition[5];
                    for (int k = 0; k < conditions.Length; k++)
                        conditions[k] = IntersectCondition(fixLines[j], vectors[k]);
                    for (int k = 0; k < conditions.Length; k++)
                        if (conditions[k] == Condition.inter)
                            countIntersect[k]++;
                    if (conditions[0] == Condition.on && IsPointBetween(fixLines[j], points[i]))
                    {
                        for (int t = 0; t < conditions.Length; t++)
                            countIntersect[t] = 2;
                        pointsOnLine.Add(points[i]);
                        break;
                    }
                }
                if (IsOdd(countIntersect))
                    pointsInside.Add(points[i]);
            }
            return new Tuple<PointF[], PointF[]>(pointsInside.ToArray(), pointsOnLine.ToArray());
        }
    }
}

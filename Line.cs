using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    public class Line
    {
        public PointF point1;
        public PointF point2;

        public Line(PointF point1, PointF point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
    }
}

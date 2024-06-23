using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    public class Kangaroo
    {
        public PointF position;
        public int rotate;
        public float length = 41;
        public bool isUp = false;
        public static int width = 82;
        public Bitmap[] kenguruSprites = new Bitmap[24];
        public Point[] tiles = new Point[24];

        public Kangaroo(PointF position, int rotate)
        {
            this.position = position;
            this.rotate = rotate;

            kenguruSprites[0] = new Bitmap(Properties.Resources._0, width, width);
            kenguruSprites[1] = new Bitmap(Properties.Resources._15, width, width);
            kenguruSprites[2] = new Bitmap(Properties.Resources._30, width, width);
            kenguruSprites[3] = new Bitmap(Properties.Resources._45, width, width);
            kenguruSprites[4] = new Bitmap(Properties.Resources._60, width, width);
            kenguruSprites[5] = new Bitmap(Properties.Resources._75, width, width);
            kenguruSprites[6] = new Bitmap(Properties.Resources._90, width, width);
            kenguruSprites[7] = new Bitmap(Properties.Resources._105, width, width);
            kenguruSprites[8] = new Bitmap(Properties.Resources._120, width, width);
            kenguruSprites[9] = new Bitmap(Properties.Resources._135, width, width);
            kenguruSprites[10] = new Bitmap(Properties.Resources._150, width, width);
            kenguruSprites[11] = new Bitmap(Properties.Resources._165, width, width);
            kenguruSprites[12] = new Bitmap(Properties.Resources._180, width, width);
            kenguruSprites[13] = new Bitmap(Properties.Resources._195, width, width);
            kenguruSprites[14] = new Bitmap(Properties.Resources._210, width, width);
            kenguruSprites[15] = new Bitmap(Properties.Resources._225, width, width);
            kenguruSprites[16] = new Bitmap(Properties.Resources._240, width, width);
            kenguruSprites[17] = new Bitmap(Properties.Resources._255, width, width);
            kenguruSprites[18] = new Bitmap(Properties.Resources._270, width, width);
            kenguruSprites[19] = new Bitmap(Properties.Resources._285, width, width);
            kenguruSprites[20] = new Bitmap(Properties.Resources._300, width, width);
            kenguruSprites[21] = new Bitmap(Properties.Resources._315, width, width);
            kenguruSprites[22] = new Bitmap(Properties.Resources._330, width, width);
            kenguruSprites[23] = new Bitmap(Properties.Resources._345, width, width);

            tiles[0] = new Point(5, 70);
            tiles[1] = new Point(5, 65);
            tiles[2] = new Point(5, 62);
            tiles[3] = new Point(5, 60);

            tiles[4] = new Point(72, 64);
            tiles[5] = new Point(70, 66);
            tiles[6] = new Point(68, 68);
            tiles[7] = new Point(66, 70);
            tiles[8] = new Point(64, 72);

            tiles[9] = new Point(74, 60);
            tiles[10] = new Point(74, 63);
            tiles[11] = new Point(74, 66);
            tiles[12] = new Point(74, 72);
            tiles[13] = new Point(70, 70);
            tiles[14] = new Point(67, 73);
            tiles[15] = new Point(62, 73);

            tiles[16] = new Point(46, 73);
            tiles[17] = new Point(44, 73);
            tiles[18] = new Point(42, 73);
            tiles[19] = new Point(40, 73);
            tiles[20] = new Point(38, 73);

            tiles[21] = new Point(17, 74);
            tiles[22] = new Point(15, 72);
            tiles[23] = new Point(15, 70);
        }
    }
}

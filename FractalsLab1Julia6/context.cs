using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FractalsLab1Julia6
{
    internal class Context
    {
        private double offSetX, offSetY, zoom, mag, hheight, hwidth;
        private int width, height, nIt, rad;
        private Complex cNum;
        private readonly Color[] palette;
        private readonly Color innerColor;

        public int Width => width;

        public int Height => height;

        public int HalfWidth => (int)hwidth;
        public int HalfHeight => (int)hheight;

        public int NIt => nIt;

        public Context(Color[] palette, Color inner)
        {
            this.palette = palette;
            this.innerColor = inner;
        }

        public void SetValues(double offX, double offY, double zoom, int w, int h, int nIt, int rad, Complex cNumber)
        {
            this.offSetX = offX;
            this.offSetY = offY;
            this.zoom = zoom;
            this.mag = (h/3.0) * Math.Pow(2.0,zoom);
            this.width = w;
            this.hwidth = w / 2.0;
            this.height = h;
            this.hheight = h / 2.0;
            this.nIt = nIt;
            this.rad = rad;
            this.cNum = cNumber;
        }

        public Color GetColor(double val)
        {
            return val < 0 ? innerColor : palette[(int)(val) % palette.Length];
        }

        public Complex Transform(Complex num)
        {
            return new Complex(
                ((num.Real - hwidth) / mag) + offSetX,
                ((num.Imaginary - hheight) / mag) + offSetY
            );
        }
        public Bitmap NewBitmap()
        {
            return new(width, height);
        }
    }
}

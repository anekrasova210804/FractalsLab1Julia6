using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Windows.Forms;

namespace FractalsLab1Julia6
{
    public partial class JuliaFractalUI : Form
    {
        private Complex complexNumber
        {
            get
            {
                return new Complex(double.Parse(RealÑhoice.Text), double.Parse(ImaginaryChoice.Text));
            }
            set
            {
                complexNumber = new Complex(double.Parse(RealÑhoice.Text), double.Parse(ImaginaryChoice.Text));
            }
        }
        private int maxIterations
        {
            get => (int)iterationsChoice.Value;
            set { maxIterations = (int)iterationsChoice.Value; }
        }
        private int radius
        {
            get => (int)radiusChoice.Value;
            set { radius = (int)radiusChoice.Value; }
        }
        private int zoom
        {
            get => (int)zoomChoice.Value;
            set { zoom = (int)zoomChoice.Value; }
        }

        private double viewOffsetX
        {
            get => (double)offsetXChoice.Value;
            set { viewOffsetX = (double)offsetXChoice.Value; }
        }

        private double viewOffsetY
        {
            get => (double)offsetYChoice.Value;
            set { viewOffsetY = (double)offsetYChoice.Value; }
        }


        public JuliaFractalUI()
        {
            InitializeComponent();
        }

        private void renderButton_Click(object sender, EventArgs e)
        {
            juliaPictureBox.Image = juliaSetBitmap();

        }

        private Bitmap juliaSetBitmap()
        {
            Complex z = new Complex(0, 0);
            int i;

            Color[] colors = (from c in Enumerable.Range(0, maxIterations + 1)
                              select Color.FromArgb((c >> 5) * 36, (c >> 3 & 7) * 36, (c & 3) * 85)).ToArray();

            var bitmap = new Bitmap(juliaPictureBox.Width, juliaPictureBox.Height);
            for (int x = 0; x < juliaPictureBox.Width; x++)
            {
                for (int y = 0; y < juliaPictureBox.Height; y++)
                {
                    z = new Complex(1.5 * (x - juliaPictureBox.Width / 2) / (0.5 * zoom * juliaPictureBox.Width) + viewOffsetX,
                        1.0 * (y - juliaPictureBox.Height / 2) / (0.5 * zoom * juliaPictureBox.Height) + viewOffsetY);
                    i = 0;
                    while (z.Magnitude < radius && i < maxIterations)
                    {
                        z = z * z * z * z * z;
                        z += complexNumber;
                        i += 1;
                    }
                    bitmap.SetPixel(x, y, colors[i]);
                }
            }
 


            Graphics g = Graphics.FromImage(bitmap);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.Flush();
            return bitmap;
        }
 

    }
}

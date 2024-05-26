using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FractalsLab1Julia6
{
    public partial class JuliaFractalUI : Form
    {
        private Complex complexNumber
        {
            get
            {
                return new Complex(double.Parse(RealСhoice.Text), double.Parse(ImaginaryChoice.Text));
            }
            set
            {
                complexNumber = new Complex(double.Parse(RealСhoice.Text), double.Parse(ImaginaryChoice.Text));
            }
        }
        private int maxIterations
        {
            get => (int)iterationsChoice.Value;
            set { maxIterations = (int)iterationsChoice.Value; }
        }
        private int radius
        {
            get { return (int)radiusChoice.Value; }
            set { radius = (int)radiusChoice.Value; }
        }
        private double zoom
        {
            get => (double)zoomChoice.Value;
            set { zoom = (double)zoomChoice.Value; }
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
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            juliaPictureBox.Image = juliaSetBitmap();
            //watch.Stop();
            //long elapsedMs = watch.ElapsedMilliseconds/1000;
            //MessageBox.Show(elapsedMs.ToString() + " sec");
        }

 

        private Bitmap juliaSetBitmap()
        {
            Complex z = new Complex(0, 0);
            int i;

            Color[] colors = (from c in Enumerable.Range(0, maxIterations + 1)
                              select Color.FromArgb((c >> 5) * 36, (c >> 3 & 7) * 36, (c & 3) * 85)).ToArray();

            Bitmap bitmap = new Bitmap(juliaPictureBox.Width, juliaPictureBox.Height);
            for (int x = 0; x < juliaPictureBox.Width; x++)
            {
                for (int y = 0; y < juliaPictureBox.Height; y++)
                {

                    z = new Complex(1.0 * (x - juliaPictureBox.Width / 2) / (0.5 * (zoom - 0.3) * juliaPictureBox.Width) + viewOffsetX,
                        1.5 * (y - juliaPictureBox.Height / 2) / (0.5 * (zoom - 0.2) * juliaPictureBox.Height) + viewOffsetY);
                    i = 0;
                    while (z.Magnitude < radius && i < maxIterations)
                    {
                        z = z * z * z * z * z;
                        z += complexNumber;
                        i += 1;
                    }
                    bitmap.SetPixel(x, y, i < maxIterations ? Color.FromArgb(i %4 * 63, i % 2 * 20, i % 4 * 60) : Color.White);
                }
            }

            return bitmap;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            juliaPictureBox.Image.Save(@".\juliaFractal.jpeg", ImageFormat.Jpeg);
            juliaPictureBox.Image.Save(@".\juliaFractal.png", ImageFormat.Png);
        }
    }
}

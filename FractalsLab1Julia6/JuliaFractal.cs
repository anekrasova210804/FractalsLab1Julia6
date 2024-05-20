using System.Numerics;
using System.Threading;

namespace FractalsLab1Julia6
{
    public partial class JuliaFractalUI : Form
    {
        private readonly Context context = new(CreatePalette(), Color.Black);
        private Task? previewTask = null;
        private CancellationTokenSource? tokenSource = null;

        private int nIterations
        {
            get => (int)iterationsChoice.Value;
            set => iterationsChoice.SafeSet(value);
        }

        private int radius
        {
            get => int.Parse(radiusChoice.Text);
            set { radius = int.Parse(radiusChoice.Text); }
        }

        private Complex cNumber
        {
            get
            {
                return NeededExtensions.ComplexParse(ñNumberÑhoice.Text);
            }
            set
            {
                cNumber = NeededExtensions.ComplexParse(ñNumberÑhoice.Text);
            }
        }

        private double viewOffsetX
        {
            get => (double)offsetXChoice.Value;
            set => offsetXChoice.SafeSet((decimal)value);
        }
        private double viewOffsetY
        {
            get => (double)offsetYChoice.Value;
            set => offsetYChoice.SafeSet((decimal)value);
        }
        private double Zoom
        {
            get => (double)zoomChoice.Value;
            set => zoomChoice.SafeSet((decimal)value);
        }
        public JuliaFractalUI()
        {
            InitializeComponent();
        }

        private void SetContext()
        {
            context.SetValues(viewOffsetX, viewOffsetY, Zoom, juliaPictureBox.Width, juliaPictureBox.Height, nIterations, radius, cNumber);
            // double offX, double offY, double zoom, int w, int h, int nIt, int rad, Complex cNumber
        }

        private static Color[] CreatePalette()
        {

            var incr = Enumerable.Range(0, 255);
            var decr = Enumerable.Range(1, 255).Reverse();
            var all0 = Enumerable.Repeat(0, 255);
            var all255 = Enumerable.Repeat(255, 255);
            var redRange = incr.Concat(all255).Concat(all255).Concat(decr).Concat(all0).Concat(all0);
            var greenRange = incr.Concat(decr).Concat(all0).Concat(all0).Concat(incr).Concat(decr);
            var blueRange = all0.Concat(all0).Concat(incr).Concat(all255).Concat(all255).Concat(decr);

            //var redRange = Enumerable.Range(0, 98).Concat(Enumerable.Range(98, 160)).Concat(Enumerable.Range(1, 160).Reverse()).Concat(Enumerable.Range(0, 143)).Concat(Enumerable.Range(61, 143).Reverse()).
            //    Concat(Enumerable.Range(1, 61).Reverse());
            //var greenRange = Enumerable.Range(0, 71).Concat(Enumerable.Range(71, 108)).Concat(Enumerable.Range(108, 180)).Concat(Enumerable.Range(180, 231)).Concat(Enumerable.Range(220, 231).Reverse()).
            //    Concat(Enumerable.Range(1, 220).Reverse());
            //var blueRange = Enumerable.Range(0, 170).Concat(Enumerable.Range(170, 213)).Concat(Enumerable.Range(213, 216)).Concat(Enumerable.Range(216, 243)).Concat(Enumerable.Range(151, 243).Reverse()).
            //    Concat(Enumerable.Range(1, 151).Reverse());

            return
                redRange
                .Zip(greenRange, (r, g) => (r, g))
                .Zip(blueRange, (rg, b) => (rg.r, rg.g, b))
                .Select(rgb => Color.FromArgb(rgb.r, rgb.g, rgb.b))
                .ToArray();
        }
        private void ShowPreview()
        {
            using (previewTask)
            {
                previewTask = RenderSet();
            }
        }

        private void Busy(bool busy)
        {
            juliaPictureBox.Enabled = !busy;
            renderButton.Enabled = !busy;
            saveButton.Enabled = busy;
        }

        private async Task RenderSet()
        {
            //Busy(true);
            //SetContext();
            //using (tokenSource = new())
            //{
            //    using var renderTask = JuliaSet.Render(context, 4, this.radius, this.cNumber, tokenSource.Token);
            //    juliaPictureBox.SetBackgroundBitmap(await renderTask);
            //    Busy(false);
            //}
            CancellationTokenSource cts = new();
            SetContext();
            Bitmap bm = await JuliaSet.Render(context, 4, radius, cNumber, cts.Token);
            juliaPictureBox.BackgroundImage = bm;

        }

        private void renderButton_Click(object sender, EventArgs e)
        {
            ShowPreview();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //tokenSource?.SafeCancel();
        }
    }
}

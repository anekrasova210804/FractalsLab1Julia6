using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FractalsLab1Julia6
{
    internal static class JuliaSet
    {
        private const decimal TWO = 2, FOUR = 4;

        private static Complex ComputeNext(Complex z, Complex c)
        {
            return z * z * z * z * z + c;
        }


        private static double Iterate(Complex c, int maxIt, int radius)
        {
            Complex z = new Complex(0.0, 0.0);
            double oldm = z.Magnitude;
            for (int it = 0; it < maxIt && z.Magnitude < radius; it++)
            {
                z = ComputeNext(z, c);
                if (z.Magnitude >= radius)
                    return it + ((radius - oldm) / (z.Magnitude - oldm));
                oldm = z.Magnitude;
            }
            return -1;
        }

        public static async Task<Bitmap> Render(Context con, int threads, int radius, Complex c, CancellationToken token)
        {
            Bitmap bm = con.NewBitmap();
            using Graphics g = Graphics.FromImage(bm);
            var tasks = Enumerable
                .Range(0, threads)
                .Select(tn => Task<Bitmap>.Run(() => Partial(threads, tn, radius,c, con, token), token))
                .ToArray();
            foreach (var task in tasks)
            {
                using (task)
                {
                    using Bitmap pbm = await task;
                    g.DrawImage(pbm, Point.Empty);
                }
            }
            return bm;
        }

        private static Bitmap Partial(int threads, int tn, int radius, Complex c, Context con, CancellationToken token)
        {
            Bitmap bm = con.NewBitmap();
            for (int y = tn; y < con.Height && !token.IsCancellationRequested; y += threads)
            {
                for (int x = 0; x < con.Width; x++)
                { 
                    double it = Iterate(con.Transform(new Complex(x,y)), con.NIt, radius);
                    bm.SetPixel(x, y, con.GetColor(it));
                }
            }
            return bm;
        }

    }
}

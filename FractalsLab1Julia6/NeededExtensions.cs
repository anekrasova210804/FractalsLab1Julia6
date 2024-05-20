using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FractalsLab1Julia6
{
    internal static class NeededExtensions
    {
        public static void SafeSet(this NumericUpDown nud, decimal value)
        {
            nud.Value = value.Clamp(nud.Minimum, nud.Maximum);
        }
        public static decimal Clamp(this decimal value, decimal min, decimal max)
        {
            return Math.Min(Math.Max(value, min), max);
        }

        public static Complex ComplexParse(string text)   // (x, y) or (x+yi) or (x+yj) or (x-yi) or (x-yj)
        {
            string[] parts;
            string parsedText = text.Trim();
            if (parsedText.StartsWith("(") && parsedText.EndsWith(")"))
            {
                parsedText = parsedText.Substring(1, parsedText.Length - 2).Trim(); // Drop parentheses
                if (parsedText.Contains("+") && (parsedText.EndsWith("i") || parsedText.EndsWith("j")))
                {
                    parts = parsedText.Split('+');
                    if (parts.Length == 2)
                        return
                            new Complex(
                                real: double.Parse(parts[0].Trim()),
                                imaginary: double.Parse(parts[1].Substring(0, parts[1].Length - 1).Trim())
                                );

                    throw new ArgumentException("Complex number format not recognised (multiple '+' chars)");
                }
                else if (parsedText.Substring(1).Contains("-") && (parsedText.EndsWith("i") || parsedText.EndsWith("j")))   // (x-yi) or (x-yj) // Beware of (-x-yi) or (-x-yj)
                {
                    parts = parsedText.Substring(1).Split('-');
                    if (parts.Length == 2)
                        return
                            new Complex(
                                real: double.Parse(parsedText.Substring(0, 1) + parts[0].Trim()),
                                imaginary: -double.Parse(parts[1].Substring(0, parts[1].Length - 1).Trim())
                                );

                    throw new ArgumentException("Complex number format not recognised (multiple '+' chars)");
                }
                else if (parsedText.Contains(","))  // Hopefully in the form x, y
                {
                    parts = parsedText.Split(',');
                    if (parts.Length == 2)
                        return
                            new Complex(
                                real: Double.Parse(parts[0].Trim()),
                                imaginary: Double.Parse(parts[1].Trim())
                                );

                    // Too many commas. Can only diambiguate if one is followed by a space
                    int ix = parsedText.IndexOf(", ");
                    if (ix < 1)     // ", " not found or there is an empty real part
                        throw new ArgumentException("Complex number format not recognised (ambiguous use of commas)");

                    return
                        new Complex(
                            real: double.Parse(parsedText.Substring(0, ix).Trim()),
                            imaginary: double.Parse(parsedText.Substring(ix + 1).Trim())
                            );
                }
                else
                    throw new ArgumentException("Complex number format not recognised");
            }
            else
                throw new ArgumentException("Complex number not enclosed in parentheses");
        }
    }
}

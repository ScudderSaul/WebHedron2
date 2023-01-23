using System;
using System.Collections.Generic;
using System.Drawing;

namespace WebHedron2.Tools
{
    public static class LocalPallete
    {
        /// <summary>
        /// The colors for painting the polygons for Faces indexed by side count
        /// </summary>
        private static Dictionary<int, Color> _colors = new Dictionary<int, Color>();

        /// <summary>
        /// Return the color used to paint a polygon with a specified number of faces.
        /// </summary>
        /// <param name="numSides"></param>
        /// <returns></returns>
        public static Color Lookup(int numSides)
        {
            if (_colors.Count == 0)
                init();
            return _colors[numSides];
        }

        public static string Css3ColorLookup(int numSides, double distance, double opacity)
        {
            if (_colors.Count == 0)
                init();


            Color color = _colors[numSides];

            double val = 60.0*(distance - .25);

            byte bv = (byte) ((uint) val);

            byte rr = color.R;
            byte gg = color.G;
            byte bb = color.B;

            if (val > 0.0)
            {
                rr = (byte)(rr + bv);
                gg = (byte)(gg + bv);
                bb = (byte)(bb + bv);
            }
            else
            {
                rr = (byte)(rr - bv);
                gg = (byte)(gg - bv);
                bb = (byte)(bb - bv);
            }

            string ret = string.Format("rgba({0},{1},{2},{3,2:F})",
              rr, gg, bb, opacity);

        //    string ret = string.Format("rgba({0},{1},{2},{3,2:F})",
         //       color.R, color.G, color.B, ((double) 0.8));
            return (ret);
        }

        /// <summary>
        /// Initialise all the colors in the _colors dictionary according to the
        /// algorithm described above
        /// </summary>
        private static void init()
        {
            //int[] numSides = new int[] { 3, 4, 5, 6, 8, 10, 12 };
            // float saturation = 1f;
            // float brightness = .8f;
            // float hue = 0f;
            //  float hue2 = .4f;
            // float hueDelta = 1f / (numSides.Length);
            // hueDelta /= 3;

            _colors[3] = Color.FromArgb((byte) 140, (byte) 100, (byte) 100, (byte) 30);
            _colors[4] = Color.FromArgb((byte) 140, (byte) 30, (byte) 100, (byte) 100);
            _colors[5] = Color.FromArgb((byte) 140, (byte) 100, (byte) 30, (byte) 100);

            _colors[6] = Color.FromArgb((byte) 140, (byte) 100, (byte) 30, (byte) 30);
            _colors[7] = Color.FromArgb((byte)140, (byte)30, (byte)100, (byte)30);
            _colors[8] = Color.FromArgb((byte) 140, (byte) 30, (byte) 30, (byte) 100);

            _colors[9] = Color.FromArgb((byte)140, (byte)100, (byte)160, (byte)100);
            _colors[10] = Color.FromArgb((byte) 140, (byte) 160, (byte) 100, (byte) 100);
            _colors[12] = Color.FromArgb((byte) 140, (byte) 100, (byte) 100, (byte) 160);
            //       _colors[3] = Color.FromArgb((byte)140, (byte)100, (byte)100, (byte)30);


            //bool side = true;

            //foreach(int ns in numSides)
            //{
            //    if (side == true)
            //    {
            //        _colors[ns] = colorFromHSB(hue * 255f, saturation * 255f, brightness * 255f);
            //        hue += hueDelta;
            //        side = false;
            //    }
            //    else
            //    {
            //        _colors[ns] = colorFromHSB(hue2 * 255f, saturation * 255f, brightness * 255f);
            //        hue2 -= hueDelta;
            //        side = true;
            //    }
            //}
        }


        /// <summary>
        /// Generate an .NET color from its hue, saturation and brightness
        /// </summary>
        /// <param name="h"></param>
        /// <param name="s"></param>
        /// <param name="br"></param>
        /// <returns></returns>
        private static Color colorFromHSB(float h, float s, float br)
        {
            float r = br;
            float g = br;
            float b = br;
            if (s != 0)
            {
                float max = br;
                float dif = br*s/255f;
                float min = br - dif;

                h = h*360f/255f;

                if (h < 60f)
                {
                    r = max;
                    g = h*dif/60f + min;
                    b = min;
                }
                else if (h < 120f)
                {
                    r = -(h - 120f)*dif/60f + min;
                    g = max;
                    b = min;
                }
                else if (h < 180f)
                {
                    r = min;
                    g = max;
                    b = (h - 120f)*dif/60f + min;
                }
                else if (h < 240f)
                {
                    r = min;
                    g = -(h - 240f)*dif/60f + min;
                    b = max;
                }
                else if (h < 300f)
                {
                    r = (h - 240f)*dif/60f + min;
                    g = min;
                    b = max;
                }
                else if (h <= 360f)
                {
                    r = max;
                    g = min;
                    b = -(h - 360f)*dif/60 + min;
                }
                else
                {
                    r = 0;
                    g = 0;
                    b = 0;
                }
            }
            return Color.FromArgb // CHANGE !!!!!!
                (
                    0xFF,
                    (byte) Math.Round(Math.Min(Math.Max(r, 0), 255)),
                    (byte) Math.Round(Math.Min(Math.Max(g, 0), 255)),
                    (byte) Math.Round(Math.Min(Math.Max(b, 0), 255))
                );

        }
    }
}
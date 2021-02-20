using PD.BitmapWrapper;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace Color_Reducer
{
    public partial class ColorReducer
    {
        private static readonly int borderWidth = 20;
        private static readonly int imageWidth = 1250;
        private static readonly int imageHeight = 750;
        private static readonly int radius = 250;

        private void CreateImageButtonHandler(object sender, System.EventArgs e)
        {
            BitmapWrapper newImage = new(imageWidth, imageHeight);
            newImage.Clear();

            // drawing black border for the image - horizontal lines
            Parallel.For(0, imageWidth, i =>
            {
                for (int j = 0; j < borderWidth; j++)
                {
                    newImage.SetPixel(i, j, Color.Black);
                    newImage.SetPixel(i, imageHeight - 1 - j, Color.Black);
                }
            });

            // drawing black border for the image - vertical lines
            Parallel.For(0, imageHeight, j =>
            {
                for (int i = 0; i < borderWidth; i++)
                {
                    newImage.SetPixel(i, j, Color.Black);
                    newImage.SetPixel(imageWidth - 1 - i, j, Color.Black);
                }
            });

            // drawing HSV circle in the middle
            int circle_x = imageWidth / 2, circle_y = imageHeight / 2;

            Parallel.For(0, imageWidth * imageHeight, i =>
            {
                int x = i % imageWidth;
                int y = i / imageWidth;

                int dx = x - circle_x, dy = y - circle_y;

                double dist = Math.Sqrt(dx * dx + dy * dy);

                if (dist <= radius)
                {
                    double theta = Math.Atan2(dy, dx);

                    double hue = (theta + Math.PI) / (2 * Math.PI);

                    double sat = dist / radius;
                    double val = 1f;
                    
                    HSVToRGB(hue, sat, val, out double dr, out double dg, out double db);

                    Color c = Color.FromArgb((int)(dr * 255), (int)(dg * 255), (int)(db * 255));

                    newImage.SetPixel(x, y, c);
                }
            });


            // disposing old stuff and setting new
            BitmapWrapper toDispose = galleryImages.ContainsValue(Controller.MainImage) ? null : Controller.MainImage;

            Controller.MainImage = newImage;
            
            mainPictureBox.Image = Controller.MainImage.Bitmap;

            toDispose?.Dispose();
           
            kmeansPictureBox.Image?.Dispose();
            kmeansPictureBox.Image = null;

            popularityPictureBox.Image?.Dispose();
            popularityPictureBox.Image = null;

            uncertaintyPictureBox.Image?.Dispose();
            uncertaintyPictureBox.Image = null;
        }

        // function taken from this article:
        // http://viziblr.com/news/2011/12/1/drawing-a-color-hue-wheel-with-c.html
        public static void HSVToRGB(double H, double S, double V, out double R, out double G, out double B)
        {
            if (H == 1.0)
            {
                H = 0.0;
            }

            double step = 1.0 / 6.0;
            double vh = H / step;

            int i = (int)Math.Floor(vh);

            double f = vh - i;
            double p = V * (1.0 - S);
            double q = V * (1.0 - (S * f));
            double t = V * (1.0 - (S * (1.0 - f)));

            switch (i)
            {
                case 0:
                    {
                        R = V;
                        G = t;
                        B = p;
                        break;
                    }
                case 1:
                    {
                        R = q;
                        G = V;
                        B = p;
                        break;
                    }
                case 2:
                    {
                        R = p;
                        G = V;
                        B = t;
                        break;
                    }
                case 3:
                    {
                        R = p;
                        G = q;
                        B = V;
                        break;
                    }
                case 4:
                    {
                        R = t;
                        G = p;
                        B = V;
                        break;
                    }
                case 5:
                    {
                        R = V;
                        G = p;
                        B = q;
                        break;
                    }
                default:
                    {
                        // not possible - if we get here it is an internal error
                        throw new ArgumentException();
                    }
            }
        }
    }
}
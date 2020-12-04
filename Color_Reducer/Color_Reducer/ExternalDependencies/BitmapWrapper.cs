using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PD.BitmapWrapper
{
    public class BitmapWrapper : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        private Graphics Graphics { get; set; }
        private int[] Pixels { get; }
        private bool Disposed { get; set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public BitmapWrapper(int width, int height)
        {
            // setting Bitmap size
            Width = width;
            Height = height;

            // allocating an array of colors for each pixel
            Pixels = new int[width * height];

            // pinning the array for the garbage coll. handler and creating a new Bitmap which uses the array as its source
            BitsHandle = GCHandle.Alloc(Pixels, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());

            // creating a Graphics object
            Graphics = Graphics.FromImage(Bitmap);
        }

        public BitmapWrapper(Bitmap bitmap)
        {
            // setting Bitmap size
            Width = bitmap.Width;
            Height = bitmap.Height;

            // allocating an array of colors for each pixel
            Pixels = new int[Width * Height];

            // pinning the array for the garbage coll. handler and creating a new Bitmap which uses the array as its source
            BitsHandle = GCHandle.Alloc(Pixels, GCHandleType.Pinned);
            Bitmap = new Bitmap(Width, Height, Width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());

            // creating a Graphics object
            Graphics = Graphics.FromImage(Bitmap);

            // copy colors from the given Bitmap in Parallel
            unsafe
            {
                BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(bitmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x += bytesPerPixel)
                    {
                        byte oldBlue = currentLine[x];
                        byte oldGreen = currentLine[x + 1];
                        byte oldRed = currentLine[x + 2];

                        int color = 255 << 24 | oldRed << 16 | oldGreen << 8 | oldBlue;

                        Pixels[(y * bitmapData.Stride + x) / bytesPerPixel] = color;
                    }
                });

                bitmap.UnlockBits(bitmapData);
            }
        }

        /// <summary>
        /// Returns Graphics object from the bitmap
        /// </summary>
        /// <returns>Graphics</returns>
        public Graphics GetGraphics()
        {
            if (Graphics == null)
            {
                Graphics = Graphics.FromImage(Bitmap);
            }

            return Graphics;
        }

        /// <summary>
        /// Sets all pixels on the bitmap to solid color given in the "color" parameter.
        /// </summary>
        public void Clear(Color color) => GetGraphics().Clear(color);

        /// <summary>
        /// Sets all pixels on the bitmap to solid white.
        /// </summary>
        public void Clear() => Clear(Color.White);

        /// <summary>
        /// Changes color of the pixel given by parameters (x, y) on the bitmap to a color given by "color" parameter.
        /// </summary>
        /// <param name="x">Coordinate of the pixel in x-axis.</param>
        /// <param name="y">Coordinate of the pixel in y-axis.</param>
        /// <param name="color">New color set on the pixel.</param>
        public void SetPixel(int x, int y, Color color)
        {
            if (x < 0 || x >= Width || y < 0 || y >= Height) return;

            Pixels[x + (y * Width)] = color.ToArgb();
        }

        /// <summary>
        /// Gets color of the pixel given by parameters (x, y) on the bitmap.
        /// </summary>
        /// <param name="x">Coordinate of the pixel in x-axis.</param>
        /// <param name="y">Coordinate of the pixel in y-axis.</param>
        /// <returns>Color</returns>
        public Color GetPixel(int x, int y) => Color.FromArgb(Pixels[x + (y * Width)]);

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            Graphics.Dispose();
            BitsHandle.Free();
        }

        public Bitmap Scaled(int width, int height)
        {
            BitmapWrapper scaledWrapper = new(width, height);

            Parallel.For(0, width * height, i =>
            {
                int x = i % width;
                int y = i / width;

                int scaled_x = (int)(x * ((float)Width / width));
                int scaled_y = (int)(y * ((float)Height / height));

                scaledWrapper.SetPixel(x, y, GetPixel(scaled_x, scaled_y));
            });

            return scaledWrapper.Bitmap;
        }
    }
}

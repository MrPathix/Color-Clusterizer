using Color_Clusterizer.FilterMatrices;
using Color_Clusterizer.Models;
using PD.BitmapWrapper;
using System;
using System.Drawing;

namespace Color_Clusterizer.ClusteringAlgorithms
{
    class UncertaintyClusteringAlgorithm : IClusterizer
    {
        private readonly int k;
        private readonly FilterMatrix filter;
        public ProgressReport Report { get; }

        public UncertaintyClusteringAlgorithm(int k, FilterMatrix filter, ProgressReport report)
        {
            this.k = k;
            this.filter = filter;
            Report = report;
        }

        public BitmapWrapper Clusterize(BitmapWrapper wrapper)
        {
            Report.Progress = 0;
            Report.IsOperating = true;

            BitmapWrapper result = new(wrapper.Width, wrapper.Height);

            Report.Bitmap = result.Bitmap;

            int progressDelta = (int)(100.0f / (wrapper.Width * wrapper.Height));

            for (int i = 0; i < wrapper.Width; i++)
            {
                for (int j = 0; j < wrapper.Height; j++)
                {
                    Color propagated = result.GetPixel(i, j);

                    Color pixel = wrapper.GetPixel(i, j);
                    Color newPixel = Approximate(pixel, k);

                    float redError = pixel.R - newPixel.R;
                    float greenError = pixel.G - newPixel.G;
                    float blueError = pixel.B - newPixel.B;

                    // use of filter matrix to propagate the uncertainty
                    for (int y = 0; y < 2 * filter.Rows + 1; y++)
                    {
                        for (int x = 0; x < 2 * filter.Cols + 1; x++)
                        {
                            int index_x = i - filter.Cols + x, index_y = j - filter.Rows + y;

                            if (index_x < 0 || index_x >= wrapper.Width || index_y < 0 || index_y >= wrapper.Height) continue;

                            Color oldColor = wrapper.GetPixel(index_x, index_y);

                            result.SetPixel(
                                index_x,
                                index_y,
                                Color.FromArgb(
                                    Math.Clamp((int)(oldColor.R + redError * filter[y, x]), 0, 255),
                                    Math.Clamp((int)(oldColor.G + greenError * filter[y, x]), 0, 255),
                                    Math.Clamp((int)(oldColor.B + blueError * filter[y, x]), 0, 255)
                                )
                            );
                        }
                    }

                    result.SetPixel(i, j, 
                        Color.FromArgb(
                            Math.Clamp(propagated.R + newPixel.R, 0, 255), 
                            Math.Clamp(propagated.G + newPixel.G, 0, 255),
                            Math.Clamp(propagated.B + newPixel.B, 0, 255)
                        )
                    );

                    Report.Progress += progressDelta;
                }
            }

            Report.Progress = 100;
            Report.IsOperating = false;

            return result;
        }

        private static Color Approximate(Color c, int k)
        {
            int div = (int)Math.Pow(k, 1.0 / 3);

            int redQuantity = div;
            int greenQuantity = div;
            int blueQuantity = k / (div * div);

            int red = 256 / redQuantity * (c.R * redQuantity / 256);
            int green = 256 / greenQuantity * (c.R * greenQuantity / 256);
            int blue = 256 / blueQuantity * (c.R * blueQuantity / 256);

            return Color.FromArgb(red, green, blue);
        }
    }
}

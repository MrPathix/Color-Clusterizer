using Color_Reducer.Models;
using PD.BitmapWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Color_Reducer.ReductionAlgorithms
{
    class PopularityReductionAlgorithm : IReductionAlgorithm
    {
        private readonly int k;
        public ProgressReport Report { get; }

        public PopularityReductionAlgorithm(int k, ProgressReport report)
        {
            this.k = k;
            Report = report;
        }

        public BitmapWrapper Reduce(BitmapWrapper wrapper)
        {
            Report.IsOperating = true;
            Report.Progress = 0;

            Dictionary<Color, int> colorQuantity = new();

            // counting quantities of each color on the input image
            for (int i = 0; i < wrapper.Width; i++)
            {
                for (int j = 0; j < wrapper.Height; j++)
                {
                    Color c = wrapper.GetPixel(i, j);

                    if (!colorQuantity.ContainsKey(c))
                    {
                        colorQuantity.Add(c, 1);
                    }
                    else
                    {
                        colorQuantity[c]++;
                    }
                }
            }

            Report.Progress += (int)(100.0f / (2 * k + 1));

            // finding k most frequent colors
            List<Color> mostFrequentColors = new();

            for (int i = 0; i < k; i++)
            {
                Color mostFrequent = default;
                int quantity = 0;

                foreach (var el in colorQuantity)
                {
                    if (el.Value > quantity)
                    {
                        quantity = el.Value;
                        mostFrequent = el.Key;
                    }
                }

                mostFrequentColors.Add(mostFrequent);
                colorQuantity.Remove(mostFrequent);

                Report.Progress += (int)(100.0f / (2 * k + 1));
            }

            colorQuantity.Clear();

            // creating result bitmap and filling it with data
            BitmapWrapper result = new(wrapper.Width, wrapper.Height);

            Parallel.For(0, wrapper.Width * wrapper.Height, i =>
            {
                int x = i % wrapper.Width;
                int y = i / wrapper.Width;

                Color pixel = wrapper.GetPixel(x, y);
                
                Color color = default;
                float minDist = float.MaxValue;

                // for each pixel we need to find its closest centroid
                foreach (var el in mostFrequentColors)
                {
                    float distance = Distance(pixel, el);

                    if (distance < minDist)
                    {
                        color = el;
                        minDist = distance;
                    }
                }

                result.SetPixel(x, y, color);
            });

            mostFrequentColors.Clear();
            
            Report.Progress = 100;
            Report.IsOperating = false;

            return result;
        }

        private static float Distance(Color a, Color b)
        {
            //return Math.Abs(a.R - b.R) + Math.Abs(a.G - b.G) + Math.Abs(a.B - b.B);
            return MathF.Sqrt((a.R - b.R) * (a.R - b.R) + (a.G - b.G) * (a.G - b.G) + (a.B - b.B) * (a.B - b.B));
        }
    }
}

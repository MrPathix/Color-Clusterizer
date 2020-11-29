using Color_Clusterizer.Models;
using PD.BitmapWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Color_Clusterizer.ClusteringAlgorithms
{
    class KmeansClusteringAlgorithm : IClusterizer
    {
        private readonly int k;
        private readonly int epsilon;

        public ProgressReport Report { get; }

        public KmeansClusteringAlgorithm(int k, int epsilon, ProgressReport r)
        {
            this.k = k;
            this.epsilon = epsilon;
            Report = r;
        }

        public Bitmap Clusterize(BitmapWrapper wrapper)
        {
            Report.IsOperating = true;
            Report.Progress = 0;

            List<Color> centroids = new();
            Dictionary<Color, Color> colorCentroids = new();
            Dictionary<Color, HashSet<Color>> clusters = new();

            int minCentroidDelta = 3 * 255;
            int maxCentroidDelta;

            BitmapWrapper filledBitmap = new(wrapper.Width, wrapper.Height);
            Report.Bitmap = filledBitmap.Bitmap;

            Random rnd = new();

            // randomizing first k centroids
            for (int i = 0; i < k; i++)
            {
                Color randomizedCentroid = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                
                centroids.Add(randomizedCentroid);
                clusters.Add(randomizedCentroid, new());
            }

            // while the algorithm has not converged
            while (minCentroidDelta > epsilon)
            {
                maxCentroidDelta = 0;

                // assign each pixel color to a set
                for (int i = 0; i < wrapper.Width; i++)
                {
                    for (int j = 0; j < wrapper.Height; j++)
                    {
                        Color pixel = wrapper.GetPixel(i, j);

                        Color centroid = Color.White;
                        int minDistance = 3 * 255;

                        // finding a centroid for each pixel
                        foreach (var color in centroids)
                        {
                            int distance = Distance(pixel, color);

                            if (distance < minDistance)
                            {
                                minDistance = distance;
                                centroid = color;
                            }
                        }

                        // adding pixel to a set identified by the found centroid
                        // and adding color of the centroid to colorCentroids dictionary

                        if (!clusters.ContainsKey(centroid))
                        {
                            clusters.Add(centroid, new());
                        }

                        clusters[centroid].Add(pixel);
                        colorCentroids[pixel] = centroid;
                    }
                }

                List<Color> newCentroids = new();

                // calculate new centroids for each set
                Parallel.ForEach(centroids, centroid =>
                {
                    if (!clusters.ContainsKey(centroid))
                    {
                        return;
                    }

                    HashSet<Color> colorSet = clusters[centroid];

                    if (colorSet.Count == 0)
                    {
                        newCentroids.Add(centroid);
                        return;
                    }

                    long red = 0, green = 0, blue = 0;

                    foreach (var color in colorSet)
                    {
                        red += color.R;
                        green += color.G;
                        blue += color.B;
                    }

                    Color newCentroid = Color.FromArgb
                    (
                        (int)(red / colorSet.Count),
                        (int)(green / colorSet.Count),
                        (int)(blue / colorSet.Count)
                    );

                    colorSet.Clear();

                    // check the distance between new centroid and current centroid
                    int dist = Distance(centroid, newCentroid);

                    // maxCentroidDelta is maximum position change for a centroid in current iteration
                    if (dist > maxCentroidDelta) maxCentroidDelta = dist;

                    newCentroids.Add(newCentroid);
                });

                clusters.Clear();
                centroids.Clear();

                centroids = newCentroids;
                minCentroidDelta = maxCentroidDelta;

                int progress = minCentroidDelta == 0 ? 100 : Math.Min(100, 100 * epsilon / minCentroidDelta);
                
                if (progress > Report.Progress) Report.Progress = progress;

                Parallel.For(0, wrapper.Width * wrapper.Height, i =>
                {
                    int x = i % wrapper.Width;
                    int y = i / wrapper.Width;

                    filledBitmap.SetPixel(x, y, colorCentroids[wrapper.GetPixel(x, y)]);
                });
            }

            Report.IsOperating = false;

            return filledBitmap.Bitmap;
        }

        private static int Distance(Color a, Color b)
        {
            return Math.Abs(a.R - b.R) + Math.Abs(a.G - b.G) + Math.Abs(a.B - b.B);
        }
    }
}

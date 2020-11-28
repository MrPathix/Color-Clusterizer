using Color_Clusterizer.ExternalDependencies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Color_Clusterizer.ClusteringAlgorithms
{
    class KmeansClusteringAlgorithm : IClusterizer
    {
        private readonly int k;
        public KmeansClusteringAlgorithm(int k)
        {
            this.k = k;
        }

        public Bitmap Clusterize(BitmapWrapper wrapper)
        {
            List<Color> centroids = new();
            Dictionary<Color, Color> colorCentroids = new();
            Dictionary<Color, HashSet<Color>> clusters = new();

            int minCentroidDelta = 3 * 255;
            int maxCentroidDelta;
            const int epsilon = 3;

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
                foreach (var centroid in centroids)
                {
                    HashSet<Color> colorSet = clusters[centroid];

                    if (colorSet.Count == 0)
                    {
                        newCentroids.Add(centroid);
                        continue;
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
                }

                centroids.Clear();
                centroids = newCentroids;
                minCentroidDelta = maxCentroidDelta;
            }

            // filling a bitmap with reduced colors
            BitmapWrapper filledBitmap = new BitmapWrapper(wrapper.Width, wrapper.Height);

            for (int i = 0; i < wrapper.Width; i++)
            {
                for (int j = 0; j < wrapper.Height; j++)
                {
                    filledBitmap.SetPixel(i, j, colorCentroids[wrapper.GetPixel(i, j)]);
                }
            }

            return filledBitmap.Bitmap;
        }

        private static int Distance(Color a, Color b)
        {
            return Math.Abs(a.R - b.R) + Math.Abs(a.G - b.G) + Math.Abs(a.B - b.B);
        }
    }
}

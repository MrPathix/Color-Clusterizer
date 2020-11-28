using Color_Clusterizer.ClusteringAlgorithms;
using Color_Clusterizer.ExternalDependencies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Color_Clusterizer.Controllers
{
    class MainViewController
    {
        IClusterizer Kmeans;
        public BitmapWrapper ClusteredImage { get; set; }
        public MainViewController() { }
        public Task<Bitmap> GetKmeansClusteredImage(int k)
        {
            Kmeans = new KmeansClusteringAlgorithm(k);
            return Task.Run(() => Kmeans.Clusterize(ClusteredImage));
        }
    }
}

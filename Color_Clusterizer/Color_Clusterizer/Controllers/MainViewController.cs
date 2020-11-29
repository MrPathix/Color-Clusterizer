using Color_Clusterizer.ClusteringAlgorithms;
using Color_Clusterizer.ExternalDependencies;
using Color_Clusterizer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Color_Clusterizer.Controllers
{
    class MainViewController
    {
        private IClusterizer kmeans;
        public BitmapWrapper ClusteredImage { get; set; }
        public ProgressReport KmeansReport { get; protected set; }
        public MainViewController() 
        {
            KmeansReport = new();
        }
        public Task<Bitmap> GetKmeansClusteredImage(int k)
        {
            kmeans = new KmeansClusteringAlgorithm(k, KmeansReport);
            return Task.Run(() => kmeans.Clusterize(ClusteredImage));
        }
    }
}

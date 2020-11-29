using Color_Clusterizer.ClusteringAlgorithms;
using Color_Clusterizer.Models;
using PD.BitmapWrapper;
using System.Drawing;
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
        public Task<Bitmap> GetKmeansClusteredImage(int k, int epsilon)
        {
            kmeans = new KmeansClusteringAlgorithm(k, epsilon, KmeansReport);
            return Task.Run(() => kmeans.Clusterize(ClusteredImage));
        }
    }
}

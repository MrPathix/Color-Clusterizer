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
        public BitmapWrapper KmeansClusteredImage { get; set; }
        public ProgressReport KmeansReport { get; protected set; }
        
        public MainViewController() 
        {
            KmeansReport = new();
        }
        public Task GetKmeansClusteredImage(int k, int epsilon)
        {
            KmeansClusteredImage?.Dispose();

            kmeans = new KmeansClusteringAlgorithm(k, epsilon, KmeansReport);
            return Task.Run(() => 
            { 
                KmeansClusteredImage = kmeans.Clusterize(ClusteredImage); 
            });
        }
    }
}

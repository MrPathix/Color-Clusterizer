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
        private IClusterizer popularity;
        
        public bool IsOperating { get => KmeansReport.IsOperating || PopularityReport.IsOperating; }
        public BitmapWrapper ClusteredImage { get; set; }
        public ProgressReport KmeansReport { get; protected set; }
        public ProgressReport PopularityReport { get; protected set; }
        
        public MainViewController() 
        {
            KmeansReport = new();
            PopularityReport = new();
        }
        public Task<Bitmap> GetKmeansClusteredImage(int k, int epsilon)
        {
            kmeans = new KmeansClusteringAlgorithm(k, epsilon, KmeansReport);
            return Task.Run(() => kmeans.Clusterize(ClusteredImage));
        }

        public Task<Bitmap> GetPopularityClusteredImage(int k)
        {
            popularity = new PopularityClusteringAlgorithm(k, PopularityReport);
            return Task.Run(() => popularity.Clusterize(ClusteredImage));
        }
    }
}

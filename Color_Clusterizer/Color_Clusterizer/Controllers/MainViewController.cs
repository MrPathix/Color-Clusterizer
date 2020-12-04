using Color_Clusterizer.ClusteringAlgorithms;
using Color_Clusterizer.FilterMatrices;
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
        private IClusterizer uncertainty;

        public bool IsOperating { get => KmeansReport.IsOperating || PopularityReport.IsOperating || UncertaintyReport.IsOperating; }
        public BitmapWrapper ClusteredImage { get; set; }
        public ProgressReport KmeansReport { get; protected set; }
        public ProgressReport PopularityReport { get; protected set; }
        public ProgressReport UncertaintyReport { get; protected set; }

        public MainViewController() 
        {
            KmeansReport = new();
            PopularityReport = new();
            UncertaintyReport = new();
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

        public Task<Bitmap> GetUncertaintyClusteredImage(int k, FilterMatrix filter)
        {
            uncertainty = new UncertaintyClusteringAlgorithm(k, filter, UncertaintyReport);
            return Task.Run(() => uncertainty.Clusterize(ClusteredImage));
        }
    }
}

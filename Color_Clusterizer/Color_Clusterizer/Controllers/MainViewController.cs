using Color_Reducer.ReductionAlgorithms;
using Color_Reducer.FilterMatrices;
using Color_Reducer.Models;
using PD.BitmapWrapper;
using System.Drawing;
using System.Threading.Tasks;

namespace Color_Reducer.Controllers
{
    class MainViewController
    {
        private IReductionAlgorithm kmeans;
        private IReductionAlgorithm popularity;
        private IReductionAlgorithm uncertainty;

        public bool IsOperating 
        { 
            get => KmeansReport.IsOperating || PopularityReport.IsOperating || UncertaintyReport.IsOperating; 
        }
        public BitmapWrapper MainImage { get; set; }

        public ProgressReport KmeansReport { get; protected set; }
        public ProgressReport PopularityReport { get; protected set; }
        public ProgressReport UncertaintyReport { get; protected set; }

        public MainViewController() 
        {
            KmeansReport = new();
            PopularityReport = new();
            UncertaintyReport = new();
        }

        public Task<BitmapWrapper> GetKmeansReducedImage(int k, int epsilon)
        {
            kmeans = new KmeansReductionAlgorithm(k, epsilon, KmeansReport);
            return Task.Run(() => kmeans.Reduce(MainImage));
        }

        public Task<BitmapWrapper> GetPopularityReducedImage(int k)
        {
            popularity = new PopularityReductionAlgorithm(k, PopularityReport);
            return Task.Run(() => popularity.Reduce(MainImage));
        }

        public Task<BitmapWrapper> GetUncertaintyReducedImage(int k, FilterMatrix filter)
        {
            uncertainty = new UncertaintyReductionAlgorithm(k, filter, UncertaintyReport);
            return Task.Run(() => uncertainty.Reduce(MainImage));
        }
    }
}

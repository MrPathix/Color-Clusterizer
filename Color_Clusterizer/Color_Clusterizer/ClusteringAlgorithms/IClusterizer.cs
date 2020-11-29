using Color_Clusterizer.ExternalDependencies;
using Color_Clusterizer.Models;
using System.Drawing;
using System.Threading.Tasks;

namespace Color_Clusterizer.ClusteringAlgorithms
{
    public interface IClusterizer
    {
        public ProgressReport Report { get; }
        public Bitmap Clusterize(BitmapWrapper wrapper);
    }
}

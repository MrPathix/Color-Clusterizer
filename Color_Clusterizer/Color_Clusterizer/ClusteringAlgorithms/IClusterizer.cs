using Color_Clusterizer.ExternalDependencies;
using System.Drawing;
using System.Threading.Tasks;

namespace Color_Clusterizer.ClusteringAlgorithms
{
    public interface IClusterizer
    {
        public Bitmap Clusterize(BitmapWrapper wrapper);
    }
}

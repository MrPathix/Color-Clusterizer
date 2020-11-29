using Color_Clusterizer.Models;
using PD.BitmapWrapper;
using System.Drawing;

namespace Color_Clusterizer.ClusteringAlgorithms
{
    public interface IClusterizer
    {
        public ProgressReport Report { get; }
        public BitmapWrapper Clusterize(BitmapWrapper wrapper);
    }
}

using Color_Clusterizer.Models;
using PD.BitmapWrapper;
using System.Drawing;

namespace Color_Clusterizer.ClusteringAlgorithms
{
    public interface IClusterizer
    {
        public ProgressReport Report { get; }
        public Bitmap Clusterize(BitmapWrapper wrapper);
    }
}

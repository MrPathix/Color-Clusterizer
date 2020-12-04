using Color_Reducer.Models;
using PD.BitmapWrapper;
using System.Drawing;

namespace Color_Reducer.ReductionAlgorithms
{
    public interface IReductionAlgorithm
    {
        public ProgressReport Report { get; }
        public BitmapWrapper Reduce(BitmapWrapper wrapper);
    }
}

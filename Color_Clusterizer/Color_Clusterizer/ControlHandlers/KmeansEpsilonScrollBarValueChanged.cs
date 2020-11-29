using System;
using System.Windows.Forms;

namespace Color_Clusterizer
{
    public partial class ColorClusterizer
    {
        private int kmeansEpsilon = 3;
        private void KmeansEpsilonScrollBarValueChanged(object sender, EventArgs e)
        {
            TrackBar tb = sender as TrackBar;

            kmeansEpsilon = tb.Value;
            kmeansEpsilonLabel.Text = $"Epsilon value: {kmeansEpsilon}";
        }
    }
}

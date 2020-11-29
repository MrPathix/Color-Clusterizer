using System;
using System.Windows.Forms;

namespace Color_Clusterizer
{
    public partial class ColorClusterizer
    {
        private int clusterColorsQuantity = 4;
        private void ColorScrollBarValueChangedHandler(object sender, EventArgs e)
        {
            TrackBar tb = sender as TrackBar;

            clusterColorsQuantity = tb.Value;

            clusterButton.Text = $"Cluster image to {clusterColorsQuantity} color(s)";
        }
    }
}

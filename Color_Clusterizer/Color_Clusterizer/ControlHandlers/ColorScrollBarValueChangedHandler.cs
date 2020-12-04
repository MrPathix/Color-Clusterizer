using System;
using System.Windows.Forms;

namespace Color_Reducer
{
    public partial class ColorReducer
    {
        private int reductionColorsQuantity = 4;
        private void ColorScrollBarValueChangedHandler(object sender, EventArgs e)
        {
            TrackBar tb = sender as TrackBar;

            reductionColorsQuantity = tb.Value;

            reductionButton.Text = $"Cluster image to {reductionColorsQuantity} color(s)";
        }
    }
}

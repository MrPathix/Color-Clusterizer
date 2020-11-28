using Color_Clusterizer.ExternalDependencies;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Clusterizer
{
    public partial class ColorClusterizer
    {
        private async void ClusterImageButtonHandler(object sender, EventArgs e)
        {
            kmeansPictureBox.Image = await Controller.GetKmeansClusteredImage(clusterColorsBar.Value);
        }
    }
}

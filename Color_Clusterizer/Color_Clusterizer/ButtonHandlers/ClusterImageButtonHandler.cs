using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Clusterizer
{
    public partial class ColorClusterizer
    {
        private async void ClusterImageButtonHandler(object sender, EventArgs e)
        {
            if (Controller.ClusteredImage is null)
            {
                MessageBox.Show("No image to operate on.");
                return;
            }

            if (Controller.IsOperating)
            {
                MessageBox.Show("Please wait until the previous calculations are done.");
                return;
            }

            Task<Bitmap> kmeansTask = Controller.GetKmeansClusteredImage(clusterColorsQuantity, kmeansEpsilon);
            Task<Bitmap> popularityTask = Controller.GetPopularityClusteredImage(clusterColorsQuantity);

            List<Task> tasks = new();
            tasks.Add(Task.Run(async () => kmeansPictureBox.Image = await kmeansTask));
            tasks.Add(Task.Run(async () => popularityPictureBox.Image = await popularityTask));

            //await Task.WhenAll(tasks);
        }
    }
}

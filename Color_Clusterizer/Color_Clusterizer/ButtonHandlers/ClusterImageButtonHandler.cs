using PD.BitmapWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Clusterizer
{
    public partial class ColorClusterizer
    {
        private BitmapWrapper clusteredKmeans;
        private BitmapWrapper clusteredPopularity;
        private BitmapWrapper clusteredUncertainty;

        private void ClusterImageButtonHandler(object sender, EventArgs e)
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

            clusteredKmeans?.Dispose();
            clusteredPopularity?.Dispose();
            clusteredUncertainty?.Dispose();

            Task<BitmapWrapper> kmeansTask = Controller.GetKmeansClusteredImage(clusterColorsQuantity, kmeansEpsilon);
            Task<BitmapWrapper> popularityTask = Controller.GetPopularityClusteredImage(clusterColorsQuantity);
            Task<BitmapWrapper> uncertaintyTask = Controller.GetUncertaintyClusteredImage(clusterColorsQuantity, Filter);

            List<Task> tasks = new();
            tasks.Add(Task.Run(async () => 
            { 
                clusteredKmeans = await kmeansTask;
                kmeansPictureBox.Image = clusteredKmeans.Bitmap;
            }));

            tasks.Add(Task.Run(async () =>
            {
                clusteredPopularity = await popularityTask;
                popularityPictureBox.Image = clusteredPopularity.Bitmap;
            })); 
            
            tasks.Add(Task.Run(async () =>
            {
                clusteredUncertainty = await uncertaintyTask;
                uncertaintyPictureBox.Image = clusteredUncertainty.Bitmap;
            }));
        }
    }
}

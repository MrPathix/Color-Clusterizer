using PD.BitmapWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Reducer
{
    public partial class ColorReducer
    {
        private BitmapWrapper clusteredKmeans;
        private BitmapWrapper clusteredPopularity;
        private BitmapWrapper clusteredUncertainty;

        private void ReduceImageButtonHandler(object sender, EventArgs e)
        {
            if (Controller.MainImage is null)
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

            Task<BitmapWrapper> kmeansTask = Controller.GetKmeansReducedImage(reductionColorsQuantity, kmeansEpsilon);
            Task<BitmapWrapper> popularityTask = Controller.GetPopularityReducedImage(reductionColorsQuantity);
            Task<BitmapWrapper> uncertaintyTask = Controller.GetUncertaintyReducedImage(reductionColorsQuantity, Filter);

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

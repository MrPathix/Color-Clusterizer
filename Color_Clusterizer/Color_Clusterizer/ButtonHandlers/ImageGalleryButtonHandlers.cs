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
        private Dictionary<string, BitmapWrapper> galleryImages = new();

        private void InitializeImageGallery()
        {
            Bitmap forest = new(forestButton.BackgroundImage);
            galleryImages.Add("forestButton", new(forest));
            forest.Dispose();

            Bitmap fireworks = new(fireworksButton.BackgroundImage);
            galleryImages.Add("fireworksButton", new(fireworks));
            fireworks.Dispose();

            Bitmap mini = new(miniButton.BackgroundImage);
            galleryImages.Add("miniButton", new(mini));
            mini.Dispose();

            Bitmap mountains = new(mountainButton.BackgroundImage);
            galleryImages.Add("mountainButton", new(mountains));
            mountains.Dispose();

            Bitmap vacation = new(vacationButton.BackgroundImage);
            galleryImages.Add("vacationButton", new(vacation));
            vacation.Dispose();

            Bitmap warsaw = new(warsawButton.BackgroundImage);
            galleryImages.Add("warsawButton", new(warsaw));
            warsaw.Dispose();
        }

        private void ImageButtonHandler(object sender, EventArgs e)
        {
            if (Controller.IsOperating)
            {
                MessageBox.Show("Cannot change the image until the calculations are over.");
                return;
            }

            kmeansPictureBox.Image?.Dispose();
            kmeansPictureBox.Image = null;

            popularityPictureBox.Image?.Dispose();
            popularityPictureBox.Image = null;

            uncertaintyPictureBox.Image?.Dispose();
            uncertaintyPictureBox.Image = null;

            if (!galleryImages.ContainsValue(Controller.ClusteredImage) && Controller.ClusteredImage is not null)
            {
                Controller.ClusteredImage.Dispose();
            }

            Controller.ClusteredImage = galleryImages[(sender as Button).Name];
            mainPictureBox.Image = Controller.ClusteredImage.Bitmap;
        }
    }
}
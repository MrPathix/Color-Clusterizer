using Color_Clusterizer.ExternalDependencies;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Color_Clusterizer
{
    public partial class ColorClusterizer
    {
        private void ChangeImageButtonHandler(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap imageFile = new Bitmap(Image.FromFile(dialog.FileName));

                Controller.ClusteredImage?.Dispose();
                Controller.ClusteredImage = new BitmapWrapper(imageFile);

                mainPictureBox.Image = Controller.ClusteredImage.Bitmap;
                kmeansPictureBox.Image = null;
                uncertaintyPictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("Could not load image from file.");
            }
        }
    }
}

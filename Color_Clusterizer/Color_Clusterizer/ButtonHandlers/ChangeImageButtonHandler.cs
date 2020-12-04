using System;
using System.Drawing;
using System.Windows.Forms;

namespace Color_Reducer
{
    public partial class ColorReducer
    {
        private void ChangeImageButtonHandler(object sender, EventArgs e)
        {
            if (Controller.IsOperating)
            {
                MessageBox.Show("Cannot load file until the calculations are over.");
                return;
            }

            OpenFileDialog dialog = new()
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap imageFile = new(Image.FromFile(dialog.FileName));

                Controller.MainImage?.Dispose();
                Controller.MainImage = new(imageFile);
                mainPictureBox.Image = Controller.MainImage.Bitmap;

                kmeansPictureBox.Image?.Dispose();
                kmeansPictureBox.Image = null;

                popularityPictureBox.Image?.Dispose();
                popularityPictureBox.Image = null;

                uncertaintyPictureBox.Image?.Dispose();
                uncertaintyPictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("Could not load image from file.");
            }

            dialog.Dispose();
        }
    }
}

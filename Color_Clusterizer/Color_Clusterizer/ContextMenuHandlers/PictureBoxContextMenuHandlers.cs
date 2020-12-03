using PD.BitmapWrapper;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Color_Clusterizer
{
    public partial class ColorClusterizer
    {
        private void InitializeContextMenus()
        {
            ContextMenuStrip contextMain = new();
            ContextMenuStrip contextKmeans = new();
            ContextMenuStrip contextUncertainty = new();
            ContextMenuStrip contextPopularity = new();

            ToolStripMenuItem mainSave = new("Save to file...");
            ToolStripMenuItem kmeansSave = new("Save to file...");
            ToolStripMenuItem uncertaintySave = new("Save to file...");
            ToolStripMenuItem popularitySave = new("Save to file...");

            mainSave.Click += ContextMenuSaveMainImage;

            kmeansSave.Click += ContextMenuSaveImageHandler;
            kmeansSave.Name = "kmeans";

            uncertaintySave.Click += ContextMenuSaveImageHandler;
            uncertaintySave.Name = "uncertainty";

            popularitySave.Click += ContextMenuSaveImageHandler;
            popularitySave.Name = "popularity";

            contextMain.Items.Add(mainSave);
            contextKmeans.Items.Add(kmeansSave);
            contextUncertainty.Items.Add(uncertaintySave);
            contextPopularity.Items.Add(popularitySave);

            mainPictureBox.ContextMenuStrip = contextMain;
            kmeansPictureBox.ContextMenuStrip = contextKmeans;
            uncertaintyPictureBox.ContextMenuStrip = contextUncertainty;
            popularityPictureBox.ContextMenuStrip = contextPopularity;
        }

        private void ContextMenuSaveMainImage(object sender, EventArgs e)
        {
            if (Controller.ClusteredImage is null)
            {
                MessageBox.Show($"No image to save.");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Image File(*.jpeg)|*.jpeg;"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Controller.ClusteredImage.Bitmap.Save(dialog.FileName, ImageFormat.Jpeg);
            }
            else
            {
                MessageBox.Show("[ERROR] Couldn't save to file.");
            }

            dialog.Dispose();
        }

        private void ContextMenuSaveImageHandler(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;

            // propagation of uncertainty not implemented yet
            PictureBox pb = item.Name switch
            {
                "kmeans" => kmeansPictureBox,
                "uncertainty" => uncertaintyPictureBox,
                "popularity" => popularityPictureBox,
                _ => null
            };

            if (pb.Image is null)
            {
                MessageBox.Show($"No image to save.");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Image File(*.jpeg)|*.jpeg;"
            };
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pb.Image.Save(dialog.FileName, ImageFormat.Jpeg);
            }
            else
            {
                MessageBox.Show("[ERROR] Couldn't save to file.");
            }

            dialog.Dispose();
        }
    }
}

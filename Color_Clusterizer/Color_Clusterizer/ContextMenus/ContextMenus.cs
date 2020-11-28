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
            ContextMenuStrip contextKmeans = new ContextMenuStrip();
            ContextMenuStrip contextUncertainty = new ContextMenuStrip();

            ToolStripMenuItem kmeansSave = new ToolStripMenuItem("Save to file...");
            ToolStripMenuItem uncertaintySave = new ToolStripMenuItem("Save to file...");
            
            kmeansSave.Click += ContextMenuSaveImageHandler;
            kmeansSave.Name = "kmeans";

            uncertaintySave.Click += ContextMenuSaveImageHandler;
            uncertaintySave.Name = "uncertainty";

            contextKmeans.Items.Add(kmeansSave);
            contextUncertainty.Items.Add(uncertaintySave);

            kmeansPictureBox.ContextMenuStrip = contextKmeans;
            uncertaintyPictureBox.ContextMenuStrip = contextUncertainty;
        }

        private void ContextMenuSaveImageHandler(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;

            PictureBox pb = item.Name.Equals("kmeans") ? kmeansPictureBox : uncertaintyPictureBox;
            Image savedImage = pb.Image;

            if (savedImage is null)
            {
                MessageBox.Show("No image to save.");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                savedImage.Save(dialog.FileName, ImageFormat.Jpeg);
            }
            else
            {
                MessageBox.Show("[ERROR] Couldn't save to file.");
            }
        }
    }
}

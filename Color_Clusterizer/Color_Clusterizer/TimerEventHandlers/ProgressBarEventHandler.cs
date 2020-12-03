using System;
using System.Windows.Forms;

namespace Color_Clusterizer
{
    public partial class ColorClusterizer
    {
        private readonly int FPS = 50;
        private Timer progressTimer;

        private void InitializeProgressTimer()
        {
            progressTimer = new()
            {
                Interval = 1000 / FPS
            };

            progressTimer.Tick += ProgressBarEventHandler;

            progressTimer.Start();
        }

        private void ProgressBarEventHandler(object sender, EventArgs e)
        {
            if (!Controller.KmeansReport.IsOperating)
            {
                kmeansProgressBar.Visible = false;
            }
            else
            {
                kmeansProgressBar.Visible = true;
                kmeansProgressBar.Value = Controller.KmeansReport.Progress;

                kmeansPictureBox.Image = Controller.KmeansReport.Bitmap;
            }

            if (!Controller.PopularityReport.IsOperating)
            {
                popularityProgressBar.Visible = false;
            }
            else
            {
                popularityProgressBar.Visible = true;
                popularityProgressBar.Value = Controller.PopularityReport.Progress;

                popularityPictureBox.Image = Controller.PopularityReport.Bitmap;
            }
        }
    }
}

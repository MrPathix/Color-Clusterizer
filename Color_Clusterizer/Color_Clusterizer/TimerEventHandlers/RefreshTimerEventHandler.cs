using System;
using System.Windows.Forms;

namespace Color_Clusterizer
{
    public partial class ColorClusterizer
    {
        private Timer refreshTimer;
        private int FPS = 50;

        private void InitializeRefreshTimer()
        {
            refreshTimer = new Timer
            {
                Interval = 1000 / FPS
            };

            refreshTimer.Tick += RefreshTimerEvent;
            refreshTimer.Start();
        }

        private void RefreshTimerEvent(object sender, EventArgs e)
        {
            if (Controller.ClusteredImage is null) return;

            mainPictureBox.Image = Controller.ClusteredImage.Bitmap;
        }
    }
}

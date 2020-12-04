using System;
using System.Windows.Forms;

namespace Color_Reducer
{
    public partial class ColorReducer
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
            kmeansProgressBar.Visible = Controller.KmeansReport.IsOperating;
            popularityProgressBar.Visible = Controller.PopularityReport.IsOperating;
            uncertaintyProgressBar.Visible = Controller.UncertaintyReport.IsOperating;

            if (Controller.KmeansReport.IsOperating)
            {
                kmeansProgressBar.Value = Controller.KmeansReport.Progress;
                kmeansPictureBox.Image = Controller.KmeansReport.Bitmap;
            }

            if (Controller.PopularityReport.IsOperating)
            {
                popularityProgressBar.Value = Controller.PopularityReport.Progress;
            }

            if (Controller.UncertaintyReport.IsOperating)
            {
                uncertaintyProgressBar.Value = Controller.PopularityReport.Progress;
                uncertaintyPictureBox.Image = Controller.UncertaintyReport.Bitmap;
            }
        }
    }
}

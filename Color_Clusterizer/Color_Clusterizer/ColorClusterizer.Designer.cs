
namespace Color_Clusterizer
{
    partial class ColorClusterizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorClusterizer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clusterButton = new System.Windows.Forms.Button();
            this.clusterColorsBar = new System.Windows.Forms.TrackBar();
            this.changeImageButton = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kmeansLabel = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.kmeansPictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uncertaintyLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.uncertaintyPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterColorsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kmeansPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uncertaintyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clusterButton);
            this.panel1.Controls.Add(this.clusterColorsBar);
            this.panel1.Controls.Add(this.changeImageButton);
            this.panel1.Controls.Add(this.mainPictureBox);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 659);
            this.panel1.TabIndex = 0;
            // 
            // clusterButton
            // 
            this.clusterButton.Location = new System.Drawing.Point(288, 612);
            this.clusterButton.Name = "clusterButton";
            this.clusterButton.Size = new System.Drawing.Size(207, 33);
            this.clusterButton.TabIndex = 3;
            this.clusterButton.Text = "Cluster image to (k) colors";
            this.clusterButton.UseVisualStyleBackColor = true;
            // 
            // clusterColorsBar
            // 
            this.clusterColorsBar.Location = new System.Drawing.Point(17, 563);
            this.clusterColorsBar.Maximum = 64;
            this.clusterColorsBar.Minimum = 1;
            this.clusterColorsBar.Name = "clusterColorsBar";
            this.clusterColorsBar.Size = new System.Drawing.Size(752, 45);
            this.clusterColorsBar.TabIndex = 2;
            this.clusterColorsBar.Value = 1;
            // 
            // changeImageButton
            // 
            this.changeImageButton.Location = new System.Drawing.Point(12, 474);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.Size = new System.Drawing.Size(118, 32);
            this.changeImageButton.TabIndex = 1;
            this.changeImageButton.Text = "Change image";
            this.changeImageButton.UseVisualStyleBackColor = true;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPictureBox.Location = new System.Drawing.Point(10, 11);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(760, 449);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.kmeansLabel);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Controls.Add(this.kmeansPictureBox);
            this.panel2.Location = new System.Drawing.Point(786, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 327);
            this.panel2.TabIndex = 1;
            // 
            // kmeansLabel
            // 
            this.kmeansLabel.AutoSize = true;
            this.kmeansLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kmeansLabel.Location = new System.Drawing.Point(62, 24);
            this.kmeansLabel.Name = "kmeansLabel";
            this.kmeansLabel.Size = new System.Drawing.Size(276, 21);
            this.kmeansLabel.TabIndex = 2;
            this.kmeansLabel.Text = "Clustered using k-means algorithm";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(207, 276);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(168, 26);
            this.progressBar2.TabIndex = 1;
            this.progressBar2.Visible = false;
            // 
            // kmeansPictureBox
            // 
            this.kmeansPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kmeansPictureBox.Location = new System.Drawing.Point(10, 70);
            this.kmeansPictureBox.Name = "kmeansPictureBox";
            this.kmeansPictureBox.Size = new System.Drawing.Size(372, 243);
            this.kmeansPictureBox.TabIndex = 0;
            this.kmeansPictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.uncertaintyLabel);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.uncertaintyPictureBox);
            this.panel3.Location = new System.Drawing.Point(786, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 329);
            this.panel3.TabIndex = 2;
            // 
            // uncertaintyLabel
            // 
            this.uncertaintyLabel.AutoSize = true;
            this.uncertaintyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uncertaintyLabel.Location = new System.Drawing.Point(26, 25);
            this.uncertaintyLabel.Name = "uncertaintyLabel";
            this.uncertaintyLabel.Size = new System.Drawing.Size(339, 21);
            this.uncertaintyLabel.TabIndex = 2;
            this.uncertaintyLabel.Text = "Clustered using propagation of uncertainty";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(207, 282);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(168, 26);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // uncertaintyPictureBox
            // 
            this.uncertaintyPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uncertaintyPictureBox.Location = new System.Drawing.Point(10, 73);
            this.uncertaintyPictureBox.Name = "uncertaintyPictureBox";
            this.uncertaintyPictureBox.Size = new System.Drawing.Size(372, 243);
            this.uncertaintyPictureBox.TabIndex = 0;
            this.uncertaintyPictureBox.TabStop = false;
            // 
            // ColorClusterizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "ColorClusterizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Clusterizer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterColorsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kmeansPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uncertaintyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clusterButton;
        private System.Windows.Forms.TrackBar clusterColorsBar;
        private System.Windows.Forms.Button changeImageButton;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label kmeansLabel;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.PictureBox kmeansPictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label uncertaintyLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox uncertaintyPictureBox;
    }
}


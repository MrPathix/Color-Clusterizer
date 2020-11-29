
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
            this.kmeansEpsilonLabel = new System.Windows.Forms.Label();
            this.kmeansEpsilonTrackBar = new System.Windows.Forms.TrackBar();
            this.kmeansLabel = new System.Windows.Forms.Label();
            this.kmeansProgressBar = new System.Windows.Forms.ProgressBar();
            this.kmeansPictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uncertaintyLabel = new System.Windows.Forms.Label();
            this.uncertaintyProgressBar = new System.Windows.Forms.ProgressBar();
            this.uncertaintyPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterColorsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kmeansEpsilonTrackBar)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 878);
            this.panel1.TabIndex = 0;
            // 
            // clusterButton
            // 
            this.clusterButton.Location = new System.Drawing.Point(329, 816);
            this.clusterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clusterButton.Name = "clusterButton";
            this.clusterButton.Size = new System.Drawing.Size(237, 44);
            this.clusterButton.TabIndex = 3;
            this.clusterButton.Text = "Cluster image to 4 color(s)";
            this.clusterButton.UseVisualStyleBackColor = true;
            this.clusterButton.Click += new System.EventHandler(this.ClusterImageButtonHandler);
            // 
            // clusterColorsBar
            // 
            this.clusterColorsBar.Location = new System.Drawing.Point(19, 751);
            this.clusterColorsBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clusterColorsBar.Maximum = 64;
            this.clusterColorsBar.Minimum = 1;
            this.clusterColorsBar.Name = "clusterColorsBar";
            this.clusterColorsBar.Size = new System.Drawing.Size(859, 56);
            this.clusterColorsBar.TabIndex = 2;
            this.clusterColorsBar.Value = 4;
            this.clusterColorsBar.Scroll += new System.EventHandler(this.ColorScrollBarValueChangedHandler);
            // 
            // changeImageButton
            // 
            this.changeImageButton.Location = new System.Drawing.Point(14, 632);
            this.changeImageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.Size = new System.Drawing.Size(135, 43);
            this.changeImageButton.TabIndex = 1;
            this.changeImageButton.Text = "Change image";
            this.changeImageButton.UseVisualStyleBackColor = true;
            this.changeImageButton.Click += new System.EventHandler(this.ChangeImageButtonHandler);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPictureBox.Location = new System.Drawing.Point(11, 15);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(869, 599);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.kmeansEpsilonLabel);
            this.panel2.Controls.Add(this.kmeansEpsilonTrackBar);
            this.panel2.Controls.Add(this.kmeansLabel);
            this.panel2.Controls.Add(this.kmeansProgressBar);
            this.panel2.Controls.Add(this.kmeansPictureBox);
            this.panel2.Location = new System.Drawing.Point(898, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 435);
            this.panel2.TabIndex = 1;
            // 
            // kmeansEpsilonLabel
            // 
            this.kmeansEpsilonLabel.AutoSize = true;
            this.kmeansEpsilonLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kmeansEpsilonLabel.Location = new System.Drawing.Point(14, 397);
            this.kmeansEpsilonLabel.Name = "kmeansEpsilonLabel";
            this.kmeansEpsilonLabel.Size = new System.Drawing.Size(134, 25);
            this.kmeansEpsilonLabel.TabIndex = 4;
            this.kmeansEpsilonLabel.Text = "Epsilon value: 3";
            // 
            // kmeansEpsilonTrackBar
            // 
            this.kmeansEpsilonTrackBar.Location = new System.Drawing.Point(11, 364);
            this.kmeansEpsilonTrackBar.Maximum = 64;
            this.kmeansEpsilonTrackBar.Minimum = 1;
            this.kmeansEpsilonTrackBar.Name = "kmeansEpsilonTrackBar";
            this.kmeansEpsilonTrackBar.Size = new System.Drawing.Size(425, 56);
            this.kmeansEpsilonTrackBar.TabIndex = 3;
            this.kmeansEpsilonTrackBar.Value = 3;
            this.kmeansEpsilonTrackBar.Scroll += new System.EventHandler(this.KmeansEpsilonScrollBarValueChanged);
            // 
            // kmeansLabel
            // 
            this.kmeansLabel.AutoSize = true;
            this.kmeansLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kmeansLabel.Location = new System.Drawing.Point(55, 15);
            this.kmeansLabel.Name = "kmeansLabel";
            this.kmeansLabel.Size = new System.Drawing.Size(342, 28);
            this.kmeansLabel.TabIndex = 2;
            this.kmeansLabel.Text = "Clustered using k-means algorithm";
            // 
            // kmeansProgressBar
            // 
            this.kmeansProgressBar.Location = new System.Drawing.Point(235, 311);
            this.kmeansProgressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kmeansProgressBar.Name = "kmeansProgressBar";
            this.kmeansProgressBar.Size = new System.Drawing.Size(192, 22);
            this.kmeansProgressBar.TabIndex = 1;
            this.kmeansProgressBar.Visible = false;
            // 
            // kmeansPictureBox
            // 
            this.kmeansPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kmeansPictureBox.Location = new System.Drawing.Point(11, 53);
            this.kmeansPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kmeansPictureBox.Name = "kmeansPictureBox";
            this.kmeansPictureBox.Size = new System.Drawing.Size(425, 292);
            this.kmeansPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kmeansPictureBox.TabIndex = 0;
            this.kmeansPictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.uncertaintyLabel);
            this.panel3.Controls.Add(this.uncertaintyProgressBar);
            this.panel3.Controls.Add(this.uncertaintyPictureBox);
            this.panel3.Location = new System.Drawing.Point(898, 443);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 438);
            this.panel3.TabIndex = 2;
            // 
            // uncertaintyLabel
            // 
            this.uncertaintyLabel.AutoSize = true;
            this.uncertaintyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uncertaintyLabel.Location = new System.Drawing.Point(14, 19);
            this.uncertaintyLabel.Name = "uncertaintyLabel";
            this.uncertaintyLabel.Size = new System.Drawing.Size(422, 28);
            this.uncertaintyLabel.TabIndex = 2;
            this.uncertaintyLabel.Text = "Clustered using propagation of uncertainty";
            // 
            // uncertaintyProgressBar
            // 
            this.uncertaintyProgressBar.Location = new System.Drawing.Point(235, 322);
            this.uncertaintyProgressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uncertaintyProgressBar.Name = "uncertaintyProgressBar";
            this.uncertaintyProgressBar.Size = new System.Drawing.Size(192, 22);
            this.uncertaintyProgressBar.TabIndex = 1;
            this.uncertaintyProgressBar.Visible = false;
            // 
            // uncertaintyPictureBox
            // 
            this.uncertaintyPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uncertaintyPictureBox.Location = new System.Drawing.Point(11, 64);
            this.uncertaintyPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uncertaintyPictureBox.Name = "uncertaintyPictureBox";
            this.uncertaintyPictureBox.Size = new System.Drawing.Size(425, 292);
            this.uncertaintyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uncertaintyPictureBox.TabIndex = 0;
            this.uncertaintyPictureBox.TabStop = false;
            // 
            // ColorClusterizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 871);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1369, 918);
            this.MinimumSize = new System.Drawing.Size(1369, 918);
            this.Name = "ColorClusterizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Clusterizer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterColorsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kmeansEpsilonTrackBar)).EndInit();
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
        private System.Windows.Forms.ProgressBar kmeansProgressBar;
        private System.Windows.Forms.PictureBox kmeansPictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label uncertaintyLabel;
        private System.Windows.Forms.Label kmeansEpsilonLabel;
        private System.Windows.Forms.TrackBar kmeansEpsilonTrackBar;
        private System.Windows.Forms.ProgressBar uncertaintyProgressBar;
        private System.Windows.Forms.PictureBox uncertaintyPictureBox;
    }
}


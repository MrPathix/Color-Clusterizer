
namespace Color_Reducer
{
    partial class ColorReducer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorReducer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reductionButton = new System.Windows.Forms.Button();
            this.changeImageButton = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.clusterColorsBar = new System.Windows.Forms.TrackBar();
            this.kmeansEpsilonLabel = new System.Windows.Forms.Label();
            this.kmeansEpsilonTrackBar = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kmeansLabel = new System.Windows.Forms.Label();
            this.kmeansProgressBar = new System.Windows.Forms.ProgressBar();
            this.kmeansPictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.stuckyRadioButton = new System.Windows.Forms.RadioButton();
            this.burkesRadioButton = new System.Windows.Forms.RadioButton();
            this.floydSteinbergRadioButton = new System.Windows.Forms.RadioButton();
            this.uncertaintyLabel = new System.Windows.Forms.Label();
            this.uncertaintyProgressBar = new System.Windows.Forms.ProgressBar();
            this.uncertaintyPictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.popularityLabel = new System.Windows.Forms.Label();
            this.popularityProgressBar = new System.Windows.Forms.ProgressBar();
            this.popularityPictureBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.vacationButton = new System.Windows.Forms.Button();
            this.mountainButton = new System.Windows.Forms.Button();
            this.forestButton = new System.Windows.Forms.Button();
            this.miniButton = new System.Windows.Forms.Button();
            this.warsawButton = new System.Windows.Forms.Button();
            this.fireworksButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clusterColorsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmeansEpsilonTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kmeansPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uncertaintyPictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularityPictureBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reductionButton);
            this.panel1.Controls.Add(this.changeImageButton);
            this.panel1.Controls.Add(this.mainPictureBox);
            this.panel1.Controls.Add(this.clusterColorsBar);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 559);
            this.panel1.TabIndex = 0;
            // 
            // reductionButton
            // 
            this.reductionButton.Location = new System.Drawing.Point(646, 497);
            this.reductionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reductionButton.Name = "reductionButton";
            this.reductionButton.Size = new System.Drawing.Size(237, 44);
            this.reductionButton.TabIndex = 3;
            this.reductionButton.Text = "Cluster image to 4 color(s)";
            this.reductionButton.UseVisualStyleBackColor = true;
            this.reductionButton.Click += new System.EventHandler(this.ReduceImageButtonHandler);
            // 
            // changeImageButton
            // 
            this.changeImageButton.Location = new System.Drawing.Point(27, 497);
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
            this.mainPictureBox.Location = new System.Drawing.Point(58, 9);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(782, 467);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // clusterColorsBar
            // 
            this.clusterColorsBar.Location = new System.Drawing.Point(211, 502);
            this.clusterColorsBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clusterColorsBar.Maximum = 64;
            this.clusterColorsBar.Minimum = 1;
            this.clusterColorsBar.Name = "clusterColorsBar";
            this.clusterColorsBar.Size = new System.Drawing.Size(413, 56);
            this.clusterColorsBar.TabIndex = 2;
            this.clusterColorsBar.Value = 4;
            this.clusterColorsBar.Scroll += new System.EventHandler(this.ColorScrollBarValueChangedHandler);
            // 
            // kmeansEpsilonLabel
            // 
            this.kmeansEpsilonLabel.AutoSize = true;
            this.kmeansEpsilonLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kmeansEpsilonLabel.Location = new System.Drawing.Point(11, 77);
            this.kmeansEpsilonLabel.Name = "kmeansEpsilonLabel";
            this.kmeansEpsilonLabel.Size = new System.Drawing.Size(134, 25);
            this.kmeansEpsilonLabel.TabIndex = 4;
            this.kmeansEpsilonLabel.Text = "Epsilon value: 3";
            // 
            // kmeansEpsilonTrackBar
            // 
            this.kmeansEpsilonTrackBar.Location = new System.Drawing.Point(11, 46);
            this.kmeansEpsilonTrackBar.Maximum = 64;
            this.kmeansEpsilonTrackBar.Minimum = 1;
            this.kmeansEpsilonTrackBar.Name = "kmeansEpsilonTrackBar";
            this.kmeansEpsilonTrackBar.Size = new System.Drawing.Size(425, 56);
            this.kmeansEpsilonTrackBar.TabIndex = 3;
            this.kmeansEpsilonTrackBar.Value = 3;
            this.kmeansEpsilonTrackBar.Scroll += new System.EventHandler(this.KmeansEpsilonScrollBarValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.kmeansEpsilonLabel);
            this.panel2.Controls.Add(this.kmeansLabel);
            this.panel2.Controls.Add(this.kmeansProgressBar);
            this.panel2.Controls.Add(this.kmeansEpsilonTrackBar);
            this.panel2.Controls.Add(this.kmeansPictureBox);
            this.panel2.Location = new System.Drawing.Point(913, 568);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 423);
            this.panel2.TabIndex = 1;
            // 
            // kmeansLabel
            // 
            this.kmeansLabel.AutoSize = true;
            this.kmeansLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kmeansLabel.Location = new System.Drawing.Point(59, 15);
            this.kmeansLabel.Name = "kmeansLabel";
            this.kmeansLabel.Size = new System.Drawing.Size(334, 28);
            this.kmeansLabel.TabIndex = 2;
            this.kmeansLabel.Text = "Reduced using k-means algorithm";
            // 
            // kmeansProgressBar
            // 
            this.kmeansProgressBar.Location = new System.Drawing.Point(234, 380);
            this.kmeansProgressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kmeansProgressBar.Name = "kmeansProgressBar";
            this.kmeansProgressBar.Size = new System.Drawing.Size(192, 22);
            this.kmeansProgressBar.TabIndex = 1;
            this.kmeansProgressBar.Visible = false;
            // 
            // kmeansPictureBox
            // 
            this.kmeansPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kmeansPictureBox.Location = new System.Drawing.Point(11, 122);
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
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.stuckyRadioButton);
            this.panel3.Controls.Add(this.burkesRadioButton);
            this.panel3.Controls.Add(this.floydSteinbergRadioButton);
            this.panel3.Controls.Add(this.uncertaintyLabel);
            this.panel3.Controls.Add(this.uncertaintyProgressBar);
            this.panel3.Controls.Add(this.uncertaintyPictureBox);
            this.panel3.Location = new System.Drawing.Point(1, 568);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 423);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select filter matrix:";
            // 
            // stuckyRadioButton
            // 
            this.stuckyRadioButton.AutoSize = true;
            this.stuckyRadioButton.Location = new System.Drawing.Point(351, 84);
            this.stuckyRadioButton.Name = "stuckyRadioButton";
            this.stuckyRadioButton.Size = new System.Drawing.Size(72, 24);
            this.stuckyRadioButton.TabIndex = 5;
            this.stuckyRadioButton.Text = "Stucky";
            this.stuckyRadioButton.UseVisualStyleBackColor = true;
            this.stuckyRadioButton.CheckedChanged += new System.EventHandler(this.FilterMatrixRadioButtonsHandler);
            // 
            // burkesRadioButton
            // 
            this.burkesRadioButton.AutoSize = true;
            this.burkesRadioButton.Location = new System.Drawing.Point(211, 84);
            this.burkesRadioButton.Name = "burkesRadioButton";
            this.burkesRadioButton.Size = new System.Drawing.Size(73, 24);
            this.burkesRadioButton.TabIndex = 4;
            this.burkesRadioButton.Text = "Burkes";
            this.burkesRadioButton.UseVisualStyleBackColor = true;
            this.burkesRadioButton.CheckedChanged += new System.EventHandler(this.FilterMatrixRadioButtonsHandler);
            // 
            // floydSteinbergRadioButton
            // 
            this.floydSteinbergRadioButton.AutoSize = true;
            this.floydSteinbergRadioButton.Checked = true;
            this.floydSteinbergRadioButton.Location = new System.Drawing.Point(27, 84);
            this.floydSteinbergRadioButton.Name = "floydSteinbergRadioButton";
            this.floydSteinbergRadioButton.Size = new System.Drawing.Size(136, 24);
            this.floydSteinbergRadioButton.TabIndex = 3;
            this.floydSteinbergRadioButton.TabStop = true;
            this.floydSteinbergRadioButton.Text = "Floyd-Steinberg";
            this.floydSteinbergRadioButton.UseVisualStyleBackColor = true;
            this.floydSteinbergRadioButton.CheckedChanged += new System.EventHandler(this.FilterMatrixRadioButtonsHandler);
            // 
            // uncertaintyLabel
            // 
            this.uncertaintyLabel.AutoSize = true;
            this.uncertaintyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uncertaintyLabel.Location = new System.Drawing.Point(18, 15);
            this.uncertaintyLabel.Name = "uncertaintyLabel";
            this.uncertaintyLabel.Size = new System.Drawing.Size(414, 28);
            this.uncertaintyLabel.TabIndex = 2;
            this.uncertaintyLabel.Text = "Reduced using propagation of uncertainty";
            // 
            // uncertaintyProgressBar
            // 
            this.uncertaintyProgressBar.Location = new System.Drawing.Point(231, 380);
            this.uncertaintyProgressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uncertaintyProgressBar.Name = "uncertaintyProgressBar";
            this.uncertaintyProgressBar.Size = new System.Drawing.Size(192, 22);
            this.uncertaintyProgressBar.TabIndex = 1;
            this.uncertaintyProgressBar.Visible = false;
            // 
            // uncertaintyPictureBox
            // 
            this.uncertaintyPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uncertaintyPictureBox.Location = new System.Drawing.Point(11, 122);
            this.uncertaintyPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uncertaintyPictureBox.Name = "uncertaintyPictureBox";
            this.uncertaintyPictureBox.Size = new System.Drawing.Size(425, 292);
            this.uncertaintyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uncertaintyPictureBox.TabIndex = 0;
            this.uncertaintyPictureBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.popularityLabel);
            this.panel4.Controls.Add(this.popularityProgressBar);
            this.panel4.Controls.Add(this.popularityPictureBox);
            this.panel4.Location = new System.Drawing.Point(457, 568);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 423);
            this.panel4.TabIndex = 1;
            // 
            // popularityLabel
            // 
            this.popularityLabel.AutoSize = true;
            this.popularityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.popularityLabel.Location = new System.Drawing.Point(47, 15);
            this.popularityLabel.Name = "popularityLabel";
            this.popularityLabel.Size = new System.Drawing.Size(353, 28);
            this.popularityLabel.TabIndex = 2;
            this.popularityLabel.Text = "Reduced using popularity algorithm";
            // 
            // popularityProgressBar
            // 
            this.popularityProgressBar.Location = new System.Drawing.Point(235, 380);
            this.popularityProgressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popularityProgressBar.Name = "popularityProgressBar";
            this.popularityProgressBar.Size = new System.Drawing.Size(192, 22);
            this.popularityProgressBar.TabIndex = 1;
            this.popularityProgressBar.Visible = false;
            // 
            // popularityPictureBox
            // 
            this.popularityPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.popularityPictureBox.Location = new System.Drawing.Point(14, 122);
            this.popularityPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popularityPictureBox.Name = "popularityPictureBox";
            this.popularityPictureBox.Size = new System.Drawing.Size(425, 292);
            this.popularityPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.popularityPictureBox.TabIndex = 0;
            this.popularityPictureBox.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Location = new System.Drawing.Point(913, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(449, 559);
            this.panel5.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.vacationButton);
            this.flowLayoutPanel1.Controls.Add(this.mountainButton);
            this.flowLayoutPanel1.Controls.Add(this.forestButton);
            this.flowLayoutPanel1.Controls.Add(this.miniButton);
            this.flowLayoutPanel1.Controls.Add(this.warsawButton);
            this.flowLayoutPanel1.Controls.Add(this.fireworksButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(447, 557);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // vacationButton
            // 
            this.vacationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vacationButton.BackgroundImage")));
            this.vacationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vacationButton.Location = new System.Drawing.Point(3, 3);
            this.vacationButton.Name = "vacationButton";
            this.vacationButton.Size = new System.Drawing.Size(217, 179);
            this.vacationButton.TabIndex = 0;
            this.vacationButton.UseVisualStyleBackColor = true;
            this.vacationButton.Click += new System.EventHandler(this.ImageButtonHandler);
            // 
            // mountainButton
            // 
            this.mountainButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mountainButton.BackgroundImage")));
            this.mountainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mountainButton.Location = new System.Drawing.Point(226, 3);
            this.mountainButton.Name = "mountainButton";
            this.mountainButton.Size = new System.Drawing.Size(217, 179);
            this.mountainButton.TabIndex = 1;
            this.mountainButton.UseVisualStyleBackColor = true;
            this.mountainButton.Click += new System.EventHandler(this.ImageButtonHandler);
            // 
            // forestButton
            // 
            this.forestButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forestButton.BackgroundImage")));
            this.forestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forestButton.Location = new System.Drawing.Point(3, 188);
            this.forestButton.Name = "forestButton";
            this.forestButton.Size = new System.Drawing.Size(217, 179);
            this.forestButton.TabIndex = 2;
            this.forestButton.UseVisualStyleBackColor = true;
            this.forestButton.Click += new System.EventHandler(this.ImageButtonHandler);
            // 
            // miniButton
            // 
            this.miniButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("miniButton.BackgroundImage")));
            this.miniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniButton.Location = new System.Drawing.Point(226, 188);
            this.miniButton.Name = "miniButton";
            this.miniButton.Size = new System.Drawing.Size(217, 179);
            this.miniButton.TabIndex = 3;
            this.miniButton.UseVisualStyleBackColor = true;
            this.miniButton.Click += new System.EventHandler(this.ImageButtonHandler);
            // 
            // warsawButton
            // 
            this.warsawButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("warsawButton.BackgroundImage")));
            this.warsawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.warsawButton.Location = new System.Drawing.Point(3, 373);
            this.warsawButton.Name = "warsawButton";
            this.warsawButton.Size = new System.Drawing.Size(217, 179);
            this.warsawButton.TabIndex = 4;
            this.warsawButton.UseVisualStyleBackColor = true;
            this.warsawButton.Click += new System.EventHandler(this.ImageButtonHandler);
            // 
            // fireworksButton
            // 
            this.fireworksButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fireworksButton.BackgroundImage")));
            this.fireworksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fireworksButton.Location = new System.Drawing.Point(226, 373);
            this.fireworksButton.Name = "fireworksButton";
            this.fireworksButton.Size = new System.Drawing.Size(217, 179);
            this.fireworksButton.TabIndex = 5;
            this.fireworksButton.Text = "button8";
            this.fireworksButton.UseVisualStyleBackColor = true;
            this.fireworksButton.Click += new System.EventHandler(this.ImageButtonHandler);
            // 
            // ColorReducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 994);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1382, 1041);
            this.MinimumSize = new System.Drawing.Size(1382, 1041);
            this.Name = "ColorReducer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Reducer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clusterColorsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmeansEpsilonTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kmeansPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uncertaintyPictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popularityPictureBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reductionButton;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label popularityLabel;
        private System.Windows.Forms.ProgressBar popularityProgressBar;
        private System.Windows.Forms.PictureBox popularityPictureBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button vacationButton;
        private System.Windows.Forms.Button mountainButton;
        private System.Windows.Forms.Button forestButton;
        private System.Windows.Forms.Button miniButton;
        private System.Windows.Forms.Button warsawButton;
        private System.Windows.Forms.Button fireworksButton;
        private System.Windows.Forms.RadioButton floydSteinbergRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton stuckyRadioButton;
        private System.Windows.Forms.RadioButton burkesRadioButton;
    }
}


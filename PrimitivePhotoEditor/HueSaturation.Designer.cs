namespace PrimitivePhotoEditor
{
    partial class HueSaturation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            this.trackBarSaturation = new System.Windows.Forms.TrackBar();
            this.lblHue = new System.Windows.Forms.Label();
            this.lblSaturation = new System.Windows.Forms.Label();
            this.lblHueValue = new System.Windows.Forms.Label();
            this.lblSaturationValue = new System.Windows.Forms.Label();
            this.cbPreview = new System.Windows.Forms.CheckBox();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.lblBrightnessValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarHue
            // 
            this.trackBarHue.Location = new System.Drawing.Point(12, 29);
            this.trackBarHue.Maximum = 360;
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(320, 45);
            this.trackBarHue.TabIndex = 0;
            this.trackBarHue.Value = 180;
            this.trackBarHue.ValueChanged += new System.EventHandler(this.trackBarHue_ValueChanged);
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.Location = new System.Drawing.Point(13, 93);
            this.trackBarSaturation.Maximum = 200;
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(319, 45);
            this.trackBarSaturation.TabIndex = 1;
            this.trackBarSaturation.Value = 100;
            // 
            // lblHue
            // 
            this.lblHue.AutoSize = true;
            this.lblHue.Location = new System.Drawing.Point(13, 13);
            this.lblHue.Name = "lblHue";
            this.lblHue.Size = new System.Drawing.Size(30, 13);
            this.lblHue.TabIndex = 2;
            this.lblHue.Text = "Hue:";
            // 
            // lblSaturation
            // 
            this.lblSaturation.AutoSize = true;
            this.lblSaturation.Location = new System.Drawing.Point(13, 77);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(58, 13);
            this.lblSaturation.TabIndex = 3;
            this.lblSaturation.Text = "Saturation:";
            // 
            // lblHueValue
            // 
            this.lblHueValue.AutoSize = true;
            this.lblHueValue.Location = new System.Drawing.Point(303, 13);
            this.lblHueValue.Name = "lblHueValue";
            this.lblHueValue.Size = new System.Drawing.Size(13, 13);
            this.lblHueValue.TabIndex = 4;
            this.lblHueValue.Text = "0";
            this.lblHueValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaturationValue
            // 
            this.lblSaturationValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaturationValue.AutoSize = true;
            this.lblSaturationValue.Location = new System.Drawing.Point(303, 68);
            this.lblSaturationValue.Name = "lblSaturationValue";
            this.lblSaturationValue.Size = new System.Drawing.Size(13, 13);
            this.lblSaturationValue.TabIndex = 5;
            this.lblSaturationValue.Text = "0";
            this.lblSaturationValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPreview
            // 
            this.cbPreview.AutoSize = true;
            this.cbPreview.Location = new System.Drawing.Point(16, 209);
            this.cbPreview.Name = "cbPreview";
            this.cbPreview.Size = new System.Drawing.Size(300, 17);
            this.cbPreview.TabIndex = 6;
            this.cbPreview.Text = "Show preview (may temporarily decrease image resolution)";
            this.cbPreview.UseVisualStyleBackColor = true;
            this.cbPreview.CheckedChanged += new System.EventHandler(this.cbPreview_CheckedChanged);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(12, 142);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(56, 13);
            this.lblBrightness.TabIndex = 8;
            this.lblBrightness.Text = "Brightness";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(12, 158);
            this.trackBarBrightness.Maximum = 200;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(319, 45);
            this.trackBarBrightness.TabIndex = 7;
            this.trackBarBrightness.Value = 100;
            this.trackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrightnessValue.AutoSize = true;
            this.lblBrightnessValue.Location = new System.Drawing.Point(303, 142);
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.Size = new System.Drawing.Size(13, 13);
            this.lblBrightnessValue.TabIndex = 9;
            this.lblBrightnessValue.Text = "0";
            this.lblBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HueSaturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 239);
            this.Controls.Add(this.lblBrightnessValue);
            this.Controls.Add(this.lblBrightness);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.cbPreview);
            this.Controls.Add(this.lblSaturationValue);
            this.Controls.Add(this.lblHueValue);
            this.Controls.Add(this.lblSaturation);
            this.Controls.Add(this.lblHue);
            this.Controls.Add(this.trackBarSaturation);
            this.Controls.Add(this.trackBarHue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HueSaturation";
            this.Text = "HueSaturation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HueSaturation_FormClosing);
            this.Load += new System.EventHandler(this.HueSaturation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.Label lblHue;
        private System.Windows.Forms.Label lblSaturation;
        private System.Windows.Forms.Label lblHueValue;
        private System.Windows.Forms.Label lblSaturationValue;
        private System.Windows.Forms.CheckBox cbPreview;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label lblBrightnessValue;
    }
}
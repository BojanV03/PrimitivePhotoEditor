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
            this.trackBarHue.Location = new System.Drawing.Point(16, 36);
            this.trackBarHue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarHue.Maximum = 360;
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(427, 56);
            this.trackBarHue.TabIndex = 0;
            this.trackBarHue.Value = 180;
            this.trackBarHue.ValueChanged += new System.EventHandler(this.trackBarHue_ValueChanged);
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.Location = new System.Drawing.Point(17, 114);
            this.trackBarSaturation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarSaturation.Maximum = 200;
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(425, 56);
            this.trackBarSaturation.TabIndex = 1;
            this.trackBarSaturation.Value = 100;
            this.trackBarSaturation.ValueChanged += new System.EventHandler(this.trackBarSaturation_ValueChanged);
            // 
            // lblHue
            // 
            this.lblHue.AutoSize = true;
            this.lblHue.Location = new System.Drawing.Point(17, 16);
            this.lblHue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHue.Name = "lblHue";
            this.lblHue.Size = new System.Drawing.Size(38, 17);
            this.lblHue.TabIndex = 2;
            this.lblHue.Text = "Hue:";
            // 
            // lblSaturation
            // 
            this.lblSaturation.AutoSize = true;
            this.lblSaturation.Location = new System.Drawing.Point(17, 95);
            this.lblSaturation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(77, 17);
            this.lblSaturation.TabIndex = 3;
            this.lblSaturation.Text = "Saturation:";
            // 
            // lblHueValue
            // 
            this.lblHueValue.AutoSize = true;
            this.lblHueValue.Location = new System.Drawing.Point(404, 16);
            this.lblHueValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHueValue.Name = "lblHueValue";
            this.lblHueValue.Size = new System.Drawing.Size(16, 17);
            this.lblHueValue.TabIndex = 4;
            this.lblHueValue.Text = "0";
            this.lblHueValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaturationValue
            // 
            this.lblSaturationValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaturationValue.AutoSize = true;
            this.lblSaturationValue.Location = new System.Drawing.Point(404, 84);
            this.lblSaturationValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaturationValue.Name = "lblSaturationValue";
            this.lblSaturationValue.Size = new System.Drawing.Size(16, 17);
            this.lblSaturationValue.TabIndex = 5;
            this.lblSaturationValue.Text = "0";
            this.lblSaturationValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPreview
            // 
            this.cbPreview.AutoSize = true;
            this.cbPreview.Location = new System.Drawing.Point(21, 257);
            this.cbPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPreview.Name = "cbPreview";
            this.cbPreview.Size = new System.Drawing.Size(401, 21);
            this.cbPreview.TabIndex = 6;
            this.cbPreview.Text = "Show preview (may temporarily decrease image resolution)";
            this.cbPreview.UseVisualStyleBackColor = true;
            this.cbPreview.CheckedChanged += new System.EventHandler(this.cbPreview_CheckedChanged);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(16, 175);
            this.lblBrightness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(75, 17);
            this.lblBrightness.TabIndex = 8;
            this.lblBrightness.Text = "Brightness";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(16, 194);
            this.trackBarBrightness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarBrightness.Maximum = 200;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(425, 56);
            this.trackBarBrightness.TabIndex = 7;
            this.trackBarBrightness.Value = 100;
            this.trackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrightnessValue.AutoSize = true;
            this.lblBrightnessValue.Location = new System.Drawing.Point(404, 175);
            this.lblBrightnessValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.Size = new System.Drawing.Size(16, 17);
            this.lblBrightnessValue.TabIndex = 9;
            this.lblBrightnessValue.Text = "0";
            this.lblBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HueSaturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 294);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
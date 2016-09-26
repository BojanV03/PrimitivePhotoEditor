namespace PrimitivePhotoEditor
{
    partial class ColorPicker
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
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 105);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(252, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(141, 89);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(45, 13);
            this.lblPreview.TabIndex = 3;
            this.lblPreview.Text = "Preview";
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(93, 105);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(153, 23);
            this.pbPreview.TabIndex = 4;
            this.pbPreview.TabStop = false;
            // 
            // pbRed
            // 
            this.pbRed.Location = new System.Drawing.Point(13, 13);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(255, 20);
            this.pbRed.TabIndex = 5;
            this.pbRed.TabStop = false;
            this.pbRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRed_MouseClick);
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(274, 13);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(53, 20);
            this.tbRed.TabIndex = 6;
            this.tbRed.TextChanged += new System.EventHandler(this.tbRed_TextChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(274, 39);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(53, 20);
            this.tbGreen.TabIndex = 8;
            this.tbGreen.TextChanged += new System.EventHandler(this.tbGreen_TextChanged);
            // 
            // pbGreen
            // 
            this.pbGreen.Location = new System.Drawing.Point(13, 39);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(255, 20);
            this.pbGreen.TabIndex = 7;
            this.pbGreen.TabStop = false;
            this.pbGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbGreen_MouseClick);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(274, 65);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(53, 20);
            this.tbBlue.TabIndex = 10;
            this.tbBlue.TextChanged += new System.EventHandler(this.tbBlue_TextChanged);
            // 
            // pbBlue
            // 
            this.pbBlue.Location = new System.Drawing.Point(13, 65);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(255, 20);
            this.pbBlue.TabIndex = 9;
            this.pbBlue.TabStop = false;
            this.pbBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbBlue_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 140);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.pbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.pbRed);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pbPreview);
            this.Name = "ColorPicker";
            this.Text = "ColorPicker";
            this.Load += new System.EventHandler(this.ColorPicker_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.Timer timer1;
    }
}
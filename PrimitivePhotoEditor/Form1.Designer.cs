namespace PrimitivePhotoEditor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateOriginalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCurrentWorkingImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.importImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.fixRotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelSwapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAndGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAndBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gAndBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reimportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.reimportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.rotationToolStripMenuItem,
            this.channelSwapToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cWToolStripMenuItem,
            this.cCWToolStripMenuItem,
            this.toolStripMenuItem2,
            this.customToolStripMenuItem,
            this.toolStripSeparator1,
            this.xAxisToolStripMenuItem,
            this.yAxisToolStripMenuItem,
            this.bothToolStripMenuItem});
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.rotationToolStripMenuItem.Text = "Rotation/Flip";
            // 
            // cWToolStripMenuItem
            // 
            this.cWToolStripMenuItem.Name = "cWToolStripMenuItem";
            this.cWToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cWToolStripMenuItem.Text = "90 CW";
            this.cWToolStripMenuItem.Click += new System.EventHandler(this.cWToolStripMenuItem_Click);
            // 
            // cCWToolStripMenuItem
            // 
            this.cCWToolStripMenuItem.Name = "cCWToolStripMenuItem";
            this.cCWToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cCWToolStripMenuItem.Text = "90 CCW";
            this.cCWToolStripMenuItem.Click += new System.EventHandler(this.cCWToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "180";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateOriginalImageToolStripMenuItem,
            this.rotateCurrentWorkingImageToolStripMenuItem,
            this.fixRotToolStripMenuItem});
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // rotateOriginalImageToolStripMenuItem
            // 
            this.rotateOriginalImageToolStripMenuItem.Name = "rotateOriginalImageToolStripMenuItem";
            this.rotateOriginalImageToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.rotateOriginalImageToolStripMenuItem.Text = "Rotate Original Image";
            this.rotateOriginalImageToolStripMenuItem.Click += new System.EventHandler(this.rotateOriginalImageToolStripMenuItem_Click);
            // 
            // rotateCurrentWorkingImageToolStripMenuItem
            // 
            this.rotateCurrentWorkingImageToolStripMenuItem.Name = "rotateCurrentWorkingImageToolStripMenuItem";
            this.rotateCurrentWorkingImageToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.rotateCurrentWorkingImageToolStripMenuItem.Text = "Rotate Current Working image";
            this.rotateCurrentWorkingImageToolStripMenuItem.Click += new System.EventHandler(this.rotateCurrentWorkingImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // xAxisToolStripMenuItem
            // 
            this.xAxisToolStripMenuItem.Name = "xAxisToolStripMenuItem";
            this.xAxisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xAxisToolStripMenuItem.Text = "X-Axis";
            this.xAxisToolStripMenuItem.Click += new System.EventHandler(this.xAxisToolStripMenuItem_Click);
            // 
            // yAxisToolStripMenuItem
            // 
            this.yAxisToolStripMenuItem.Name = "yAxisToolStripMenuItem";
            this.yAxisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yAxisToolStripMenuItem.Text = "Y-Axis";
            this.yAxisToolStripMenuItem.Click += new System.EventHandler(this.yAxisToolStripMenuItem_Click);
            // 
            // bothToolStripMenuItem
            // 
            this.bothToolStripMenuItem.Name = "bothToolStripMenuItem";
            this.bothToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bothToolStripMenuItem.Text = "Both";
            this.bothToolStripMenuItem.Click += new System.EventHandler(this.bothToolStripMenuItem_Click);
            // 
            // pbMainImage
            // 
            this.pbMainImage.Location = new System.Drawing.Point(0, 27);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(620, 440);
            this.pbMainImage.TabIndex = 1;
            this.pbMainImage.TabStop = false;
            // 
            // importImageDialog
            // 
            this.importImageDialog.Filter = "ImageFiles(*.jpg, *.bmp, *.png)|*.jpg;*.png;*.bmp";
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.Filter = "BMP File (*.bmp)|*.bmp|JPEG File (*.jpeg, *.jpg)|*.jpeg;*.jpg|PNG File (*.png)|*." +
    "png";
            // 
            // fixRotToolStripMenuItem
            // 
            this.fixRotToolStripMenuItem.Name = "fixRotToolStripMenuItem";
            this.fixRotToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.fixRotToolStripMenuItem.Text = "Fix Rotation Gaps (Experimental)";
            this.fixRotToolStripMenuItem.Click += new System.EventHandler(this.fixRotToolStripMenuItem_Click);
            // 
            // channelSwapToolStripMenuItem
            // 
            this.channelSwapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rAndGToolStripMenuItem,
            this.rAndBToolStripMenuItem,
            this.gAndBToolStripMenuItem});
            this.channelSwapToolStripMenuItem.Name = "channelSwapToolStripMenuItem";
            this.channelSwapToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.channelSwapToolStripMenuItem.Text = "Channel Swap";
            // 
            // rAndGToolStripMenuItem
            // 
            this.rAndGToolStripMenuItem.Name = "rAndGToolStripMenuItem";
            this.rAndGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rAndGToolStripMenuItem.Text = "R and G";
            // 
            // rAndBToolStripMenuItem
            // 
            this.rAndBToolStripMenuItem.Name = "rAndBToolStripMenuItem";
            this.rAndBToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rAndBToolStripMenuItem.Text = "R and B";
            // 
            // gAndBToolStripMenuItem
            // 
            this.gAndBToolStripMenuItem.Name = "gAndBToolStripMenuItem";
            this.gAndBToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gAndBToolStripMenuItem.Text = "G and B";
            this.gAndBToolStripMenuItem.Click += new System.EventHandler(this.gAndBToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // reimportToolStripMenuItem
            // 
            this.reimportToolStripMenuItem.Enabled = false;
            this.reimportToolStripMenuItem.Name = "reimportToolStripMenuItem";
            this.reimportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reimportToolStripMenuItem.Text = "Reimport";
            this.reimportToolStripMenuItem.Click += new System.EventHandler(this.reimportToolStripMenuItem_Click);
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(12, 476);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(608, 23);
            this.progressBarLoading.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 511);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.pbMainImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.OpenFileDialog importImageDialog;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xAxisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAxisToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateOriginalImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCurrentWorkingImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixRotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelSwapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAndGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAndBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gAndBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reimportToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarLoading;
    }
}


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
            this.reimportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateOriginalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCurrentWorkingImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixRotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelSwapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAndGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAndBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gAndBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monochromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hueSaturationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCanvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.customToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitwiseOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNDTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arithmeticOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplyTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substractTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trigonometricOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sineTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosineTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tangensTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.siniSinjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosiCosjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tANTANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.sinhiSinjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhiCosjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.importImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.analyzePicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.generateToolStripMenuItem});
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
            this.importToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // reimportToolStripMenuItem
            // 
            this.reimportToolStripMenuItem.Enabled = false;
            this.reimportToolStripMenuItem.Name = "reimportToolStripMenuItem";
            this.reimportToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.reimportToolStripMenuItem.Text = "Reimport";
            this.reimportToolStripMenuItem.Click += new System.EventHandler(this.reimportToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator2,
            this.rotationToolStripMenuItem,
            this.channelSwapToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.monochromeToolStripMenuItem,
            this.hueSaturationToolStripMenuItem,
            this.analyzePicToolStripMenuItem});
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
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
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
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.rotationToolStripMenuItem.Text = "Rotation/Flip";
            // 
            // cWToolStripMenuItem
            // 
            this.cWToolStripMenuItem.Name = "cWToolStripMenuItem";
            this.cWToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.cWToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cWToolStripMenuItem.Text = "90 CW";
            this.cWToolStripMenuItem.Click += new System.EventHandler(this.cWToolStripMenuItem_Click);
            // 
            // cCWToolStripMenuItem
            // 
            this.cCWToolStripMenuItem.Name = "cCWToolStripMenuItem";
            this.cCWToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.cCWToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cCWToolStripMenuItem.Text = "90 CCW";
            this.cCWToolStripMenuItem.Click += new System.EventHandler(this.cCWToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
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
            this.customToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // rotateOriginalImageToolStripMenuItem
            // 
            this.rotateOriginalImageToolStripMenuItem.Enabled = false;
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
            // fixRotToolStripMenuItem
            // 
            this.fixRotToolStripMenuItem.Name = "fixRotToolStripMenuItem";
            this.fixRotToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.fixRotToolStripMenuItem.Text = "Fix Rotation Gaps (Experimental)";
            this.fixRotToolStripMenuItem.Click += new System.EventHandler(this.fixRotToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // xAxisToolStripMenuItem
            // 
            this.xAxisToolStripMenuItem.Name = "xAxisToolStripMenuItem";
            this.xAxisToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.xAxisToolStripMenuItem.Text = "X-Axis";
            this.xAxisToolStripMenuItem.Click += new System.EventHandler(this.xAxisToolStripMenuItem_Click);
            // 
            // yAxisToolStripMenuItem
            // 
            this.yAxisToolStripMenuItem.Name = "yAxisToolStripMenuItem";
            this.yAxisToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.yAxisToolStripMenuItem.Text = "Y-Axis";
            this.yAxisToolStripMenuItem.Click += new System.EventHandler(this.yAxisToolStripMenuItem_Click);
            // 
            // bothToolStripMenuItem
            // 
            this.bothToolStripMenuItem.Name = "bothToolStripMenuItem";
            this.bothToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.bothToolStripMenuItem.Text = "Both";
            this.bothToolStripMenuItem.Click += new System.EventHandler(this.bothToolStripMenuItem_Click);
            // 
            // channelSwapToolStripMenuItem
            // 
            this.channelSwapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rAndGToolStripMenuItem,
            this.rAndBToolStripMenuItem,
            this.gAndBToolStripMenuItem});
            this.channelSwapToolStripMenuItem.Name = "channelSwapToolStripMenuItem";
            this.channelSwapToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.channelSwapToolStripMenuItem.Text = "Channel Swap";
            // 
            // rAndGToolStripMenuItem
            // 
            this.rAndGToolStripMenuItem.Name = "rAndGToolStripMenuItem";
            this.rAndGToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.rAndGToolStripMenuItem.Text = "R and G";
            this.rAndGToolStripMenuItem.Click += new System.EventHandler(this.rAndGToolStripMenuItem_Click);
            // 
            // rAndBToolStripMenuItem
            // 
            this.rAndBToolStripMenuItem.Name = "rAndBToolStripMenuItem";
            this.rAndBToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.rAndBToolStripMenuItem.Text = "R and B";
            this.rAndBToolStripMenuItem.Click += new System.EventHandler(this.rAndBToolStripMenuItem_Click);
            // 
            // gAndBToolStripMenuItem
            // 
            this.gAndBToolStripMenuItem.Name = "gAndBToolStripMenuItem";
            this.gAndBToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gAndBToolStripMenuItem.Text = "G and B";
            this.gAndBToolStripMenuItem.Click += new System.EventHandler(this.gAndBToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.invertToolStripMenuItem.Text = "Invert Colors";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // monochromeToolStripMenuItem
            // 
            this.monochromeToolStripMenuItem.Name = "monochromeToolStripMenuItem";
            this.monochromeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.monochromeToolStripMenuItem.Text = "Desaturate";
            this.monochromeToolStripMenuItem.Click += new System.EventHandler(this.monochromeToolStripMenuItem_Click);
            // 
            // hueSaturationToolStripMenuItem
            // 
            this.hueSaturationToolStripMenuItem.Name = "hueSaturationToolStripMenuItem";
            this.hueSaturationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.hueSaturationToolStripMenuItem.Text = "Hue/Saturation";
            this.hueSaturationToolStripMenuItem.Click += new System.EventHandler(this.hueSaturationToolStripMenuItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCanvasToolStripMenuItem,
            this.solidColorToolStripMenuItem,
            this.pixelOperationsToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // createCanvasToolStripMenuItem
            // 
            this.createCanvasToolStripMenuItem.Name = "createCanvasToolStripMenuItem";
            this.createCanvasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.createCanvasToolStripMenuItem.Text = "Create Canvas";
            this.createCanvasToolStripMenuItem.Click += new System.EventHandler(this.createCanvasToolStripMenuItem_Click);
            // 
            // solidColorToolStripMenuItem
            // 
            this.solidColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.toolStripSeparator5,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.toolStripSeparator3,
            this.cyanToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.toolStripSeparator4,
            this.customToolStripMenuItem1});
            this.solidColorToolStripMenuItem.Enabled = false;
            this.solidColorToolStripMenuItem.Name = "solidColorToolStripMenuItem";
            this.solidColorToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.solidColorToolStripMenuItem.Text = "Solid Color";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(113, 6);
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cyanToolStripMenuItem.Text = "Cyan";
            this.cyanToolStripMenuItem.Click += new System.EventHandler(this.cyanToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(113, 6);
            // 
            // customToolStripMenuItem1
            // 
            this.customToolStripMenuItem1.Name = "customToolStripMenuItem1";
            this.customToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.customToolStripMenuItem1.Text = "Custom";
            this.customToolStripMenuItem1.Click += new System.EventHandler(this.customToolStripMenuItem1_Click);
            // 
            // pixelOperationsToolStripMenuItem
            // 
            this.pixelOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitwiseOperationsToolStripMenuItem,
            this.arithmeticOperationsToolStripMenuItem,
            this.trigonometricOperationsToolStripMenuItem});
            this.pixelOperationsToolStripMenuItem.Enabled = false;
            this.pixelOperationsToolStripMenuItem.Name = "pixelOperationsToolStripMenuItem";
            this.pixelOperationsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pixelOperationsToolStripMenuItem.Text = "Pixel Operations";
            // 
            // bitwiseOperationsToolStripMenuItem
            // 
            this.bitwiseOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNDTextureToolStripMenuItem,
            this.oRTextureToolStripMenuItem,
            this.xORTextureToolStripMenuItem});
            this.bitwiseOperationsToolStripMenuItem.Name = "bitwiseOperationsToolStripMenuItem";
            this.bitwiseOperationsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.bitwiseOperationsToolStripMenuItem.Text = "Bitwise Operations";
            // 
            // aNDTextureToolStripMenuItem
            // 
            this.aNDTextureToolStripMenuItem.Name = "aNDTextureToolStripMenuItem";
            this.aNDTextureToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aNDTextureToolStripMenuItem.Text = "AND Texture";
            this.aNDTextureToolStripMenuItem.Click += new System.EventHandler(this.aNDTextureToolStripMenuItem_Click);
            // 
            // oRTextureToolStripMenuItem
            // 
            this.oRTextureToolStripMenuItem.Name = "oRTextureToolStripMenuItem";
            this.oRTextureToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.oRTextureToolStripMenuItem.Text = "OR Texture";
            this.oRTextureToolStripMenuItem.Click += new System.EventHandler(this.oRTextureToolStripMenuItem_Click);
            // 
            // xORTextureToolStripMenuItem
            // 
            this.xORTextureToolStripMenuItem.Name = "xORTextureToolStripMenuItem";
            this.xORTextureToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.xORTextureToolStripMenuItem.Text = "XOR Texture";
            this.xORTextureToolStripMenuItem.Click += new System.EventHandler(this.xORTextureToolStripMenuItem_Click);
            // 
            // arithmeticOperationsToolStripMenuItem
            // 
            this.arithmeticOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.multiplyTextureToolStripMenuItem,
            this.substractTextureToolStripMenuItem});
            this.arithmeticOperationsToolStripMenuItem.Name = "arithmeticOperationsToolStripMenuItem";
            this.arithmeticOperationsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.arithmeticOperationsToolStripMenuItem.Text = "Arithmetic Operations";
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aDDToolStripMenuItem.Text = "Add Texture";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // multiplyTextureToolStripMenuItem
            // 
            this.multiplyTextureToolStripMenuItem.Name = "multiplyTextureToolStripMenuItem";
            this.multiplyTextureToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.multiplyTextureToolStripMenuItem.Text = "Multiply Texture";
            this.multiplyTextureToolStripMenuItem.Click += new System.EventHandler(this.multiplyTextureToolStripMenuItem_Click);
            // 
            // substractTextureToolStripMenuItem
            // 
            this.substractTextureToolStripMenuItem.Name = "substractTextureToolStripMenuItem";
            this.substractTextureToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.substractTextureToolStripMenuItem.Text = "Substract Texture";
            this.substractTextureToolStripMenuItem.Click += new System.EventHandler(this.substractTextureToolStripMenuItem_Click);
            // 
            // trigonometricOperationsToolStripMenuItem
            // 
            this.trigonometricOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sineTextureToolStripMenuItem,
            this.cosineTextureToolStripMenuItem,
            this.tangensTextureToolStripMenuItem,
            this.toolStripSeparator6,
            this.siniSinjToolStripMenuItem,
            this.cosiCosjToolStripMenuItem,
            this.tANTANToolStripMenuItem,
            this.toolStripSeparator7,
            this.sinhiSinjToolStripMenuItem,
            this.sinhiCosjToolStripMenuItem});
            this.trigonometricOperationsToolStripMenuItem.Name = "trigonometricOperationsToolStripMenuItem";
            this.trigonometricOperationsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.trigonometricOperationsToolStripMenuItem.Text = "Trigonometric Operations";
            // 
            // sineTextureToolStripMenuItem
            // 
            this.sineTextureToolStripMenuItem.Name = "sineTextureToolStripMenuItem";
            this.sineTextureToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sineTextureToolStripMenuItem.Text = "Sine Texture";
            this.sineTextureToolStripMenuItem.Click += new System.EventHandler(this.sineTextureToolStripMenuItem_Click);
            // 
            // cosineTextureToolStripMenuItem
            // 
            this.cosineTextureToolStripMenuItem.Name = "cosineTextureToolStripMenuItem";
            this.cosineTextureToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cosineTextureToolStripMenuItem.Text = "Cosine Texture";
            this.cosineTextureToolStripMenuItem.Click += new System.EventHandler(this.cosineTextureToolStripMenuItem_Click);
            // 
            // tangensTextureToolStripMenuItem
            // 
            this.tangensTextureToolStripMenuItem.Name = "tangensTextureToolStripMenuItem";
            this.tangensTextureToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tangensTextureToolStripMenuItem.Text = "Tangent Texture";
            this.tangensTextureToolStripMenuItem.Click += new System.EventHandler(this.tangensTextureToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(155, 6);
            // 
            // siniSinjToolStripMenuItem
            // 
            this.siniSinjToolStripMenuItem.Name = "siniSinjToolStripMenuItem";
            this.siniSinjToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.siniSinjToolStripMenuItem.Text = "Sin(i)*Sin(j)";
            this.siniSinjToolStripMenuItem.Click += new System.EventHandler(this.siniSinjToolStripMenuItem_Click);
            // 
            // cosiCosjToolStripMenuItem
            // 
            this.cosiCosjToolStripMenuItem.Name = "cosiCosjToolStripMenuItem";
            this.cosiCosjToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cosiCosjToolStripMenuItem.Text = "Cos(i)*Cos(j)";
            this.cosiCosjToolStripMenuItem.Click += new System.EventHandler(this.cosiCosjToolStripMenuItem_Click);
            // 
            // tANTANToolStripMenuItem
            // 
            this.tANTANToolStripMenuItem.Name = "tANTANToolStripMenuItem";
            this.tANTANToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tANTANToolStripMenuItem.Text = "Tan(i)*Tan(j)";
            this.tANTANToolStripMenuItem.Click += new System.EventHandler(this.tANTANToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(155, 6);
            // 
            // sinhiSinjToolStripMenuItem
            // 
            this.sinhiSinjToolStripMenuItem.Name = "sinhiSinjToolStripMenuItem";
            this.sinhiSinjToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sinhiSinjToolStripMenuItem.Text = "Sinh(i)*Sin(j)";
            this.sinhiSinjToolStripMenuItem.Click += new System.EventHandler(this.sinhiSinjToolStripMenuItem_Click);
            // 
            // sinhiCosjToolStripMenuItem
            // 
            this.sinhiCosjToolStripMenuItem.Name = "sinhiCosjToolStripMenuItem";
            this.sinhiCosjToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sinhiCosjToolStripMenuItem.Text = "Sinh(i)*Cos(j)";
            this.sinhiCosjToolStripMenuItem.Click += new System.EventHandler(this.sinhiCosjToolStripMenuItem_Click);
            // 
            // pbMainImage
            // 
            this.pbMainImage.Location = new System.Drawing.Point(0, 27);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(824, 440);
            this.pbMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(12, 476);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(812, 23);
            this.progressBarLoading.TabIndex = 2;
            // 
            // analyzePicToolStripMenuItem
            // 
            this.analyzePicToolStripMenuItem.Name = "analyzePicToolStripMenuItem";
            this.analyzePicToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.analyzePicToolStripMenuItem.Text = "Analyze Pic";
            this.analyzePicToolStripMenuItem.Click += new System.EventHandler(this.analyzePicToolStripMenuItem_Click);
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
            this.Text = "Primitive Photo Editor";
            this.Resize += new System.EventHandler(this.Form1_Resize);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createCanvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem pixelOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitwiseOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNDTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xORTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arithmeticOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplyTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substractTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trigonometricOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sineTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosineTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siniSinjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosiCosjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhiSinjToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem sinhiCosjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tangensTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tANTANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monochromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hueSaturationToolStripMenuItem;
        public System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.ToolStripMenuItem analyzePicToolStripMenuItem;
    }
}


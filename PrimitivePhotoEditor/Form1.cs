using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
namespace PrimitivePhotoEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap originalImage, workingImage;
        Bitmap undoImage = null;
        Bitmap redoImage = null;

        pixel[,] workingImagePixels;

        struct pixel
        {
            public int R, G, B;
        }

        public void createUndo(Bitmap b)
        {
            undoToolStripMenuItem.Enabled = true;
            if (undoImage != null)
                undoImage.Dispose();
            undoImage = new Bitmap(b);
        }


        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoImage != null)
                undoImage.Dispose();
            undoImage = new Bitmap(workingImage);
            workingImage.Dispose();
            workingImage = new Bitmap(redoImage);
            pbMainImage.Image = redoImage;
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redoImage != null)
                redoImage.Dispose();
            redoImage = new Bitmap(workingImage);
            workingImage.Dispose();
            workingImage = new Bitmap(undoImage);
            pbMainImage.Image = undoImage;
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(importImageDialog.ShowDialog() == DialogResult.OK)
                {
                    if (originalImage != null)
                        originalImage.Dispose();
                    originalImage = new Bitmap(importImageDialog.FileName);
                    if (workingImage != null)
                        workingImage.Dispose();
                    workingImage = new Bitmap(originalImage);

                    pbMainImage.Image = workingImage;
                    editToolStripMenuItem.Enabled = true;
                    exportToolStripMenuItem.Enabled = true;
                    rotateOriginalImageToolStripMenuItem.Enabled = true;
                    reimportToolStripMenuItem.Enabled = true;
                    solidColorToolStripMenuItem.Enabled = true;

                    workingImagePixels = new pixel[workingImage.Width, workingImage.Height];

                    progressBarLoading.Maximum = workingImage.Width * workingImage.Height;

                    int width1 = workingImage.Width;
                    int height1 = workingImage.Height;

                    BitmapData data = workingImage.LockBits(new Rectangle(0, 0, width1, height1), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    unsafe
                    {
                        byte* ptr = (byte*)data.Scan0;
                        for (int i = 0; i < width1; i++)
                        {
                            for (int j = 0; j < height1; j++)
                            {
                                workingImagePixels[i, j].B = ptr[j*3 + i * height1];
                                workingImagePixels[i, j].G = ptr[j * 3 + i * height1 + 1];
                                workingImagePixels[i, j].R = ptr[j * 3 + i * height1 + 2];

                            }
                            progressBarLoading.Value += height1;
                        }
                    }
                    workingImage.UnlockBits(data);
                    return;
                }
            }
            catch(Exception)
            {
                return;
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveImageDialog.ShowDialog() == DialogResult.OK)
                {
                    workingImage.Save(saveImageDialog.FileName);
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
//rotations
        private void cWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            workingImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbMainImage.Image = workingImage;
        }

        private void cCWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            workingImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbMainImage.Image = workingImage;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            workingImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbMainImage.Image = workingImage;
        }
//flips
        private void bothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            workingImage.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            pbMainImage.Image = workingImage;
        }

        private void xAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            workingImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pbMainImage.Image = workingImage;
        }

        private void yAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            workingImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pbMainImage.Image = workingImage;
        }
//Custom Rotation
        private void rotateCurrentWorkingImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customRotateImage(workingImage, 90 * Math.PI / 180);
        }

        private void rotateOriginalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customRotateImage(originalImage, 90*Math.PI/180);
        }

        private void customRotateImage(Bitmap b, double angle)
        {
            Bitmap tempImage = new Bitmap(b);
            createUndo(b);

            //optimization calculations
            double SineTheta = Math.Sin(angle);
            double CosineTheta = Math.Cos(angle);
            double halfWidth = tempImage.Width / 2;
            double halfHeight = tempImage.Height / 2;

            double width = b.Width * CosineTheta + b.Height * SineTheta;
            double height = b.Width * SineTheta + b.Height * CosineTheta;

            if (width * height > 15000000)
                MessageBox.Show("Your picture will have the resolution of " + ((int)width + 1) + "x" + ((int)height + 1) + " pixels... This may cause some memory problems, be aware... or better yet decrease the resolution... Good luck");

            if (b != null)
                b.Dispose();
            b = new Bitmap((int)width + 1, (int)height + 1);

            double heightTranslate2 = (b.Height - tempImage.Height) / 2;
            double widthTranslate2 = (b.Width - tempImage.Width) / 2;



            for (int i = 0; i < tempImage.Width; i++)
            {
                for (int j = 0; j < tempImage.Height; j++)
                {
                    int xPixel, yPixel;

                    double origXPixel = i - halfWidth;                                  //Translating the origin
                    double origYPixel = j - halfHeight;

                    xPixel = (int)(origXPixel * CosineTheta + origYPixel * SineTheta);  //rotation matrix multiplication
                    yPixel = (int)(origXPixel * -SineTheta + origYPixel * CosineTheta);

                    xPixel += (int)(halfWidth + widthTranslate2);                       //Translating back
                    yPixel += (int)(halfHeight + heightTranslate2);

                    b.SetPixel(xPixel, yPixel, tempImage.GetPixel(i, j));
                }
            }

            workingImage.Dispose();
            tempImage.Dispose();
            workingImage = new Bitmap(b);
            b.Dispose();
            pbMainImage.Image = workingImage;
        }

        private void fixRotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            int rectHeight = workingImage.Height;
            int rectWidth = workingImage.Width;

            BitmapData data = workingImage.LockBits(new Rectangle(0, 0, rectWidth, rectHeight), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;

            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 1; i < rectHeight - 1; i++)
                {
                    for (int j = 1; j < rectWidth - 1; j++)
                    {
                        int R = ptr[i * stride + j * 3 + 2];
                        int G = ptr[i * stride + j * 3 + 1];
                        int B = ptr[i * stride + j * 3    ];

                        if (R == 255 && G == 255 && B == 255)
                        {
                            R = G = B = -255;
                            int brojac = -1;
                            for (int k = i - 1; k <= i + 1; k++)
                            {
                                for (int m = j - 1; m <= j + 1; m++)
                                {
                                    R += ptr[k * stride + m * 3 + 2];
                                    G += ptr[k * stride + m * 3 + 1];
                                    B += ptr[k * stride + m * 3    ];
                                    brojac++;
                                }
                            }
                            

                            R /= brojac;
                            G /= brojac;
                            B /= brojac;

                            ptr[i * stride + j * 3 + 2] = (byte) R;//NOT WORKING FOR SOME REASON??
                            ptr[i * stride + j * 3 + 1] = (byte) G;
                            ptr[i * stride + j * 3 + 0] = (byte) B;
                        }
                    }
                }
            }

            MessageBox.Show("BLA");
            workingImage.UnlockBits(data);
            pbMainImage.Image = workingImage;
        }

        private void reimportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;

            workingImage = new Bitmap(originalImage);
            MessageBox.Show(workingImage.Width + " " + originalImage.Width);
            pbMainImage.Image = workingImage;
        }

        public void swapChannels(Bitmap bmp, int a, int b)  /** a and b are the channels that we are swapping, 0 = Blue, 1 = Green, 2 = Red**/
        {
            createUndo(bmp);

            progressBarLoading.Value = 0;

            int rectWidth = bmp.Width;
            int rectHeight = bmp.Height;

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, rectWidth, rectHeight), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < rectHeight; i++)
                {
                    for (int j = 0; j < rectWidth; j++)
                    {
                        byte pom = ptr[j * 3 + i * stride + a];
                        ptr[j * 3 + i * stride + a] = ptr[j * 3 + i * stride + b];
                        ptr[j * 3 + i * stride + b] = pom;
                    }
 //             progressBarLoading.Value += rectWidth;
                }
            }

            bmp.UnlockBits(data);
            pbMainImage.Image = bmp;

        }

        private void rAndGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            swapChannels(workingImage, 1, 2);
        }
        
        private void rAndBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            swapChannels(workingImage, 0, 2);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pbMainImage.Size = new Size(this.Size.Width - 28, this.Size.Height - 110);
            progressBarLoading.Size = new Size(this.Size.Width - 28, progressBarLoading.Size.Height);
            progressBarLoading.Location = new Point(progressBarLoading.Location.X, this.Size.Height - 74);
        }

        private void customToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorPicker cp = new ColorPicker();
            cp.ShowDialog();
            if(cp.DialogResult == DialogResult.OK)
            {
                for(int i = 0; i < workingImage.Height; i++)
                    for(int j = 0; j < workingImage.Width; j++)
                    {
                        workingImage.SetPixel(j, i, Color.FromArgb(cp.R, cp.G, cp.B));
                    }
            }
            pbMainImage.Image = workingImage;
        }

        private void createCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizePicker sp = new SizePicker();
            sp.ShowDialog();
            if(sp.DialogResult == DialogResult.OK)
            {
                if (workingImage != null)
                    createUndo(workingImage);

                workingImage = new Bitmap(sp.Width, sp.Height);
                pbMainImage.Image = workingImage;
                solidColorToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                exportToolStripMenuItem.Enabled = true;
            }
        }

        private void gAndBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            swapChannels(workingImage, 0, 1);
        }
    }
}

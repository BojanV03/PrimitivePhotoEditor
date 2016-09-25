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
        Bitmap undoImage;
        Bitmap redoImage;

        pixel[,] workingImagePixels;

        struct pixel
        {
            public int R, G, B;
        }

        public void createUndo(Bitmap b)
        {
            undoToolStripMenuItem.Enabled = true;
            undoImage = new Bitmap(b);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoImage = new Bitmap(workingImage);
            workingImage = new Bitmap(redoImage);
            pbMainImage.Image = redoImage;
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoImage = new Bitmap(workingImage);
            workingImage = new Bitmap(undoImage);
            pbMainImage.Image = undoImage;
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbMainImage.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                if(importImageDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(importImageDialog.FileName);
                    workingImage = new Bitmap(originalImage);
                    pbMainImage.Image = workingImage;
                    Thread.Sleep(1000);

                    editToolStripMenuItem.Enabled = true;
                    exportToolStripMenuItem.Enabled = true;
                    reimportToolStripMenuItem.Enabled = true;

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
            customRotateImage(workingImage, 33 * Math.PI / 180);
        }

        private void rotateOriginalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customRotateImage(originalImage, 33*Math.PI/180);
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

            b = new Bitmap((int)width + 1, (int)height + 1);

            double heightTranslate2 = (b.Height - tempImage.Height) / 2;
            double widthTranslate2 = (b.Width - tempImage.Width) / 2;
//          MessageBox.Show(workingImage.Width + "x" + workingImage.Height);

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

            workingImage = b;
            pbMainImage.Image = workingImage;
        }

        private void fixRotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < workingImage.Width-1; i++)
            {
                for(int j = 1; j < workingImage.Height-1; j++)
                {
                    int R = workingImage.GetPixel(i, j).R;
                    int G = workingImage.GetPixel(i, j).G;
                    int B = workingImage.GetPixel(i, j).B;
                    if (R == 255 && G == 255 && B == 255)
                    {
                        R = G = B = 0;
                        int brojac = 0;
                        for (int k = i-1; k < i+1; k++)
                        {
                            for(int m = j-1; m < j+1; j++)
                            {
                                R += workingImage.GetPixel(k, m).R;
                                G += workingImage.GetPixel(k, m).G;
                                B += workingImage.GetPixel(k, m).B;
                                brojac++;
                            }
                        }
                        MessageBox.Show(" " + brojac);

                        R /= brojac;
                        G /= brojac;
                        B /= brojac;
                        workingImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                    }
                }
            }
        }

        private void reimportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
            workingImage = new Bitmap(originalImage);
            pbMainImage.Image = workingImage;
        }

        private void gAndBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            progressBarLoading.Value = 0;

            int rectWidth = workingImage.Width;
            int rectHeight = workingImage.Height;

            BitmapData data = workingImage.LockBits(new Rectangle(0, 0, rectWidth, rectHeight), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < rectHeight; i++)
                {
                    for (int j = 0; j < rectWidth; j++)
                    {
                        byte pom = ptr[j * 3 + i * stride];
                        ptr[j * 3 + i * stride] = ptr[j * 3 + i * stride + 1];
                        ptr[j * 3 + i * stride + 1] = pom;
                    }
                    progressBarLoading.Value += rectWidth;
                }
            }

            workingImage.UnlockBits(data);
            pbMainImage.Image = workingImage;

        }



    }
}

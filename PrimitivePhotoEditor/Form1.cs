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

        Color mainDrawColor = Color.Black, secondaryDrawColor = Color.White;
        Bitmap originalImage;
        
        public Bitmap workingImage;
        Bitmap undoImage = null;
        Bitmap redoImage = null;
        private Boolean draw = false;
        private Boolean isMouseDown = false;

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

        private void enableEdit()
        {
            editToolStripMenuItem.Enabled = true;
            cWToolStripMenuItem.Enabled = true;
            cCWToolStripMenuItem.Enabled = true;
            rotate180ToolStripMenuItem2.Enabled = true;
            xAxisToolStripMenuItem.Enabled = true;
            yAxisToolStripMenuItem.Enabled = true;
            bothToolStripMenuItem.Enabled = true;
            rotateOriginalImageToolStripMenuItem.Enabled = true;
            rotateCurrentWorkingImageToolStripMenuItem.Enabled = true;
            fixRotToolStripMenuItem.Enabled = true;
            rAndBToolStripMenuItem.Enabled = true;
            rAndGToolStripMenuItem.Enabled = true;
            gAndBToolStripMenuItem.Enabled = true;
            invertToolStripMenuItem.Enabled = true;
            monochromeToolStripMenuItem.Enabled = true;
            hueSaturationToolStripMenuItem.Enabled = true;
            analyzePicToolStripMenuItem.Enabled = true;
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

                    enableEdit();
                    exportToolStripMenuItem.Enabled = true;
                    pixelOperationsToolStripMenuItem.Enabled = true;
                    reimportToolStripMenuItem.Enabled = true;
                    solidColorToolStripMenuItem.Enabled = true;

                    pbMainImage.Image = workingImage;
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

        private void rotate180ToolStripMenuItem2_Click(object sender, EventArgs e)
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

            if(workingImage != null)
            {
                workingImage.Dispose();
                workingImage = null;
            }
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
            pbMainImage.Size = new Size(this.Size.Width - 80, this.Size.Height - 110);
            progressBarLoading.Size = new Size(this.Size.Width - 28, progressBarLoading.Size.Height);
            progressBarLoading.Location = new Point(progressBarLoading.Location.X, this.Size.Height - 74);
        }

        public void solidColorFill(Bitmap image, Color c)
        {
            int width = image.Width;
            int height = image.Height;
            BitmapData data = image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < height; i++)
                    for (int j = 0; j < width; j++)
                    {
                        ptr[j * 3 + i * stride + 2] = c.R;
                        ptr[j * 3 + i * stride + 1] = c.G;
                        ptr[j * 3 + i * stride + 0] = c.B;
                    }
            }
            image.UnlockBits(data);
        }

        private void customToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorPicker cp = new ColorPicker();
            cp.ShowDialog();
            
            if(cp.DialogResult == DialogResult.OK)
            {
                createUndo(workingImage);

                solidColorFill(workingImage, Color.FromArgb(cp.R, cp.G, cp.B));
                pbMainImage.Image = workingImage;
            }
        }

        private void createCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizePicker sp = new SizePicker();
            sp.ShowDialog();
            if(sp.DialogResult == DialogResult.OK)
            {
                if (workingImage != null)
                    createUndo(workingImage);

                workingImage = new Bitmap(sp.chosenWidth, sp.chosenHeight);
                solidColorFill(workingImage, Color.Gray);
                pbMainImage.Image = workingImage;
                solidColorToolStripMenuItem.Enabled = true;
                pixelOperationsToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                exportToolStripMenuItem.Enabled = true;
            }
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            solidColorFill(workingImage, Color.Black);
            pbMainImage.Image = workingImage;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            solidColorFill(workingImage, Color.Gray);
            pbMainImage.Image = workingImage;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            solidColorFill(workingImage, Color.White);
            pbMainImage.Image = workingImage;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            solidColorFill(workingImage, Color.Red);
            pbMainImage.Image = workingImage;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            solidColorFill(workingImage, Color.Green);
            pbMainImage.Image = workingImage;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            solidColorFill(workingImage, Color.Blue);
            pbMainImage.Image = workingImage;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            solidColorFill(workingImage, Color.Cyan);
            pbMainImage.Image = workingImage;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            solidColorFill(workingImage, Color.Purple);
            pbMainImage.Image = workingImage;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            solidColorFill(workingImage, Color.Yellow);
            pbMainImage.Image = workingImage;
        }

        private void generateTexture(Bitmap image, String S)
        {
            createUndo(workingImage);

            int width = image.Width;
            int height = image.Height;
            BitmapData data = image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < height; i++)
                {
                    double sineI = Math.Sin(i * Math.PI / 180);
                    double sineHI = Math.Sinh(i * Math.PI / 180);
                    double cosineI = Math.Cos(i * Math.PI / 180);
                    double cosineHI = Math.Cosh(i * Math.PI / 180);
                    for (int j = 0; j < width; j++)
                    {
                        double sineJ = Math.Sin(j * Math.PI / 180);
                        double cosineJ = Math.Cos(j * Math.PI / 180);
                        int R = 0, G = 0, B = 0;
                        switch (S)
                        {
                            //boolean
                            case "OR": R = i | j; G = i | j; B = i | j; break;
                            case "AND": R = i & j; G = i & j; B = i & j; break;
                            case "XOR": R = i ^ j; G = i ^ j; B = i ^ j; break;
                            //arithmetic
                            case "ADD": R = i + j; G = i + j; B = i + j; break;
                            case "MUL": R = i * j; G = i * j; B = i * j; break;
                            case "SUB": R = i - j; G = i - j; B = i - j; break;
                            //trigonometric
                            case "SIN": R = (byte)(255 * Math.Sin((i + j) * Math.PI / 180)); G = (byte)(255 * Math.Sin((i + j) * Math.PI / 180)); B = (byte)(255 * Math.Sin((i + j) * Math.PI / 180)); break;
                            case "COS": R = (byte)(255 * Math.Cos((i + j) * Math.PI / 180)); G = (byte)(255 * Math.Cos((i + j) * Math.PI / 180)); B = (byte)(255 * Math.Cos((i + j) * Math.PI / 180)); break;
                            case "SINSIN": R = (byte)(255 * sineI * sineJ); G = (byte)(255 * sineI * sineJ); B = (byte)(255 * sineI * sineJ); break;
                            case "COSCOS": R = (byte)(255 * cosineI * cosineJ); G = (byte)(255 * cosineI * cosineJ); B = (byte)(255 * cosineI * cosineJ); break;
                            case "SINHSIN": R = (byte)(255 * sineHI * sineJ); G = (byte)(255 * sineHI * sineJ); B = (byte)(255 * sineHI * sineJ); break;
                            case "SINHCOS": R = (byte)(255 * sineHI * cosineJ); G = (byte)(255 * sineHI * cosineJ); B = (byte)(255 * sineHI * cosineJ); break;
                            case "TAN": int TanIJ = (byte)(255 * Math.Tan((i + j) * Math.PI / 180)); R = TanIJ; G = TanIJ; B = TanIJ;  break;
                            case "TANTAN":
                                int TanI = (byte)(255 * Math.Tan((i * Math.PI / 180)));
                                int TanJ = (byte)(255 * Math.Tan((j * Math.PI / 180)));
                                R = TanI ^ TanJ;
                                G = TanI ^ TanJ;
                                B = TanI ^ TanJ; break;
                            default: break;
                        }
                        R += 0;
                        G += 0;
                        B += 0;

                        R %= 256;
                        G %= 256;
                        B %= 256;
                        ptr[j * 3 + i * stride + 2] = (byte)R;
                        ptr[j * 3 + i * stride + 1] = (byte)G;
                        ptr[j * 3 + i * stride + 0] = (byte)B;
                    }
                }
            }
            image.UnlockBits(data);

            pbMainImage.Image = image;
        }

        private void aNDTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "AND");
        }

        private void oRTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "OR");
        }

        private void xORTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "XOR");
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "ADD");
        }

        private void multiplyTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "MUL");
        }

        private void substractTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "SUB");
        }

        private void sineTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "SIN");
        }

        private void cosineTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "COS");
        }

        private void cosiCosjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "COSCOS");
        }

        private void siniSinjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "SINSIN");
        }

        private void sinhiSinjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "SINHSIN");
        }

        private void sinhiCosjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "SINHCOS");
        }

        private void tangensTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "TAN");
        }

        private void tANTANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateTexture(workingImage, "TANTAN");
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            int width = workingImage.Width;
            int height = workingImage.Height;
            BitmapData data = workingImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        ptr[j * 3 + i * stride + 2] = (byte)(255 - ptr[j * 3 + i * stride + 2]);
                        ptr[j * 3 + i * stride + 1] = (byte)(255 - ptr[j * 3 + i * stride + 1]);
                        ptr[j * 3 + i * stride + 0] = (byte)(255 - ptr[j * 3 + i * stride + 0]);
                    }
                }
            }
            workingImage.UnlockBits(data);
            pbMainImage.Image = workingImage;
        }

        private void monochromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            int width = workingImage.Width;
            int height = workingImage.Height;
            BitmapData data = workingImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        int R = ptr[j * 3 + i * stride + 2];
                        int G = ptr[j * 3 + i * stride + 1];
                        int B = ptr[j * 3 + i * stride + 0];
                        byte median = (byte)((R+G+B)/3);
                        ptr[j * 3 + i * stride + 0] = median;
                        ptr[j * 3 + i * stride + 1] = median;
                        ptr[j * 3 + i * stride + 2] = median;
                    }
                }
            }
            workingImage.UnlockBits(data);
            pbMainImage.Image = workingImage;
        }

        private void hueSaturationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HueSaturation Q = new HueSaturation(this);
            Q.Show();
        }

        private void gAndBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            swapChannels(workingImage, 0, 1);
        }

        private void analyzePicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int width = workingImage.Width;
            int height = workingImage.Height;
            ulong numOfPixels = (ulong)width * (ulong)height;
            ulong R = 0, G = 0, B = 0;
            double hue = 0;
            double saturation = 0;
            double brightness = 0;
            BitmapData data = workingImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        int tmpRed = ptr[j * 3 + i * stride + 2];
                        int tmpGreen = ptr[j * 3 + i * stride + 1];
                        int tmpBlue = ptr[j * 3 + i * stride + 0];

                        R += (byte) tmpRed;
                        G += (byte)tmpGreen;
                        B += (byte)tmpBlue;

                        Color C = Color.FromArgb(tmpRed, tmpGreen, tmpBlue);
                        hue += C.GetHue();
                        saturation += C.GetSaturation();
                        brightness += C.GetBrightness();


           //             double lightness = (max + min) / 2;
            //            saturation = (max - min) / (1 - Math.Abs(2 * lightness - 1));
                    }
                }
            }

            workingImage.UnlockBits(data);
            MessageBox.Show("Resolution: " + workingImage.Width + "x" + workingImage.Height + 
                            "\nTotal number of pixels: " + numOfPixels + 
                            "\nSum of red pixels: " + R +
                            "\nSum of green pixels: " + G +
                            "\nSum of blue pixels: " + B +
                            "\nAverage color per pixel: (" + (R / numOfPixels) + ", " + (G/numOfPixels) + ", " + (B/numOfPixels) + ")\n" + 
                            "\nHue sum: " + hue +
                            "\nSaturation sum: " + saturation +
                            "\nBrightness sum: " + brightness +
                            "\nAverage HSB per pixel: (" + (hue / numOfPixels) + ", " + (saturation / numOfPixels) + ", " + (brightness / numOfPixels) + ")\n"
                            );
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            if(draw == false)
            {
                draw = true;
                btnPen.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                draw = false;
                btnPen.FlatStyle = FlatStyle.Standard;
            }
        }


        private Point calculateClickLocation(int clickX, int clickY)
        {
            Point result = new Point();
            double div;

            if ((double)workingImage.Width/(float)pbMainImage.Width > (float)workingImage.Height/(float)pbMainImage.Height)
            {
                div = (double)workingImage.Width / pbMainImage.Width;
                result.X = 0;
                result.Y = (int)(workingImage.Height / div);
                result.Y = pbMainImage.Height - result.Y;
                result.Y /= 2;
            }
            else
            {
                div = (double)workingImage.Height / pbMainImage.Height;
                result.Y = 0;
                result.X = (int)(workingImage.Width / div);
                result.X = pbMainImage.Width - result.X;
                result.X /= 2;
            }
            if (clickX < result.X || clickY < result.Y || clickX > result.X + (workingImage.Width / div) || clickY > result.Y + (workingImage.Height / div))
            {
                MessageBox.Show("I can't draw outside of the canvas you silly");
                result.X = -1;
                result.Y = -1;
                return result;
            }
            result.X = (int)((clickX - result.X) * div);
            result.Y = (int)((clickY - result.Y) * div);
            return result;
        }

        private Boolean drawCircle(Bitmap b, Point Center, int Radius, Color C)
        {
            int diameter = 2 * Radius;
            if(Center.X - Radius < 0 || Center.X + Radius >= b.Width ||
               Center.Y - Radius < 0 || Center.Y + Radius >= b.Height)
            {
                MessageBox.Show("drawCircle: Center/Radius mismatch");
            }
            Graphics g = Graphics.FromImage(workingImage);
            SolidBrush brush = new SolidBrush(C);

            g.FillEllipse(brush, new Rectangle(Center.X, Center.Y, Radius, Radius));
            g.Dispose();
            brush.Dispose();
            return true;
        }

        private void pbMainImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && draw == true)
            {
                Point click = calculateClickLocation(e.X, e.Y);
                int radius = Convert.ToInt32(tbRadius.Text);
                if (click.X - radius > 0 && click.X + radius < workingImage.Width && click.Y - radius >= 0 && click.Y + radius < workingImage.Height)
                {
                    drawCircle(workingImage, click, radius, mainDrawColor);
                }
                if(cbPreview.Checked)
                    pbMainImage.Image = workingImage;
            }
        }

        private void pbMainImage_MouseDown(object sender, MouseEventArgs e)
        {
            Point click = calculateClickLocation(e.X, e.Y);
            if (draw == true)
            {
                createUndo(workingImage);
                drawCircle(workingImage, click, Convert.ToInt32(tbRadius.Text), mainDrawColor);
                if (cbPreview.Checked)
                    pbMainImage.Image = workingImage;

                isMouseDown = true;
            }
            else
            {
                MessageBox.Show(workingImage.GetPixel(click.X, click.Y).ToString());
            }
        }

        private void pbMainImage_MouseLeave(object sender, EventArgs e)
        {
            isMouseDown = false;
        }

        private void pbMainImage_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            pbMainImage.Image = workingImage;
        }



        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizePicker sp = new SizePicker();

            sp.ShowDialog();
            if(sp.DialogResult == DialogResult.OK)
            {
                Bitmap tmp = new Bitmap(workingImage, sp.chosenWidth, sp.chosenHeight);
                workingImage.Dispose();
                workingImage = tmp;
            }
        }

        private int clamp(int n)
        {
            if (n > 255)
                return 255;
            else if (n < 0)
                return 0;
            return n;
        }

        private void multiplyPixel(Bitmap b, double Rmul, double Gmul, double Bmul)
        {
            int width = b.Width;
            int height = b.Height;
            BitmapData data = b.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        int R = ptr[j * 3 + i * stride + 2];
                        int G = ptr[j * 3 + i * stride + 1];
                        int B = ptr[j * 3 + i * stride + 0];

                        R = clamp((int)(R*Rmul));
                        G = clamp((int)(G * Gmul));
                        B = clamp((int)(B * Bmul));

                        ptr[j * 3 + i * stride + 2] = (byte)R;
                        ptr[j * 3 + i * stride + 1] = (byte)G;
                        ptr[j * 3 + i * stride + 0] = (byte)B;
                    }
                }
            }
            b.UnlockBits(data);
        }
        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            multiplyPixel(workingImage, 1, 0, 0);
            pbMainImage.Image = workingImage;
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            multiplyPixel(workingImage, 0, 1, 0);
            pbMainImage.Image = workingImage;
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            multiplyPixel(workingImage, 0, 0, 1);
            pbMainImage.Image = workingImage;
        }

        private void rToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            multiplyPixel(workingImage, 0, 1, 1);
            pbMainImage.Image = workingImage;
        }

        private void gToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            multiplyPixel(workingImage, 1, 0, 1);
            pbMainImage.Image = workingImage;
        }

        private void bToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);
            multiplyPixel(workingImage, 1, 1, 0);
            pbMainImage.Image = workingImage;
        }

        private void tbRadius_TextChanged(object sender, EventArgs e)
        {
            try
            {
                uint test = 1 / Convert.ToUInt32(tbRadius.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Radius must be a positive integer!");
                tbRadius.Text = "1";
            }
        }

        private void sinCityEffect(Bitmap bmp)
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
                        int R = ptr[j * 3 + i * stride + 2];
                        int G = ptr[j * 3 + i * stride + 1];
                        int B = ptr[j * 3 + i * stride + 0];
                        if (R > 150 || (Math.Abs(G+B) < R))
                        {
                            G = (G + B) / 2;
                            B = G;
                        }
                        else
                        {
                            int rez = R + B + G;
                            rez /= 3;
                            ptr[j * 3 + i * stride + 2] = (byte) rez;
                            ptr[j * 3 + i * stride + 1] = (byte) rez;
                            ptr[j * 3 + i * stride + 0] = (byte) rez;
                        }
                    }
                }
            }

            bmp.UnlockBits(data);
            pbMainImage.Image = bmp;

        }
        private void sinCityRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sinCityEffect(workingImage);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brightnessSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            progressBarLoading.Value = 0;

            int rectWidth = workingImage.Width;
            int rectHeight = workingImage.Height;

            progressBarLoading.Value = 1;
            progressBarLoading.Maximum = 2 * rectHeight + 1;
            List<Color> l1 = new List<Color>();

            BitmapData data = workingImage.LockBits(new Rectangle(0, 0, rectWidth, rectHeight), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < rectHeight; i++)
                {
                    for (int j = 0; j < rectWidth; j++)
                    {

                        int R1 = ptr[j * 3 + i * stride + 2];
                        int G1 = ptr[j * 3 + i * stride + 1];
                        int B1 = ptr[j * 3 + i * stride + 0];

                        Color C1 = Color.FromArgb(R1, G1, B1);
                        l1.Add(C1);
                    }
                  progressBarLoading.Value++;
                }
                progressBarLoading.ForeColor = Color.Red;
                progressBarLoading.Refresh();


                l1.Sort(delegate (System.Drawing.Color left, System.Drawing.Color right)
                {
                    return left.GetBrightness().CompareTo(right.GetBrightness());
                });

                for (int i = 0; i < rectHeight; i++)
                {
                    for (int j = 0; j < rectWidth; j++)
                    {

                        ptr[j * 3 + i * stride + 2] = l1[i * rectWidth + j].R;
                        ptr[j * 3 + i * stride + 1] = l1[i * rectWidth + j].G;
                        ptr[j * 3 + i * stride + 0] = l1[i * rectWidth + j].B;
                    }
                    progressBarLoading.Value++;
                }
            }
            /*           BitmapData data = workingImage.LockBits(new Rectangle(0, 0, rectWidth, rectHeight), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                       int stride = data.Stride;
                       unsafe
                       {
                           byte* ptr = (byte*)data.Scan0;
                           for (int i = 0; i < rectHeight; i++)
                           {
                               for (int j = 0; j < rectWidth; j++)
                               {
                                   for (int k = 0; k < rectHeight; k++)
                                   {
                                       for (int l = 0; l < rectWidth; l++)
                                       {
                                           int R1 = ptr[j * 3 + i * stride + 2];
                                           int G1 = ptr[j * 3 + i * stride + 1];
                                           int B1 = ptr[j * 3 + i * stride + 0];

                                           int R2 = ptr[l * 3 + k * stride + 2];
                                           int G2 = ptr[l * 3 + k * stride + 1];
                                           int B2 = +ptr[l * 3 + k * stride + 0];

                                           Color C1 = Color.FromArgb(R1, G1, B1);
                                           Color C2 = Color.FromArgb(R2, G2, B2);
                                           float S1 = C1.GetBrightness();
                                           float S2 = C2.GetBrightness();


                                           if (S1 < S2)
                                           {
                                               byte pom = ptr[j * 3 + i * stride + 2];
                                               ptr[j * 3 + i * stride + 2] = ptr[l * 3 + k * stride + 2];
                                               ptr[l * 3 + k * stride + 2] = pom;

                                               pom = ptr[j * 3 + i * stride + 1];
                                               ptr[j * 3 + i * stride + 1] = ptr[l * 3 + k * stride + 1];

                                               ptr[l * 3 + k * stride + 1] = pom;
                                               pom = ptr[j * 3 + i * stride + 0];
                                               ptr[j * 3 + i * stride + 0] = ptr[l * 3 + k * stride + 0];
                                               ptr[l * 3 + k * stride + 0] = pom;
                                           }
                                       }
                                   }
                                   progressBarLoading.Value++;
                               }
                           }
                       }*/

            workingImage.UnlockBits(data);
            pbMainImage.Image = workingImage;
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUndo(workingImage);

            progressBarLoading.Value = 0;

            int width = workingImage.Width;
            int height = workingImage.Height;

            progressBarLoading.Value = 1;
            progressBarLoading.Maximum = height + 1;
            BitmapData data = workingImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            int C0=0, C1=0, C2=1;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        C0 = C1;
                        C1 = C2;
                        C2 = C0 + C1;


                        C0 %= 256;
                        C1 %= 256;
                        C2 %= 256;

                        ptr[j * 3 + i * stride + 2] = (byte) C0;
                        ptr[j * 3 + i * stride + 1] = (byte) C1;
                        ptr[j * 3 + i * stride + 0] = (byte) C2;
                    }
                    progressBarLoading.Value++;
                }
            }

            workingImage.UnlockBits(data);
            pbMainImage.Image = workingImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbMainImage.Size = new Size(this.Size.Width - 80, this.Size.Height - 110);
            progressBarLoading.Size = new Size(this.Size.Width - 28, progressBarLoading.Size.Height);
            progressBarLoading.Location = new Point(progressBarLoading.Location.X, this.Size.Height - 74);
        }

        public void mandelbrotGenerator(int numberOfColors)
        {
            // Holds all of the possible colors
            Color[] cs = new Color[numberOfColors];
            Random R = new Random();
            int iterator, i, j;
            double differenceX = 0.0, differenceY = 0.0;

            for (i = 0; i < numberOfColors - 1; i++)
            {
                if (numberOfColors < 255)
                    cs[i] = Color.FromArgb(i * (255 / (numberOfColors - 1)), 0, 0);
                else
                {
                    
                    cs[i] = Color.FromArgb(clamp(i), clamp(i-256), clamp(i-512));
                }
      //          if(i>65533)
      //          MessageBox.Show(cs[i].ToString());
            }
            cs[numberOfColors-1] = Color.Black;
            double x, y, x1, y1, xx, xmin, xmax, ymin, ymax = 0.0;

            xmin = .335; // Start x value, normally -2.1
            ymin = .335; // Start y value, normally -1.3
            xmax = .423; // Finish x value, normally 1
            ymax = .385; // Finish y value, normally 1.3
            differenceX = (xmax - xmin) / workingImage.Width; // Make it fill the whole window
            differenceY = (ymax - ymin) / workingImage.Height;
            x = xmin;
            progressBarLoading.Maximum = workingImage.Width;
            progressBarLoading.Value = 0;

            for (i = 1; i < workingImage.Width; i++)
            {
                y = ymin;
                for (j = 1; j < workingImage.Height; j++)
                {
                    x1 = y1 = iterator = 0;

                    while (iterator < (numberOfColors-1) && Math.Sqrt((x1 * x1) + (y1 * y1)) < 2)
                    {
                        iterator++;
                        xx = (x1 * x1) - (y1 * y1) + x;
                        y1 = 2 * x1 * y1 + y;
                        x1 = xx;
                    }
                    workingImage.SetPixel(i, j, cs[iterator]);
                    y += differenceY;
                }
                progressBarLoading.Value++;
                x += differenceX;
                if (numberOfColors > 512)
                {
                    pbMainImage.Image = workingImage; // Draw it to the form
                    pbMainImage.Refresh();
                }
            }
            pbMainImage.Image = workingImage; // Draw it to the form
        }

        private void mandelbrotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mandelbrotGenerator(768);
        }

        private void pbMainColorPick_Click(object sender, EventArgs e)
        {
            ColorPicker C = new ColorPicker();
            C.ShowDialog();
            if (C.DialogResult == DialogResult.OK)
            {
                mainDrawColor = Color.FromArgb(C.R, C.G, C.B);
                pbMainColorPick.BackColor = mainDrawColor;
            }
        }
    }
}

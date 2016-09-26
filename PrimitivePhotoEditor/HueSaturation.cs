using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace PrimitivePhotoEditor
{
    public partial class HueSaturation : Form
    {
        public HueSaturation(Form1 _originalForm)
        {
            InitializeComponent();
            originalForm = _originalForm;
        }

        public Bitmap resultImage;
        private Bitmap tempImage;
        private Form1 originalForm;

        private void trackBarHue_ValueChanged(object sender, EventArgs e)
        {
            lblHueValue.Text = Convert.ToString(trackBarHue.Value - 180);
        }

        public void RGBtoHSV(Color C)
        {

        }
        
        private void applyHSB(Bitmap b, double hue, double saturation, double brightness)
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

                        R = (int)((double)R * (double)(brightness + 100) / 100d);
                        G = (int)((double)G * (double)(brightness + 100) / 100d);
                        B = (int)((double)B * (double)(brightness + 100) / 100d);

                        R = R < 255 ? R : 255;
                        G = G < 255 ? G : 255;
                        B = B < 255 ? B : 255;
                        //                MessageBox.Show("Promenjeno sa " + ptr[j * 3 + i * stride + 2] + " na " + R);
                        ptr[j * 3 + i * stride + 2] = (byte) R;
                        ptr[j * 3 + i * stride + 1] = (byte) G;
                        ptr[j * 3 + i * stride + 0] = (byte) B;
                    }
                }
            }

            b.UnlockBits(data);
        }

        private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
        {
            lblBrightnessValue.Text = Convert.ToString(trackBarBrightness.Value - 100);
            if(cbPreview.Checked)
                updatePreview();

        }

        private void updatePreview()
        {
            int width = tempImage.Width;
            int height = tempImage.Height;

            if (tempImage != null)
            {
                tempImage.Dispose();
                tempImage = null;
            }

            tempImage = new Bitmap(originalForm.workingImage, width, height);

            applyHSB(tempImage, trackBarHue.Value - 180, trackBarSaturation.Value - 100, trackBarBrightness.Value - 100);

            originalForm.pbMainImage.Image = tempImage;
        }

        private void cbPreview_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPreview.Checked)
            {
                updatePreview();
            }
            else
            {
                originalForm.pbMainImage.Image = originalForm.workingImage;
            }
        }

        private void HueSaturation_Load(object sender, EventArgs e)
        {
            int width = originalForm.workingImage.Width;
            int height = originalForm.workingImage.Height;
            double tmp = 1;

            if (width > height && width > 1000)
                tmp = width / 800;

            else if (height > width && height > 800)
                tmp = height / 800;
            

            resultImage = new Bitmap(originalForm.workingImage, width, height);
            tempImage = new Bitmap(resultImage);
        }

        private void HueSaturation_FormClosing(object sender, FormClosingEventArgs e)
        {
            applyHSB(originalForm.workingImage, trackBarHue.Value - 180, trackBarSaturation.Value - 100, trackBarBrightness.Value - 100);

            originalForm.pbMainImage.Image = originalForm.workingImage;
        }
    }
}

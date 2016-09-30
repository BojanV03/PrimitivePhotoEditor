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



        public static Color ColorFromAhsb(int a, float h, float s, float b)
        {
            int Switch, maxIntValue, midIntValue, minIntValue;
            float maxValue, midValue, minValue;

            if (0.5 < b)
            {
                maxValue = b - (b * s) + s;
                minValue = b + (b * s) - s;
            }
            else
            {
                maxValue = b + (b * s);
                minValue = b - (b * s);
            }

            Switch = (int)Math.Floor(h / 60f);
            if (300f <= h)
                h -= 360f;

            h /= 60f;
            h -= 2f * (float)Math.Floor(((Switch + 1f) % 6f) / 2f);
            if (0 == Switch % 2)
                midValue = h * (maxValue - minValue) + minValue;

            else
                midValue = minValue - h * (maxValue - minValue);

            maxIntValue = Convert.ToInt32(maxValue * 255);
            midIntValue = Convert.ToInt32(midValue * 255);
            minIntValue = Convert.ToInt32(minValue * 255);

            switch (Switch)
            {
                case 1: return Color.FromArgb(a, midIntValue, maxIntValue, minIntValue);
                case 2: return Color.FromArgb(a, minIntValue, maxIntValue, midIntValue);
                case 3: return Color.FromArgb(a, minIntValue, midIntValue, maxIntValue);
                case 4: return Color.FromArgb(a, midIntValue, minIntValue, maxIntValue);
                case 5: return Color.FromArgb(a, maxIntValue, minIntValue, midIntValue);
                default: return Color.FromArgb(a, maxIntValue, midIntValue, minIntValue);
            }
        }

        private void applyHSB(Bitmap b, double hue, double saturation, double brightness)
        {
            int width = b.Width;
            int height = b.Height;
            BitmapData data = b.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;
            originalForm.progressBarLoading.Maximum = height + 2;
            originalForm.progressBarLoading.Value = 1;
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {

                        int Red = ptr[j * 3 + i * stride + 2];
                        int Green = ptr[j * 3 + i * stride + 1];
                        int Blue = ptr[j * 3 + i * stride + 0];
                        Color orig = Color.FromArgb(Red, Green, Blue);
                        float H = orig.GetHue() + (float)(hue);
                        float S = orig.GetSaturation() * (float)(saturation / 75);
                        float B = orig.GetBrightness() * (float)(brightness /100.0);

                        if (H < 0)
                            H = 0;
                        if (H > 360)
                            H -= 360;
                        if (S < 0)
                            S = 0;
                        if (S > 1)
                            S = 1;
                        if (B < 0)
                            B = 0;
                        if (B > 1)
                            B = 1;
                        Color C = ColorFromAhsb(255, H, S, B);

                        //                MessageBox.Show("Promenjeno sa " + ptr[j * 3 + i * stride + 2] + " na " + R);
                        ptr[j * 3 + i * stride + 2] = (byte) C.R;
                        ptr[j * 3 + i * stride + 1] = (byte) C.G;
                        ptr[j * 3 + i * stride + 0] = (byte) C.B;
                    }
                    originalForm.progressBarLoading.Value ++;
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
        private void trackBarSaturation_ValueChanged(object sender, EventArgs e)
        {
            lblSaturationValue.Text = Convert.ToString(trackBarSaturation.Value - 100);
            if (cbPreview.Checked)
                updatePreview();
        }
        private void trackBarHue_ValueChanged(object sender, EventArgs e)
        {
            lblHueValue.Text = Convert.ToString(trackBarHue.Value - 180);
            if (cbPreview.Checked)
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

            applyHSB(tempImage, trackBarHue.Value-180, trackBarSaturation.Value, trackBarBrightness.Value);

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
            tempImage = new Bitmap(resultImage,(int) (width/tmp), (int)(height/tmp));
        }

        private void HueSaturation_FormClosing(object sender, FormClosingEventArgs e)
        {
            applyHSB(originalForm.workingImage, trackBarHue.Value - 180, trackBarSaturation.Value, trackBarBrightness.Value);

            originalForm.pbMainImage.Image = originalForm.workingImage;
        }


    }
}

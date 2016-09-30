using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitivePhotoEditor
{
    public partial class ColorPicker : Form
    {
        public ColorPicker()
        {
            InitializeComponent();
        }
        public int R, G, B;

        private void initializePictureBox(PictureBox pb, Color finalColor)
        {
            Graphics g = pb.CreateGraphics();
            int R = 0, G = 0, B = 0;

            for(int i = 0; i < 255; i++)
            {
                R += finalColor.R / 255;
                G += finalColor.G / 255;
                B += finalColor.B / 255;
                g.DrawLine(new Pen(Color.FromArgb(R, G, B), 1), i, 0, i, pb.Height-1);
            }
            g.Dispose();
            tbRed.Text = "0";
            tbGreen.Text = "0";
            tbBlue.Text = "0";
        }

        private void setPictureBox(PictureBox pb, Color finalColor, int clickLocation)
        {
            Graphics g = pb.CreateGraphics();
            int R = 0, G = 0, B = 0;

            for (int i = 0; i < 255; i++)
            {
                R += finalColor.R / 255;
                G += finalColor.G / 255;
                B += finalColor.B / 255;
                g.DrawLine(new Pen(Color.FromArgb(R, G, B), 1), i, 0, i, pb.Height - 1);
            }
            //invert selected color:
            R = 255 - clickLocation;
            G = 255 - clickLocation;
            B = 255 - clickLocation;

            g.DrawLine(new Pen(Color.FromArgb(R, G, B), 3), clickLocation, 0, clickLocation, pb.Height - 1);
            g.Dispose();

            updatePreview();
        }

        private void updatePreview()
        {
            try { R = Int32.Parse(tbRed.Text.Trim()); }
            catch (Exception)
            {
                R = 0;
                tbRed.Text = "0";
            }

            try { G = Int32.Parse(tbGreen.Text.Trim()); }
            catch (Exception)
            {
                G = 0;
                tbGreen.Text = "0";
            }

            try { B = Int32.Parse(tbBlue.Text.Trim()); }
            catch (Exception)
            {
                B = 0;
                tbBlue.Text = "0";
            }

            pbPreview.BackColor = Color.FromArgb(R, G, B);
        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {
            pbRed.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            initializePictureBox(pbRed, Color.FromArgb(255, 0, 0));
            initializePictureBox(pbGreen, Color.FromArgb(0, 255, 0));
            initializePictureBox(pbBlue, Color.FromArgb(0, 0, 255));
            pbPreview.BackColor = Color.Black;
            timer1.Enabled = false;
        }

        private void ColorPicker_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pbRed_MouseClick(object sender, MouseEventArgs e)
        {
            int clickLocation = e.Location.X;

            setPictureBox(pbRed, Color.Red, clickLocation);
            tbRed.Text = clickLocation.ToString();
        }

        private void tbRed_TextChanged(object sender, EventArgs e)
        {
            try { R = Int32.Parse(tbRed.Text.Trim()); setPictureBox(pbRed, Color.Red, R); }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Color intensity must be a positive integers < 255");
            }
        }

        private void tbGreen_TextChanged(object sender, EventArgs e)
        {
            try { G = Int32.Parse(tbGreen.Text.Trim()); setPictureBox(pbGreen, Color.FromArgb(0, 255, 0), G); }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Color intensity must be a positive integers < 255");
            }
        }

        private void tbBlue_TextChanged(object sender, EventArgs e)
        {
            try { B = Int32.Parse(tbBlue.Text.Trim()); setPictureBox(pbBlue, Color.Blue, B); }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Color intensiti must be a positive integers < 255");
            }
        }

        private void pbGreen_MouseClick(object sender, MouseEventArgs e)
        {
            int clickLocation = e.Location.X;

            setPictureBox(pbGreen, Color.FromArgb(0, 255, 0), clickLocation);
            tbGreen.Text = clickLocation.ToString();
        }

        private void pbBlue_MouseClick(object sender, MouseEventArgs e)
        {
            int clickLocation = e.Location.X;

            setPictureBox(pbBlue, Color.Blue, clickLocation);
            tbBlue.Text = clickLocation.ToString();
        }
    }
}

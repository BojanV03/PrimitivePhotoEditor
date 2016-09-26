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
    public partial class SizePicker : Form
    {
        public SizePicker()
        {
            InitializeComponent();
        }

        public int chosenWidth, chosenHeight;
        public uint tmpWidth = 1024, tmpHeight = 1024;

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            try { tmpHeight = UInt32.Parse(tbHeight.Text); }
            catch (Exception)
            {
                MessageBox.Show("Height must be a positive integer!");
            }

            if (tmpHeight * tmpWidth > 15000000)
            {
                DialogResult Dr = MessageBox.Show("You may encounter memory problems with resolution that high, are you sure you want to continue?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (Dr == DialogResult.No)
                {
                    return;
                }
            }
            chosenHeight = (int)tmpHeight;
        }

        private void tbWidth_TextChanged(object sender, EventArgs e)
        {
            try{tmpWidth = UInt32.Parse(tbWidth.Text);}
            catch (Exception)
            {
                MessageBox.Show("Height must be a positive integer!");
            }

            if (tmpHeight * tmpWidth > 15000000)
            {
                DialogResult Dr = MessageBox.Show("You may encounter memory problems with resolution that high, are you sure you want to continue?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (Dr == DialogResult.No)
                {
                    return;
                }
            }
            chosenWidth = (int)tmpWidth;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            chosenHeight = (int)tmpHeight;
            chosenWidth = (int)tmpWidth;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiddenWordsLibrary;

namespace HiddenWords
{
    public partial class TestForm : Form
    {
        BMPHandle cronchor = new BMPHandle();
        public TestForm()
        {
            
            InitializeComponent();
        }

        private void convertButton_click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("We need input text to function!");
            }
            else if (LoadedPictureTest.Image == null)
            {
                MessageBox.Show("We need an image also!");
            }
            else
            {
                cronchor = new BMPHandle(LoadedPictureTest.Image, textBox1.Text);
                cronchor.BigFatEncoding();
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    cronchor.saveImage(saveFileDialog1.FileName);
                }
            }
        }

        private void pictureBrowseButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap loadedPic = new Bitmap(openFileDialog1.FileName);
                LoadedPictureTest.Image = loadedPic;
            }
        }
    }
}

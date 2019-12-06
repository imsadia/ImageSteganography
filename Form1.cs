using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VP_Project
{
    public partial class mainForm : Form
    {
        string imagePath;
        string textFilePath;
        OpenFileDialog opf;
        public mainForm()
        {
            InitializeComponent();
            opf = new OpenFileDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BtnImgBrowse_Click(object sender, EventArgs e)
        {
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imagePath = opf.FileName;
                pbDisplayImage.Image = Image.FromFile(imagePath);
                pbDisplayImage.SizeMode = PictureBoxSizeMode.StretchImage;
                tbImgBrowse.Text = imagePath;
                Bitmap bmpImage = new Bitmap(pbDisplayImage.Image);
                double bytes = new FileInfo(imagePath).Length;
                double kb = Math.Round(bytes / 1024f, 0);
                lbHeight.Text = bmpImage.Height.ToString();
                lbWidth.Text = bmpImage.Width.ToString();
                lbSize.Text = kb + " KB";

                int i, j, numberOfPixels = 0;
                for (i = 0; i < bmpImage.Width; i++)
                {
                    for (j = 0; j < bmpImage.Height; j++)
                    {
                        Color pixels = bmpImage.GetPixel(i, j);
                        numberOfPixels++;
                    }
                }
                lbPixels.Text = numberOfPixels.ToString();
            }
        }

        private void BtnFileBrowse_Click(object sender, EventArgs e)
        {
            if(opf.ShowDialog() ==  DialogResult.OK)
            {
                textFilePath = opf.FileName;
                tbFileBrowse.Text = textFilePath;
                rtbTextFile.Text = File.ReadAllText(textFilePath);
            }
        }
    }
}

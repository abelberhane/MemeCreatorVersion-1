using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meme_Creator_Version_1
{
    public partial class Form1 : Form
    {

        // Open File Dialog will find the image and I can store it in imageFile.
        OpenFileDialog openImage;
        string imageFile;

        public Form1()
        {
            InitializeComponent();
        }

        // This makes the text entered in the Top Text box show up as the top label on the meme. Also adding maximum width for the label.
        private void topText_TextChanged(object sender, EventArgs e)
        {
            topLabel.Text = topText.Text;
            topLabel.MaximumSize = new Size(preview.Width, 200);
        }

        // This makes the text entered in the Bottom Text box show up as the bottom label on the meme. Also adding maximum width for the label.
        private void bottomText_TextChanged(object sender, EventArgs e)
        {
            bottomLabel.Text = bottomText.Text;
            bottomLabel.MaximumSize = new Size(preview.Width, 200);
        }

        // Setting up the Open File button. Filtering is on and for Images only and where to start. 
        private void open_Click(object sender, EventArgs e)
        {
            openImage = new OpenFileDialog();
            openImage.InitialDirectory = "c:\\";
            openImage.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif; *.bmp";
            openImage.FilterIndex = 2;
            openImage.RestoreDirectory = true;

            // I will try to open the File in the preview box, if theres an error, show the message
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    preview.Image = Image.FromFile(openImage.FileName);
                    imageFile = openImage.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read the file. Original Error: " + ex.Message);
                }
            }
        }

        // Logic for the Save button. Top 2 strings hold the text from the meme. Save a copy of the image we are using in memory. 
        private void save_Click(object sender, EventArgs e)
        {
            string firstText = topText.Text;
            string secondText = bottomText.Text;

            Bitmap bitmap = (Bitmap)Image.FromFile(imageFile);

            // Creating rectangle for the text to stay inside. 
            RectangleF TopSize = new RectangleF(0, 10, bitmap.Width, 400);
            RectangleF BottomSize = new RectangleF(0, bitmap.Height - 100, bitmap.Width, 400);

            // Creating the Save Dialog box. User enters the name and we set it as a Bitmap image. Also validate the images. 
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.FileName = "*";
            saveImage.DefaultExt = "bmp";
            saveImage.ValidateNames = true;
            saveImage.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpg)|*jpeg |Png Image (.png)|*.png";

            // Similar to the Open, this condition is run when the image has been loaded. Choosing the typography.
            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font memeFont = new Font("Impact", 24, FontStyle.Bold, GraphicsUnit.Point))
                    {
                        graphics.DrawString(firstText, memeFont, Brushes.White, TopSize);
                        graphics.DrawString(secondText, memeFont, Brushes.White, BottomSize);
                    }
                }

                // Save the Image
                bitmap.Save(saveImage.FileName);
            }
        }
    }
}

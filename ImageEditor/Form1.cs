using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
namespace ImageEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image Img;
        private Size OriginalImageSize;
        private Size ModifiedImageSize;

        int cropX;
        int cropY;
        int cropWidth;

        int cropHeight;
        int oCropX;
        int oCropY;
        public Pen cropPen;

        public DashStyle cropDashStyle = DashStyle.DashDot;
        public bool Makeselection = false;

        public bool CreateText = false;

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "";
            Dlg.Title = "Select image";
            if (Dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Img = Image.FromFile(Dlg.FileName);
                //Image.FromFile(String) method creates an image from the specifed file, here dlg.Filename contains the name of the file from which to create the image
                LoadImage();
            }

        }
        private void LoadImage()
        {
            //we set the picturebox size according to image, we can get image width and height with the help of Image.Width and Image.height properties.
            int imgWidth = Img.Width;
            int imghieght = Img.Height;
            PictureBox1.Width = imgWidth;
            PictureBox1.Height = imghieght;
            PictureBox1.Image = Img;
            PictureBoxLocation();
            OriginalImageSize = new Size(imgWidth, imghieght);

            SetResizeInfo();
        }
        private void PictureBoxLocation()
        {
            int _x = 0;
            int _y = 0;
            if (SplitContainer1.Panel1.Width > PictureBox1.Width)
            {
                _x = (SplitContainer1.Panel1.Width - PictureBox1.Width) / 2;
            }
            if (SplitContainer1.Panel1.Height > PictureBox1.Height)
            {
                _y = (SplitContainer1.Panel1.Height - PictureBox1.Height) / 2;
            }
            PictureBox1.Location = new Point(_x, _y);
        }

        private void SetResizeInfo()
        {

            OriginalSizeLabel.Text = OriginalImageSize.ToString();
            ModifiedSizeLabel.Text = ModifiedImageSize.ToString();

        }

        private void SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            PictureBoxLocation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bm_source = new Bitmap(PictureBox1.Image);
            // Make a bitmap for the result.
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(ModifiedImageSize.Width), Convert.ToInt32(ModifiedImageSize.Height));
            // Make a Graphics object for the result Bitmap.
            Graphics gr_dest = Graphics.FromImage(bm_dest);
            // Copy the source image into the destination bitmap.
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
            // Display the result.
            PictureBox1.Image = bm_dest;
            PictureBox1.Width = bm_dest.Width;
            PictureBox1.Height = bm_dest.Height;
            PictureBoxLocation();
        }

        private void DomainUpDown1_SelectedItemChanged_1(object sender, EventArgs e)
        {
            int percentage = 0;
            try
            {
                percentage = Convert.ToInt32(DomainUpDown1.Text);
                ModifiedImageSize = new Size((OriginalImageSize.Width * percentage) / 100, (OriginalImageSize.Height * percentage) / 100);
                SetResizeInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Percentage");
                return;
            }

        }
        private void BindDomainIUpDown()
        {
            for (int i = 1; i <= 999; i++)
            {
                DomainUpDown1.Items.Add(i);
            }
            DomainUpDown1.Text = "100";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDomainIUpDown();
        }

        #region "-----------------------------Crop Image------------------------------------"

        private void MakeSelectionButton_Click(object sender, EventArgs e)
        {
            Makeselection = true;
            CropButton.Enabled = true;

        }

        private void CropButton_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.Default;

            try
            {
                if (cropWidth < 1)
                {
                    return;
                }
                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
                //First we define a rectangle with the help of already calculated points
                Bitmap OriginalImage = new Bitmap(PictureBox1.Image, PictureBox1.Width, PictureBox1.Height);
                //Original image
                Bitmap _img = new Bitmap(cropWidth, cropHeight);
                // for cropinf image
                Graphics g = Graphics.FromImage(_img);
                // create graphics
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                //set image attributes
                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);

                PictureBox1.Image = _img;
                PictureBox1.Width = _img.Width;
                PictureBox1.Height = _img.Height;
                PictureBoxLocation();
                CropButton.Enabled = false;
            }
            catch (Exception ex)
            {
            }
        }


        private void PictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (TabControl1.SelectedIndex == 4)
            {
                Point TextStartLocation = e.Location;
                if (CreateText)
                {
                    Cursor = Cursors.IBeam;
                }
            }
            else
            {
                Cursor = Cursors.Default;
                if (Makeselection)
                {

                    try
                    {
                        if (e.Button == System.Windows.Forms.MouseButtons.Left)
                        {
                            Cursor = Cursors.Cross;
                            cropX = e.X;
                            cropY = e.Y;

                            cropPen = new Pen(Color.Black, 1);
                            cropPen.DashStyle = DashStyle.DashDotDot;


                        }
                        PictureBox1.Refresh();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }


        }

        private void PictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (Makeselection)
            {
                Cursor = Cursors.Default;
            }

        }

        private void PictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (TabControl1.SelectedIndex == 4)
            {
                Point TextStartLocation = e.Location;
                if (CreateText)
                {
                    Cursor = Cursors.IBeam;
                }
            }
            else
            {
                Cursor = Cursors.Default;
                if (Makeselection)
                {

                    try
                    {
                        if (PictureBox1.Image == null)
                            return;


                        if (e.Button == System.Windows.Forms.MouseButtons.Left)
                        {
                            PictureBox1.Refresh();
                            cropWidth = e.X - cropX;
                            cropHeight = e.Y - cropY;
                            PictureBox1.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
                        }



                    }
                    catch (Exception ex)
                    {
                        //if (ex.Number == 5)
                        //    return;
                    }
                }
            }

        }
        # endregion

        private void TrackBarBrightness_Scroll(object sender, EventArgs e)
        {
            UpDownBrightness.Text = TrackBarBrightness.Value.ToString();


            float value = TrackBarBrightness.Value * 0.01f;
            float[][] colorMatrixElements = {
                new float[] {
                    1,
                    0,
                    0,
                    0,
                    0
                },
                new float[] {
                    0,
                    1,
                    0,
                    0,
                    0
                },
                new float[] {
                    0,
                    0,
                    1,
                    0,
                    0
                },
                new float[] {
                    0,
                    0,
                    0,
                    1,
                    0
                },
                new float[] {
                    value,
                    value,
                    value,
                    0,
                    1
                }
            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();


            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);



            Image _img = Img;
            //PictureBox1.Image
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            PictureBox1.Image = bm_dest;

        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PictureBox1.Refresh();
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            PictureBox1.Refresh();
        }

        private void btnRotateHorizantal_Click(object sender, EventArgs e)
        {
            PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PictureBox1.Refresh();
        }

        private void btnRotatevertical_Click(object sender, EventArgs e)
        {
            PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            PictureBox1.Refresh();
        }
    }
}

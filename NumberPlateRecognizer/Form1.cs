using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using Tesseract;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
namespace ImageEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabPage1.Enabled = false;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
        }

        private Image Img;
        private Image CroppedImage;
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
                LoadImage();
                tabPage3.Enabled = true;
            }

        }
        private void LoadImage()
        {
            PictureBox1.Image = Img;
        }

        private void SetResizeInfo()
        {

            OriginalSizeLabel.Text = OriginalImageSize.ToString();
            ModifiedSizeLabel.Text = ModifiedImageSize.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bm_source = new Bitmap(pictureBox2.Image);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(ModifiedImageSize.Width), Convert.ToInt32(ModifiedImageSize.Height));
            Graphics gr_dest = Graphics.FromImage(bm_dest);
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
            pictureBox2.Image = bm_dest;
            pictureBox2.Width = bm_dest.Width;
            pictureBox2.Height = bm_dest.Height;
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
                Bitmap OriginalImage = new Bitmap(PictureBox1.Image, PictureBox1.Image.Width, PictureBox1.Image.Height);
                Bitmap _img = new Bitmap(cropWidth, cropHeight);
                // for cropinf image
                Graphics g = Graphics.FromImage(_img);
                // create graphics
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                //set image attributes
                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);

                pictureBox2.Image = _img;
                CropButton.Enabled = false;
                int imgWidth = _img.Width;
                int imghieght = _img.Height;
                OriginalImageSize = new Size(imgWidth, imghieght);
                SetResizeInfo();
                tabPage1.Enabled = true;
                tabPage2.Enabled = true;
                CroppedImage = _img;
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



            Image _img = CroppedImage;
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            pictureBox2.Image = bm_dest;
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

        private void button2_Click(object sender, EventArgs e)
        {
            var ocrengine = new TesseractEngine(@".\tessdata", "eng", EngineMode.Default);
            Bitmap bitmapImage = new Bitmap(pictureBox2.Image);
           
            var img = PixConverter.ToPix(bitmapImage);
            var res = ocrengine.Process(img);
            textBox1.Text = res.GetText();
        }

        public void DetectNumberLocation(Bitmap image)
        {
            Image<Bgr, byte> mainImage = new Image<Bgr, byte>(image);
            CascadeClassifier cascadeClassifier = new CascadeClassifier(@".\haarcascade_classifier.xml");
            using (Image<Gray, Byte> grayFrame = new Image<Gray, Byte>(image))
            {
                var face = cascadeClassifier.DetectMultiScale(grayFrame, 1.1, 8)[0];
                mainImage.Draw(face, new Bgr(Color.Blue), 2);
                Bitmap detectedNumber = new Bitmap(face.Width, face.Height);
                Graphics g = Graphics.FromImage(detectedNumber);
                g.DrawImage(mainImage.ToBitmap(), 0, 0, face, GraphicsUnit.Pixel);

                PictureBox1.Image = mainImage.ToBitmap();
                pictureBox2.Image = detectedNumber;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bitmapImage = new Bitmap(PictureBox1.Image);
            DetectNumberLocation(bitmapImage);
        }
    }
}

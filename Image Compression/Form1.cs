using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TinifyAPI;

namespace Image_Compression
{
    public partial class FrmCompression : Form
    {

        public FrmCompression()
        {
            InitializeComponent();
            picSource.SizeMode = picDestination.SizeMode = PictureBoxSizeMode.StretchImage;
            Tinify.Key = AppConfig.API;
            createBackdrop();
            StopAnimation();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "JPG, PNG|*.jpg;*.png",
                Title = "Select an Image to Compress",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picSource.Image = Image.FromFile(openFileDialog.FileName);
                computeSize(picSource, lblSourceImgSize);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Save the Compressed Image",
                DefaultExt = ".jpg"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                picDestination.Image.Save(saveFileDialog.FileNames[0]);
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            compress(picSource, picDestination, lblDestinationImgSize);
        }

        private async void compress(PictureBox picSrc, PictureBox picDest, Label lblSize)
        {
            PlayAnimation();
            var source = Tinify.FromBuffer(ImgToByte(picSource.Image));
            source = source.Preserve("copyright");
            var result = await source.ToBuffer();
            picDest.Image = ByteToImg(result);
            computeSize(picDest, lblSize);
            StopAnimation();
            MessageBox.Show(Tinify.CompressionCount.Value.ToString());
        }

        #region HelperMethods
        private void computeSize(PictureBox picture, Label label)
        {
            var ms = new MemoryStream();
            picture.Image.Save(ms, ImageFormat.Jpeg);
            double sizeInBytes = ms.Length;
            int i = 0;
            do
            {
                sizeInBytes /= 1024;
                i++;
            } while (sizeInBytes >= 1024);

            label.Text = string.Format("{0:0.00}", sizeInBytes);

            if (i >= 1 && i < 2)
            {
                label.Text += "KB";
            }
            else if (i >= 2 && i < 3)
            {
                label.Text += "MB";
            }
            else if (i >= 3 && i < 4)
            {
                label.Text += "GB";
            }
            else if (i >= 4 && i < 5)
            {
                label.Text += "TB";
            }
            else
            {
                label.Text += "PB";
            }

        }

        private byte[] ImgToByte(Image image)
        {
            ImageConverter imageConverter = new ImageConverter();
            return (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
        }

        private Image ByteToImg(byte[] byteArr)
        {
            var ms = new MemoryStream(byteArr);
            return Image.FromStream(ms);
        }

        private void createBackdrop()
        {
            pnlLoadingContainer.Location = new Point(0, 0);
            pnlLoadingContainer.Width = ClientRectangle.Width;
            pnlLoadingContainer.Height = ClientRectangle.Height;
            pnlLoadingContainer.BackColor = Color.Black;
        }

        private void PlayAnimation()
        {
            pnlLoadingContainer.Visible = true;
        }

        private void StopAnimation()
        {
            pnlLoadingContainer.Visible = false;
        }

        #endregion


    }
}

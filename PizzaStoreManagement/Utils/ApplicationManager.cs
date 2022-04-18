using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PizzaStoreManagement.Utils
{
    public static class ApplicationManager
    {
        public static Bitmap RotateImage(Image image, float angle)
        {
            return RotateImage(image, new PointF((float)image.Width / 2,
            (float)image.Height / 2), angle);
        }

        public static Bitmap RotateImage(Image image, PointF offset,
        float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image

            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);

            rotatedBmp.SetResolution(image.HorizontalResolution,
             image.VerticalResolution);

            //make a graphics object from the empty bitmap

            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image

            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back

            g.TranslateTransform(-offset.X, -offset.Y);
            //draw passed in image onto 
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static Bitmap ByteArrayToImage(byte[] data)
        {
            return (Bitmap)(new ImageConverter().ConvertFrom(data));
        }

        public static void SetTextBoxStyle(TextBoxBase tb, bool readOnly)
        {
            tb.ReadOnly = readOnly;
            if (readOnly)
            {
                tb.BackColor = Color.FromArgb(127, 143, 166);
                tb.BorderStyle = BorderStyle.None;
            }
            else
            {
                tb.BackColor = Color.FromName("Window");
                tb.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        public static void ShowDialog(Form dialog)
        {
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.FormBorderStyle = FormBorderStyle.None;
            dialog.ShowDialog();
        }
    }
}

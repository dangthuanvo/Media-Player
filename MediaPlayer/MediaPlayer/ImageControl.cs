using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public static class ImageControl
    {
        public static Image RotateImage(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return bmp;
        }
        public static Image FlipImage(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            bmp.RotateFlip(RotateFlipType.Rotate180FlipY);
            return bmp;
        }
        public static Size GetNewSizeToFit(Size sizeBox, Size sizeToFit)
        {
            int wSize = sizeToFit.Width;
            int hSize = sizeToFit.Height;
            int wBox = sizeBox.Width;
            int hBox = sizeBox.Height;
            double tl = (double)hSize / hBox;

            if (wBox * tl > wSize)
            {
                tl = (double)wSize / wBox;
            }
            return new Size((int)(wBox * tl + 0.5), (int)(hBox * tl + 0.5));
        }

        public static Image FitImgToPictureBox(Image image, Size size)
        {
            int wBox = size.Width;
            int hBox = size.Height;
            int wPic = image.Size.Width;
            int hPic = image.Size.Height;
            int newW, newH;
            double tl = (double)hBox / hPic;
            if (wPic * tl > wBox)
            {
                tl = (double)wBox / wPic;
            }
            newW = (int)(wPic * tl);
            newH = (int)(hPic * tl);
            return ResizeImage(image, newW, newH);

        }
        public static Image ResizeImage(Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(image, width, height);
            Graphics gpu = Graphics.FromImage(bmp);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            gpu.Dispose();
            return bmp;
        }
        public static void CorrectExifOrientation(Image image)
        {
            if (image == null) return;
            int orientationId = 0x0112;
            if (image.PropertyIdList.Contains(orientationId))
            {
                var orientation = (int)image.GetPropertyItem(orientationId).Value[0];
                var rotateFlip = RotateFlipType.RotateNoneFlipNone;
                switch (orientation)
                {
                    case 1: rotateFlip = RotateFlipType.RotateNoneFlipNone; 
                        break;
                    case 2: rotateFlip = RotateFlipType.RotateNoneFlipX; 
                        break;
                    case 3: rotateFlip = RotateFlipType.Rotate180FlipNone; 
                        break;
                    case 4: rotateFlip = RotateFlipType.Rotate180FlipX; 
                        break;
                    case 5: rotateFlip = RotateFlipType.Rotate90FlipX; 
                        break;
                    case 6: rotateFlip = RotateFlipType.Rotate90FlipNone;
                        break;
                    case 7: rotateFlip = RotateFlipType.Rotate270FlipX;
                        break;
                    case 8: rotateFlip = RotateFlipType.Rotate270FlipNone; 
                        break;
                    default: rotateFlip = RotateFlipType.RotateNoneFlipNone; 
                        break;
                }
                if (rotateFlip != RotateFlipType.RotateNoneFlipNone)
                {
                    image.RotateFlip(rotateFlip);
                    image.RemovePropertyItem(orientationId);
                }
            }
        }
    }

}

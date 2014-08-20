using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zookr
{
    public static class ImageExtension
    {
        public static ulong Hash(this Image img)
        {
            Bitmap bmp = new Bitmap(img, new Size(8, 8));
            Int32 average = 0;
            ulong hash = 0x0;
            int[] pixelArray = new int[bmp.Width * bmp.Height];
            ColorMatrix colorMatrix = new ColorMatrix(
                new float[][] 
                    {
                        new float[] {.3f, .3f, .3f, 0, 0},
                        new float[] {.59f, .59f, .59f, 0, 0},
                        new float[] {.11f, .11f, .11f, 0, 0},
                        new float[] {0, 0, 0, 1, 0},
                        new float[] {0, 0, 0, 0, 1}
                    });
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Convert to greyscale
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.CompositingMode = CompositingMode.SourceOver;
                g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height),
                   0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);                
            }

            // Calculate average pixel value
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int k = 0; k < bmp.Height; k++)
                {
                    average += bmp.GetPixel(i, k).R;
                    pixelArray[i + (k * bmp.Width)] = bmp.GetPixel(i, k).R;
                }
            }
            average /= (bmp.Width * bmp.Height);
            bmp.Dispose();

            // Set bit based on average value
            for (int i = 0; i < pixelArray.Length; i++)
            {
                hash <<= 1;
                if (pixelArray[i] > average)
                {
                    hash |= 0x01;
                }
            }

            return hash;
        }

        public static Image getThumb(this Image img)
        {
            int thumbWidth = 128;
            int thumbHeight = 128;

            Image thumbnail = new Bitmap(thumbWidth, thumbHeight);
            Graphics graphic = Graphics.FromImage(thumbnail);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphic.CompositingQuality = CompositingQuality.HighQuality;
                        
            double ratioX = (double)thumbWidth / (double)img.Width;
            double ratioY = (double)thumbHeight / (double)img.Height;            
            double ratio = ratioX < ratioY ? ratioX : ratioY;
            int newHeight = Convert.ToInt32(img.Height * ratio);
            int newWidth = Convert.ToInt32(img.Width * ratio);
            int posX = Convert.ToInt32((thumbWidth - (img.Width * ratio)) / 2);
            int posY = Convert.ToInt32((thumbHeight - (img.Height * ratio)) / 2);
                        
            graphic.Clear(Color.White);
            graphic.DrawImage(img, posX, posY, newWidth, newHeight);

            return thumbnail;
        }
    }
}

using KantoorApplicatie.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantoorApplicatie.Controllers {
    public class RotationController {

        private RotatePanel rp;

        public RotationController(RotatePanel rp) {
            this.rp = rp;
        }

        public Bitmap RotateImage(Bitmap img, float rotationAngle) {

            // Determines longest possible side a product can have.
            double c = (int)Math.Sqrt(Math.Pow(img.Width, 2) + Math.Pow(img.Height, 2));

            // Determines wether width or height is smaller.
            double smallest = img.Width;
            if (img.Height < smallest) {
                smallest = img.Height;
            }

            // Makes the smallest side of product as large as the value c.
            if (smallest < c) {
                double i = c / smallest;
                rp.bmWidth = img.Width * i;
                rp.bmHeight = img.Height * i;
            }

            // Creates an empty Bitmap image.
            Bitmap newImage = new Bitmap((int)rp.bmWidth, (int)rp.bmHeight);

            // Sets resolution for correct sharpness and size.
            newImage.SetResolution(rp.originalImage.HorizontalResolution, rp.originalImage.VerticalResolution);

            // Turns the Bitmap into a Graphics object.
            Graphics gfx = Graphics.FromImage(newImage);

            // Sets correct rotation point.
            gfx.TranslateTransform((float)newImage.Width / 2, (float)newImage.Height / 2);

            // Rotates image.
            gfx.RotateTransform(rotationAngle);

            // Sets correct rotation point.
            gfx.TranslateTransform(-(float)newImage.Width / 2, -(float)newImage.Height / 2);

            // Set the InterpolationMode to HighQualityBicubic to ensure a high
            // quality image once it is transformed.
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Determines distance between transparant bitmap edge and visible product edge.
            rp.offsetX = (newImage.Width - img.Width) / 2;
            rp.offsetY = (newImage.Height - img.Height) / 2;

            // Draws product onto larger, transparant bitmap.
            gfx.DrawImage(img, new Point(rp.offsetX, rp.offsetY));

            gfx.Dispose();

            // Returns the image.
            return newImage;
        }
    }
}

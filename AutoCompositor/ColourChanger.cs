using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompositor
{
    class ColourChanger
    {
        public ColourChanger(string Text, string ColorString)
        {
            this.Text = Text;
            this.Value = ColorString;
        }
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    public static class BitmapExt
    {
        public static void ChangeColour(this Bitmap bmp, byte inColourR, byte inColourG, byte inColourB, byte outColourB, byte outColourG, byte outColourR)
        {
            // Specify a pixel format.outColourR
            PixelFormat pxf = PixelFormat.Format32bppArgb;

            // Lock the bitmap's bits.
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData =
            bmp.LockBits(rect, ImageLockMode.ReadWrite,
                         pxf);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap. 
            // int numBytes = bmp.Width * bmp.Height * 3; 
            int numBytes = bmpData.Stride * bmp.Height;
            byte[] rgbValues = new byte[numBytes];

            // Copy the RGB values into the array.
            Marshal.Copy(ptr, rgbValues, 0, numBytes);

            // Manipulate the bitmap
            for (int counter = 0; counter < rgbValues.Length; counter += 4)
            {
                if (rgbValues[counter] == inColourR &&
                    rgbValues[counter + 1] == inColourG &&
                    rgbValues[counter + 2] == inColourB)

                {
                    rgbValues[counter] = outColourR;
                    rgbValues[counter + 1] = outColourG;
                    rgbValues[counter + 2] = outColourB;
                }
            }

            // Copy the RGB values back to the bitmap
            Marshal.Copy(rgbValues, 0, ptr, numBytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);
        }
    }
}

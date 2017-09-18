using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiddenWordsLibrary;

namespace HiddenWordsLibrary
{
    class BMPHandle
    {
        // because i have a GIANT HARDON for MVC, we're using a class to encapsulate the bitmap class, and hopefully encoding shit. 
        // IDK what functions will go here instead of Functions.cs but HEYYYY hopefully this dices out right. 
        // if not ill just refractor till it is pretty. 
        // -- VAL


        // -- Fields -- //
        private Bitmap InternalImage;
        private string ThroughText = string.Empty;
        // -- end Fields -- //


        // -- Constructors -- //
        public BMPHandle()
        {
            InternalImage = null;
        }
        public BMPHandle(String Image)
        {
            //string because this tankes a FILENAME
            InternalImage = new Bitmap(Image);
        }
        public BMPHandle(Bitmap Image)
        {
            InternalImage = new Bitmap(Image);
        }
        public BMPHandle(String Image, String Text)
        {
            InternalImage = new Bitmap(Image);
            ThroughText = Text;
        }
        public BMPHandle(Bitmap Image, String Text)
        {
            InternalImage = new Bitmap(Image);
            ThroughText = Text;
        }
        // -- End Constructors -- //

        // -- Functions -- //
        public void BigFatEncoding()
        {

            // Lock the bits
            // made with help of MSDN!
            Rectangle rect = new Rectangle(0, 0, InternalImage.Width, InternalImage.Height);
            BitmapData bmpData = InternalImage.LockBits(rect, ImageLockMode.ReadWrite, InternalImage.PixelFormat);

            // get address of line 1
            IntPtr ptr = bmpData.Scan0;

            // byte array to hold bytes
            int bytes = Math.Abs(bmpData.Stride) * InternalImage.Height; // calculate size needed
            byte[] RGBValues = new byte[bytes]; // an array that can hold RGB values.

            // populate array so it now holds the RGB values for the entire bitmap
            System.Runtime.InteropServices.Marshal.Copy(ptr, RGBValues, 0, bytes);

            
            byte[] ASCIIValu = Encoding.ASCII.GetBytes(ThroughText); // populates an array  with the byte values, immediately throws elsewhere. 

            // Convert to bit arrays for #convience, keep the old ones around so we can throw them back properly. 
            BitArray bitColors = new BitArray(RGBValues);
            BitArray bitLetter = new BitArray(ASCIIValu);

            // the future plan is to make this a robust, Dynamic encoding system based on user input, 
            // manipulating designated bits with varying density to provide different results. 
            // for the sake of proof of concept, this is just going to manipulate the Least Significant Bit of the B value. Hopefully. 

            int RGBcounter = 23; // this value is the First Place we're shoving data. hopefully nothing dumb happens. 
            for (int i = 0; i < bitLetter.Count; i++)
            {
                // keeps track of what bit in bitLetter we are currently working on. 
                bitColors[RGBcounter] = bitLetter[i];
                RGBcounter += 24;
            }
            RGBValues = Functions.ConvertToByte(bitColors);

            // copy back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(RGBValues, 0, ptr, bytes);

            // unlock bits
            InternalImage.UnlockBits(bmpData);

            // draw image (this is rendering i think?)
            e.Graphics.DrawImage(bmp, 0, 150);

        }

        // -- End Functions -- //
    }
}

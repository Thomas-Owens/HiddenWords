using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenWordsLibrary
{
    public static class Functions
    {
        public static String StringToHex(string input)
        {
            // output will be seperated by hypens and in a string format until i have a better way to run this. 
            byte[] bytes = Encoding.ASCII.GetBytes(input); // populates an array  with the byte values
            string Output = BitConverter.ToString(bytes);
            return Output;
        }

        public static Byte[] ConvertToByte(BitArray bits)
        {
            // Modified from https://stackoverflow.com/questions/560123/convert-from-bitarray-to-byte, Thanks buddy!
            if (bits.Count % 8 != 0)
            {
                throw new ArgumentException("Improper Number of bits!");
            }
            byte[] bytes = new byte[bits.Count/8];
            bits.CopyTo(bytes, 0);  // in theory, this should fit smoothly. if not ill have to do some clunky itteration. Ugh. 
            return bytes;
        }

    }
}

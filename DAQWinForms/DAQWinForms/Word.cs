using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQWinForms
{
    public class Word
    {
        public static UInt16 FromByteArray(byte[] bytes)
        {
            return FromBytes(bytes[1], bytes[0]);
        }

        public static UInt16 FromBytes(byte LoVal, byte HiVal)
        {
            return System.Convert.ToUInt16(HiVal * 256 + LoVal);
        }


        public static byte[] ToByteArray(UInt16 value)
        {
            byte[] array1 = BitConverter.GetBytes(value);
            Array.Reverse(array1);
            return array1;
        }

        public static byte[] ToByteArray(UInt16[] value)
        {
            ByteArray arr = new ByteArray();
            foreach (UInt16 val in value)
                arr.Add(ToByteArray(val));
            return arr.array;
        }

        public static UInt16[] ToArray(byte[] bytes)
        {
            UInt16[] values = new UInt16[bytes.Length / 2 - 1 + 1];
            int counter = 0;
            for (int cnt = 0; cnt <= values.Length - 1; cnt += 2)
                values[cnt] = FromByteArray(new byte[] { bytes[cnt], bytes[cnt + 1] });
            return values;
        }

        public static UInt16[] ByteToUInt16(byte[] bytes)
        {
            UInt16[] values = new UInt16[bytes.Length / 2];
            int counter = 0;
            for (int cnt = 0; cnt < bytes.Length / 2; cnt++)
                values[cnt] = FromByteArray(new byte[] { bytes[counter++], bytes[counter++] });
            return values;
        }
    }
}

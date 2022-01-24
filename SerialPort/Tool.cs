using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPort
{
    class Tool
    {
        public static string bytesToHexStr(byte[] bytes)
        {
            string str = "";

            try {
                if (bytes != null) {
                    for (int i = 0; i < bytes.Length; i++) {
                        str += bytes[i].ToString("x2") + " ";
                    }
                }
            }
            catch (Exception) { throw; }

            return str;
        }

        public static string HexStrToByteStr(string hexStr)
        {
            string str = "";
            byte[] array = new byte[hexStr.Length / 3 + 1];

            try {
                if (!String.IsNullOrEmpty(hexStr)) {
                    for (int i = 0; i < array.Length; i++) {
                        array[i] = Convert.ToByte(hexStr.Substring(i * 3, 2), 16);
                    }
                    str = Encoding.Default.GetString(array);
                }
            }   
            catch (Exception) { throw; }

            return str;
        } 
    }
}

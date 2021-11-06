using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiProjectsWebRazor.Domain
{
    public class Encrypt
    {
        public string PlainText { get; set; }
        public string EncodingText { get; set; }
        public string DecodingText { get; set; }
        public int Key { get; set; }

        public bool EncText() {
            string result = "";
            foreach (char c in PlainText) {
                result += EncodeChar(c);
            }

            EncodingText = result;
            return true;
        }

        public bool DecText() {
            return false;
        }

        private char EncodeChar(char toEncode) {
            if (toEncode == ' ') {
                return ' ';
            }
            return (char)((int)toEncode+Key);
        }
    }
}

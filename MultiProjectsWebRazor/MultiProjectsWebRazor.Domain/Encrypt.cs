using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiProjectsWebRazor.Domain
{
    public class Encrypt
    {
        
        
        [Display(Name = "Tekst do zakodowania")]
        [Required(ErrorMessage = "Podaj Tekst")]
        [DataType(DataType.MultilineText)]
        public string PlainText { get; set; }
        public string EncodingText { get; set; }
        public string DecodingText { get; set; }

        [Display(Name = "Klucz kodowania")]
        [Required(ErrorMessage = "Musisz podać liczbę -20,20")]
        [Range(-20, 20, ErrorMessage = "Podaj liczbę z przedziału -20,20")]
        public int? Key { get; set; }

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

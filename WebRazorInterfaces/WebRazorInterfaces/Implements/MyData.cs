using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebRazorInterfaces.Abstraction;

namespace WebRazorInterfaces.Implements
{
    class MyData : DataAbstract
    {
        public override string GetName()
        {
            return "Implementacja pojemnika na dane: " + _name;
        }

        public MyData() {
            _name = "Domyślny cytat";
        }

        public MyData(string name) {
            _name = name;
        }
        public int GetLength() {
            return _name.Length;
        }

        public string ChangeName(bool isUpper = true) {
            return isUpper ? _name.ToUpper() : _name.ToLower();
        }
    }
}

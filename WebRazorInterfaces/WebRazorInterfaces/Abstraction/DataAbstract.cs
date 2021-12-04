using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebRazorInterfaces.Abstraction
{
    public abstract class DataAbstract {
        protected string _name;
        public abstract string GetName();
    }
}

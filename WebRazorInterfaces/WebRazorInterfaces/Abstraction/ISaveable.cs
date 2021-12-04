using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebRazorInterfaces.Abstraction
{
    interface ISaveable {
        void Save(IList<DataAbstract> data);
        IList<DataAbstract> Load();
    }
}

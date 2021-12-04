using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsy_Cw.Abstraction;

namespace Interfejsy_Cw.Implements
{
    class RamSave : ISaveable
    {
        public IList<DataAbstract> Load()
        {
            throw new NotImplementedException();
        }

        public void Save(IList<DataAbstract> data)
        {
            throw new NotImplementedException();
        }
    }
}

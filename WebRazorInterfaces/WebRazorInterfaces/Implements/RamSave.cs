using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebRazorInterfaces.Abstraction;

namespace WebRazorInterfaces.Implements
{
    class RamSave : ISaveable
    {
        public IList<DataAbstract> Load()
        {
            Console.WriteLine("Załadowanie z RAM-u..");
            return new List<DataAbstract> {
                new MyData("Cytat 1"), new MyData(), new MyData("Cytat2"),new MyData("Cytat inny")
                ,new MyData("Jeszcze lepszy cytat")
            };
        }

        public void Save(IList<DataAbstract> data)
        {
            Console.WriteLine("Zapisane do RAM-u..");
        }
    }
}

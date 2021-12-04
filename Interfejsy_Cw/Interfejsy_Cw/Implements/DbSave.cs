using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsy_Cw.Abstraction;

namespace Interfejsy_Cw.Implements
{
    class DbSave : ISaveable
    {
        public IList<DataAbstract> Load()
        {
            Console.WriteLine("Załadowanie z bazy danych...");
            return new List<DataAbstract> {
                new MyData("dane1"), new MyData(), new MyData("dane2"),new MyData("ggggg")
            };
        }

        public void Save(IList<DataAbstract> data)
        {
            Console.WriteLine("Zapisane do bazy danych...");
        }
    }
}

using System;
using System.Collections.Generic;
using Interfejsy_Cw.Abstraction;
using Interfejsy_Cw.Implements;

namespace Interfejsy_Cw
{
    class Program
    {
        static void Main(string[] args) {
            ISaveable myFileSave = new DbSave();
            IList<DataAbstract> dane = myFileSave.Load();
            foreach (var d in dane) {
                Console.WriteLine(d.GetName());
                Console.WriteLine((d as MyData)?.GetLength());
                Console.WriteLine((d as MyData)?.ChangeName(false));
                Console.WriteLine((d as MyData)?.ChangeName());
            }
        }
    }
}

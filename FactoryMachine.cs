using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_oop
{
    internal class FactoryMachine : Engine, ICreate
    {
        public FactoryMachine(string name, float power, string serialNumber) : base(name, power, serialNumber)
        {
        }

        public void Create(Detail detail)
        {
            Console.WriteLine($"Running Factory Machine. The process of creating {detail} is running//");
        }
    }
}

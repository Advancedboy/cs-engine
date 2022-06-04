using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_oop
{
    internal class CarEngine : Engine, IMove
    {
        public CarEngine(string name, float power, string serialNumber) : base(name, power, serialNumber)
        {
        }
        public void Move()
        {
            Console.WriteLine("Running Engine. In motion//");   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_oop
{
    internal class Engine
    {
        public string Name { get; private set; }
        public float Power { get; private set; }
        public string SerialNumber { get; private set; }
        public Engine(string name, float power, string serialNumber)
        {
            Name = name;
            Power = power;
            SerialNumber = serialNumber;
        }

        public override string ToString()
        {
            return $"Name: {Name}.\n" +
                $"Power: {Power}.\t" +
                $"SerialNumber: {SerialNumber}.\n";
        
        }
    }
}

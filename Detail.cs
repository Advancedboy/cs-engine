using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_oop
{
    internal class Detail
    {
        public string Name { get; private set; }
        public string SerialNumber { get; private set; }
        public bool IsGear { get; private set; }
        public Detail(string name, string serialNumber, bool isGear)
        {
            Name = name;
            SerialNumber = serialNumber;
            IsGear = isGear;
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Serial Number: {SerialNumber}\n" +
                $"Is Gear: {IsGear}.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarEngine carEngine = new CarEngine("V8", 550.23f, "128XYZ256");
            Console.WriteLine(carEngine);

            Detail detailGear = new Detail("Gear DIM-1.1mm", "DDDD888213", true);

            FactoryMachine factoryMachine = new FactoryMachine("FFt-98", 213.1f, "QWWWW235");
            factoryMachine.Create(detailGear);
            Console.WriteLine("====================");
            Console.WriteLine(detailGear);

            Console.ReadLine();
        }
    }
}

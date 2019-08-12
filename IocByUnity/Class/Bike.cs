using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IocByUnity.Interface;

namespace IocByUnity.Class
{
    class Bike : ITwoWheeler
    {
        public void Accelarate()
        {
            Console.WriteLine("Bike Accelarated");
        }

        public void Brake()
        {
            Console.WriteLine("Brake is applied in Bike");
        }

        public void Clutch()
        {
            Console.WriteLine("Clutch is applied in Bike");
        }

        public void Gears()
        {
            Console.WriteLine("Gear is Changed in Bike");
        }
    }
}

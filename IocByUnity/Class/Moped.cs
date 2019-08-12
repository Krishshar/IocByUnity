using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IocByUnity.Interface;

namespace IocByUnity.Class
{
    public class Moped : ITwoWheeler
    {
        public void Accelarate()
        {
            Console.WriteLine("Bike Accelarated");
        }

        public void Brake()
        {
            Console.WriteLine("Brake is applied in Moped");
        }

        public void Clutch()
        {
            //Leave it Because Moped has no clutch
        }

        public void Gears()
        {
            //Leave it Because Moped has no Gears
        }
    }
}

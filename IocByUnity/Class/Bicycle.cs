using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IocByUnity.Interface;

namespace IocByUnity.Class
{
    public class Bicycle : ITwoWheeler
    {
        public void Accelarate()
        {
            Console.WriteLine("Bicycle Pedaled");
        }

        public void Brake()
        {
            Console.WriteLine("Brake is applied in Bicycle");
        }

        public void Clutch()
        {
            //Leave it Because Bicycle has no clutch
        }

        public void Gears()
        {
            //Leave it Because Bicycle has no Gears
        }
    }
}

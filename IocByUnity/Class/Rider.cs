using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IocByUnity.Interface;
using Unity;

namespace IocByUnity.Class
{
    public class Rider 
    {
        private ITwoWheeler _twoWheeler = null;

        public Rider(ITwoWheeler twoWheeler)
        {
            this._twoWheeler = twoWheeler;
        }

        public void RideTwoWheeler()
        {
            _twoWheeler.Clutch();
            _twoWheeler.Gears();
            _twoWheeler.Accelarate();
            _twoWheeler.Brake();
        }
    }
}

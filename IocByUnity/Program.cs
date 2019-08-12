using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using IocByUnity.Class;
using IocByUnity.Interface;

namespace IocByUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unityContainer = new UnityContainer();

            //Bike
            unityContainer.RegisterType<ITwoWheeler,Bike>();

            //Moped
            //unityContainer.RegisterType<ITwoWheeler,Moped>();

            //Bicycle
            //unityContainer.RegisterType<ITwoWheeler,Bicycle>();

            Rider rider = unityContainer.Resolve<Rider>();
            rider.RideTwoWheeler();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Laboratorio_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Calle Antezana");
            list.Add("San Martin");
            list.Add("Ayacucho y Heroinas");
            Client clientCar = new Client(new CarRoute());
            clientCar.Route(list);
            Client clientBike = new Client(new BikeRoute());
            clientBike.Route(list);
            Client clientWalk = new Client(new WalkRoute());
            clientWalk.Route(list);
        }
    }
}

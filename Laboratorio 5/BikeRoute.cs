using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    public class BikeRoute : IRouteStrategy
    {
        public string Route(List<string> listRoute)
        {
            string bestRoute = "";
            for (int i = 0; i < listRoute.Count; i++)
            {
                if (listRoute[i] == "Calle Antezana")
                {
                    bestRoute = listRoute[i];
                    ShowChooseRoute(bestRoute);
                }
            }
            return bestRoute;
        }

        public void ShowChooseRoute(string route)
        {
            Console.WriteLine("La mejor opcion para ir por la ruta " + route + " es en bicicleta");
        }
    }
}

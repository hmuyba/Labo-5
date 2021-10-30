using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    public class WalkRoute : IRouteStrategy
    {
        public string Route(List<string> listRoute)
        {
            string bestRoute = "";
            for (int i = 0; i < listRoute.Count; i++)
            {
                if (listRoute[i] == "San Martin")
                {
                    bestRoute = listRoute[i];
                    ShowChooseRoute(bestRoute);
                }
            }
            return bestRoute;
        }

        public void ShowChooseRoute(string route)
        {
            Console.WriteLine("La mejor opcion para ir por la ruta " + route + " es caminando");
        }
    }
}

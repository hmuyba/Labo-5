using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    public class Client
    {
        IRouteStrategy routeStrategy;
        public Client(IRouteStrategy routeStrategy)
        {
            this.routeStrategy = routeStrategy;
        }
        public void Route(List<string> list)
        {
            routeStrategy.Route(list);
        }
    }
}

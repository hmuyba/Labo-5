using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5
{
    public interface IRouteStrategy
    {
        string Route(List<string> listRoute);
        void ShowChooseRoute(string route);
    }
}

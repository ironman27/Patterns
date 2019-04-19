using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.RemoteProxies
{
    interface IBook:IDisposable
    {
        Page GetPage(int number);
    }
}

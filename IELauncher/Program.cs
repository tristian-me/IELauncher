using IELauncher.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IELauncher
{
    internal class Program
    {
        static int Main(string[] args)
        {
            var url = "about:blank";
            if (args.Length > 0) {
                url = args[0];
            }

            (new Launcher()).LaunchIE(url);
            return 0;
        }
    }
}

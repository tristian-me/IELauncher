using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IELauncher.App
{
    class Launcher
    {
        public void LaunchIE(string url)
        {
            ShowIE(url);
        }

        private int ShowIE(string url)
        {
            SHDocVw.InternetExplorer IE = new SHDocVw.InternetExplorer()
            {
                Visible = true,

            };

            IE.Navigate2(url, 0);

            return 0;
        }
    }
}
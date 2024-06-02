using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new SifreDegistirme());
            //Application.Run(new MeyveSebzePanel());
            //Application.Run(new SutUrunlerPanel());
            //Application.Run(new BaklagilPanel());
        }

    }
}

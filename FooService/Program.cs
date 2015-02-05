using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooService
{
    class Program
    {
        static void Main(string[] args)
        {
            StartServer();
        }

        static void StartServer()
        {
            const int portNumber = 9999;

            string baseUrl = string.Format("http://localhost:{0}", portNumber);
            WebApp.Start<Startup>(baseUrl);

            Console.WriteLine("Host Started at {0}", baseUrl);
            WaitForKey();
        }

        static void WaitForKey()
        {
            Console.WriteLine("Hit a key to continue...");
            Console.ReadKey();
        }
    }
}

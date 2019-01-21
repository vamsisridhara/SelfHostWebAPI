using Microsoft.Owin.Hosting;
using SelfHostWebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace SelfHostWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SelfHostServiceBase()
            };
            ServiceBase.Run(ServicesToRun);

            //HostFactory.Run(x =>
            //{
            //    x.Service<ServiceAPI>(p =>
            //    {
            //        p.ConstructUsing(name => new ServiceAPI());
            //        p.WhenStarted(tc => tc.Start());
            //        p.WhenStopped(tc => tc.Stop());
            //    });
            //    x.RunAsLocalSystem();
            //    x.SetDescription("Sample SelfHostWebAPI Topshelf Host");
            //    x.SetDisplayName("SelfHostWebAPI");
            //    x.SetServiceName("SelfHostWebAPI");
            //});

            //using (WebApp.Start<StartUp>("http://localhost:9000"))
            //{
            //    Console.WriteLine("Web Server is running.");
            //    Console.WriteLine("Press any key to quit.");
            //    Console.ReadLine();
            //}

        }
    }
}

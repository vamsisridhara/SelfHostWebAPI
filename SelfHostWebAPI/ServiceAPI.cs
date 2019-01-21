using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostWebAPI
{
    public class ServiceAPI
    {
        IDisposable webServer;
        string baseAddress = "http://localhost:9000/";
        public ServiceAPI()
        {
        }
        public void Start()
        {
            this.webServer = WebApp.Start<StartUp>(url: baseAddress);
        }

        public void Stop()
        {
            this.webServer.Dispose();
        }

    }
}

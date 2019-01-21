using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostWebAPI
{
    public partial class SelfHostServiceBase : ServiceBase
    {
        private IDisposable _webapp;

        public SelfHostServiceBase()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _webapp = WebApp.Start<StartUp>("http://localhost:9000");
        }

        protected override void OnStop()
        {
            _webapp?.Dispose();
        }

        private void InitializeComponent()
        {
            // 
            // SelfHostServiceBase
            // 
            this.ServiceName = "SelfHostServiceBase";

        }
    }
}

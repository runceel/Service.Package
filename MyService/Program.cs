using System.IO;
using System.ServiceProcess;

namespace MyService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase.Run(new MyService());
        }
    }

    class MyService : ServiceBase
    {
        protected override void OnStart(string[] args)
        {
            using (var sw = new StreamWriter("c:\\temp\\myservice.log", true))
            {
                sw.WriteLine("OnStart");
            }
            base.OnStart(args);
        }

        protected override void OnStop()
        {
            using (var sw = new StreamWriter("c:\\temp\\myservice.log", true))
            {
                sw.WriteLine("OnStop");
            }
            base.OnStop();
        }
    }
}

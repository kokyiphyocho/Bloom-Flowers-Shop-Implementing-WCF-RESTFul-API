using BloomWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BloomServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {                        
            using (ServiceHost host = new ServiceHost(typeof(BloomWCFService.DataService)))
            {
                host.Open();
                Console.WriteLine("Service Started..");
                Console.ReadLine();
            }
        }
    }
}

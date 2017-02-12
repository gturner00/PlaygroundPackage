using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatsdClient; 

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            StatsdClient.StatsdConfig config = new StatsdClient.StatsdConfig()
            {
                Prefix = "Playground",
                StatsdPort = 8125,
                StatsdServerName = "127.0.0.1"
            };
            StatsdClient.DogStatsd.Configure(config);

            //StackifyLib.Logger.GlobalApiKey = "3Gz8Sh1Do9Yl3Uo0Mx6Zq4Wa2Oo9Qa3Wl6Ud0Ly";
            for (int i = 0; i < 1000; i++)
            {
                DogStatsd.Counter<int>("Run Count", 1);
                using (DogStatsd.StartTimer("Run Time"))
                {
                    Random random = new Random();

                    System.Threading.Thread.Sleep(random.Next(0, 60) * 100);
                }
                Console.WriteLine(string.Format("Metric Count {0}", i));

            }
        }
    }
}

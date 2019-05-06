﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Singleton
{
    public static class Singleton
    {
        public static void Execute()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            var b = LoadBalancer.GetLoadBalancer();
            if (b1 == b2 && b2 == b3 && b3 == b4)
                Console.WriteLine("Same instance\n");
            for(int i =0;i<15;i++)
            {
                var serverName = b.NextServer.Name;
                Console.Write("Dispatch request to: " + serverName);
                Console.WriteLine(" | DateTime ticks: " + b.GetDateTime);
            }
            Console.ReadKey();
        }
    }
}

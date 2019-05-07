using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Singleton
{
    public class LoadBalancer
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly LoadBalancer _loadBalancer = new LoadBalancer();

        private List<Server> _servers;
        private Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                 new Server{ Name = "ServerI", IP = "120.14.220.18" },
                 new Server{ Name = "ServerII", IP = "120.14.220.19" },
                 new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                 new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                 new Server{ Name = "ServerV", IP = "120.14.220.22" },
            };
            GetDateTime = DateTime.Now.Ticks.ToString();
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return _loadBalancer;
        }

        public Server NextServer
        {
            get
            {
                int index = _random.Next(_servers.Count);
                return _servers[index];
            }
        }

        public string GetDateTime { get; }

    }

    public class LoadBalancerLock
    {
        private static LoadBalancerLock _loadBalancerLock;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        private static object syncLock = new object();

        public string GetDateTime { get; }

        protected LoadBalancerLock()
        {
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
            GetDateTime = DateTime.Now.Ticks.ToString();
        }

        public static LoadBalancerLock GetLoadBalancerLock()
        {
            if(_loadBalancerLock == null)
            {
                lock(syncLock)
                {
                    if(_loadBalancerLock == null)
                    {
                        _loadBalancerLock = new LoadBalancerLock();
                    }
                }
            }
            return _loadBalancerLock;
        }

        public string Server
        {
            get

            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }

    }

}

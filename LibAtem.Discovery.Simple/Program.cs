using System;

namespace LibAtem.Discovery.Simple
{

    class Program
    {
        static void Main(string[] args)
        {
            var discovery = new AtemDiscoveryService(10000, true);
            discovery.OnDeviceSeen += (s, d) =>
            {
                Console.WriteLine("Seen: " + d.ToString());
            };
            discovery.OnDeviceLost += (s, d) =>
            {
                Console.WriteLine("Lost: " + d.ToString());
            };

            Console.Read();
        }
    }
}

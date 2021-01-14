using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAKSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to AKS Learning \n DateTime: {DateTime.Now.ToString()} \n Host Name: {System.Net.Dns.GetHostName()}");
        }
    }
}

using System;
using System.Threading.Tasks;

namespace BranchingApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Hello World! version 1.3");

            await Task.Delay(100);
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;

namespace AOC
{
    class Program
    {
        static async Task Main(string[] args)
        {

            const string basePath = @"C:\Users\havar\Home\AOC2020\input";

            await One.Solve(basePath + @"\1.txt");
            await Two.Solve(basePath + @"\2.txt");
            await Three.Solve(basePath + @"\3.txt");
        }
    }
}

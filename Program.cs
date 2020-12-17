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
            await Four.Solve(basePath + @"\4.txt");
            await Five.Solve(basePath + @"\5.txt");
            await Six.Solve(basePath + @"\6.txt");
            await Seven.Solve(basePath + @"\7.txt");
        }
    }
}

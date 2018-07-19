using System;
using NetCoreLibrary;

namespace HelloCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lib lib = new Lib();
            Console.WriteLine(lib.RtnOK());
        }
    }
}

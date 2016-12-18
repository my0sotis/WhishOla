using System;
using DbGenerate.Fashion;
using CreateDictionary.Memory;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MemoryInfor.InitMemory();
            var m=MemoryInfor.GetAllProducts();
            Console.WriteLine("Hello World!");
        }
    }
}

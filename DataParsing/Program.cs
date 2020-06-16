using System;

namespace DataParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call Started");

            ZipAndUnzip zipAndUnzip = new ZipAndUnzip();
            zipAndUnzip.Zip();


        }
    }
}

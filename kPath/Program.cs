using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kPath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite ime: ");
            string ime = Console.ReadLine();
            Console.Write("Upišite prezime: ");
            string prezime = Console.ReadLine();

            StreamWriter sw = new StreamWriter(@"C:\TestFile\mojaDatoteka.txt");
            sw.WriteLine("Ime: {0}", ime);
            sw.WriteLine("Prezime: {0}", prezime);
            sw.Close();

            StreamReader sr = new StreamReader(@"C:\TestFile\mojaDatoteka.txt");
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            Console.ReadKey();
        }
    }
}

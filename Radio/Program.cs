using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio r = new Radio();
            r.Volume = 100;

            r.AumentaVolume();
            Console.WriteLine(r.Volume);

            r.Volume = 100;

            r.DiminuisciVolume();
            Console.WriteLine(r.Volume);

            Console.ReadLine();
        }
    }
}

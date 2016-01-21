using FinchAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Finch_LightAndSound
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // declare the Finch variable and create (instantiate) a new Finch object
            //
            Finch myFinch;
            myFinch = new Finch();

            //
            // connect to the Finch robot
            //
            myFinch.connect();

            //
            // pause the console window before exiting
            //
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            //
            // disconnect from the Finch robot
            //
            myFinch.disConnect();
        }
    }
}

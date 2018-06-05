using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseShip // program class
{
    class Program
    {
        static void Main(string[] args)
        {
            CruiseLine seamus = new CruiseLine();

            Console.WriteLine("What is your bestfriends age?");
            seamus.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("You have picked {0} cruise line", seamus.GetCruise());
        }
    }
}

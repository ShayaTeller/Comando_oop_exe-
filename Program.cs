using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando_oop_exe_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando1 = new Commando("shay","dad");
            AirCommando air1 = new AirCommando("gal", "cat");
            SeaCommando sea1 = new SeaCommando("piter", "nana");

            Commando[] commanders = { commando1, air1, sea1 };
            foreach (var commander in commanders)
            {
                commander.Attack();
            }
         
         












        }
    }
}

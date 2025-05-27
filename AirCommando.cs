using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando_oop_exe_
{
    internal class AirCommando:Commando
    {
        public  string CommandoType = "AirCommando";

        public AirCommando(string name, string codename):base(name,codename)
        {
        }
        public void Parachuting()
        {
            Console.WriteLine("the commando is Parachuting now!");

        }
        public override void Attack()
        {
            string CommandoType = "airComando";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The {CommandoType} , {CodeName} attacking now! ");
            Console.ResetColor();

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando_oop_exe_
{
    internal class SeaCommando:Commando 
    {
        public SeaCommando(string name, string codename):base(name, codename)
        {
              
        }
        public void Swimming()
        {
            Console.WriteLine("the commando is swimming now!");
        }
        public override void Attack()
        {
            string CommandoType = "SeaCommando";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The {CommandoType}, {CodeName} attacking now! ");
            Console.ResetColor();

        }
    }
}

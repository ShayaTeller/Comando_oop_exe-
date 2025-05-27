using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando_oop_exe_
{




    internal class Commando
    {
        private string Name;
        public  string CodeName { set; get; }
        public  string[] Tools = { "Hammer", "chisel", "rope", "bag", "water bottle" };
        public string Status;

        public Commando(string name,string codename)
        {
            Name = name;
            CodeName = codename;
            
            


        }
        
         public void Walk()
        {
            Console.WriteLine("The commando is Walk ");
            Status = "walk";
              
        }
        public  void Hide()
        {
            Console.WriteLine("The commando is Hide ");
            Status = "hide";
            Console.ResetColor();
        }

         public virtual void Attack()
        {
            string CommandoType = "Pedestrian Commando";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The {CommandoType} , {CodeName} attacking now! ");
            Console.ResetColor();

        }
        public  void SayName(string commanderRank)
        {
            if (commanderRank.ToUpper() == "GENERAL")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Name}\n");
                Console.ResetColor();

            }
             else if (commanderRank.ToUpper() == "COLONEL")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{CodeName}\n");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The information you requested is classified");
                Console.ResetColor();

            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando_oop_exe_
{

    internal class Weapon
    {
        public  string Name;
        public  string Producer;
        public  int WeaponQuantity =0;

    public Weapon(string name,string producer, int quantity)
        {
            Name = name;
            Producer = producer;
            WeaponQuantity = quantity;
        }
         public void Shoot()
        {
            if (WeaponQuantity != 0)
            {
                Console.WriteLine("shooting now!");
                WeaponQuantity -= 1;
            }
            else
            {
                Console.WriteLine("You need to load the weapon");
            }

        }
        public void LoadWeapon(int amount)
        {
            WeaponQuantity += amount;
            Console.WriteLine($"you have now in the WeaponQuantity : {WeaponQuantity} shoots!");

        }
    }
    
    
}

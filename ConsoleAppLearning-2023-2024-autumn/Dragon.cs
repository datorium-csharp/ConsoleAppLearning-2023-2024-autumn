using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning_2023_2024_autumn
{
    internal class Dragon
    {
        public string name;
        public int age;
        public int energy;
        public int health;

        public void Talk()
        {
            Console.WriteLine($"{name} is talking");
        }

        public void Attack(Wizard wizard)
        {
            Console.WriteLine($"{this.name} is attacking {wizard.name}.");
            wizard.health -= 40;
            if(wizard.health <= 0)
            {
                wizard.active = false;
            }
        }
    }
}

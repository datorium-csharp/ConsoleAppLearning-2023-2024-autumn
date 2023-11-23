using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning_2023_2024_autumn
{
    internal class Wizard
    {
        public string name;
        public int age;
        public int energy;
        public int health;
        public bool active = true;

        public void Talk()
        {
            if (this.active)
            {
                Console.WriteLine($"{name} is talking");
            }
            else
            {
                Console.WriteLine($"{name} is out of game :/");
            }            
        }

        public void Heal(Wizard wizard)
        {
            if(this.energy < 100)
            {
                Console.WriteLine($"{this.name} cannot heal, low energy.");
            }
            else
            {
                Console.WriteLine($"{this.name} is healing {wizard.name}.");
                wizard.health = 100;
                wizard.active = true;
                this.energy -= 100;
            }            
        }

        public void Status()
        {
            if (this.active)
            {
                var status = $"Name: {this.name}, Health: {this.health}, Energy: {this.energy}";
                Console.WriteLine(status);
            }
            else
            {
                Console.WriteLine($"{name} is out of game :/");
            }            
        }
    }
}

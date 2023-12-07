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
        public string _name;
        public int _age;
        public int _energy;
        public int _health;
        public bool _active = true;

        //CONSTRUCTOR
        public Wizard(string name, int age)
        {
            _name = name;
            _age = age;
            _energy = 100;
            _health = 100;
            _active = true;
        }

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

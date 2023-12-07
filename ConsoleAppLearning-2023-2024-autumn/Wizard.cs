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
            if (this._active)
            {
                Console.WriteLine($"{_name} is talking");
            }
            else
            {
                Console.WriteLine($"{_name} is out of game :/");
            }            
        }

        public void Heal(Wizard wizard)
        {
            if(this._energy < 100)
            {
                Console.WriteLine($"{this._name} cannot heal, low energy.");
            }
            else
            {
                Console.WriteLine($"{this._name} is healing {wizard._name}.");
                wizard._health = 100;
                wizard._active = true;
                this._energy -= 100;
            }            
        }

        public void Status()
        {
            if (this._active)
            {
                var status = $"Name: {this._name}, Health: {this._health}, Energy: {this._energy}";
                Console.WriteLine(status);
            }
            else
            {
                Console.WriteLine($"{_name} is out of game :/");
            }            
        }
    }
}

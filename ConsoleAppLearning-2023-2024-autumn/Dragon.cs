using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning_2023_2024_autumn
{
    internal class Dragon
    {
        public string _name;
        public int _age;
        public int _energy;
        public int _health;

        //CONSTRUCTOR
        public Dragon(string name, int age)
        {
            _name = name;
            _age = age;
            _energy = 100;
            _health = 100;
        }

        public void Talk()
        {
            Console.WriteLine($"{_name} is talking");
        }

        public void Attack(Wizard wizard)
        {
            Console.WriteLine($"{this._name} is attacking {wizard._name}.");
            wizard._health -= 40;
            if(wizard._health <= 0)
            {
                wizard._active = false;
            }
        }
    }
}

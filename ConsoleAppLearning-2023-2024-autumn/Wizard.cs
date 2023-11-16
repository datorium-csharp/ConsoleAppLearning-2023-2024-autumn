using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning_2023_2024_autumn
{
    internal class Wizard
    {
        string name;
        int age;
        int energy;
        int health;

        void Talk()
        {
            Console.WriteLine($"{name} is talking");
        }

        void Heal()
        {
            Console.WriteLine($"{name} is healing.");
        }
    }
}

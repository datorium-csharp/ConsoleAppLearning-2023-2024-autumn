// See https://aka.ms/new-console-template for more information
using ConsoleAppLearning_2023_2024_autumn;
using System.ComponentModel;


var wiz1 = new Wizard("Gandalf", 200);
var wiz2 = new Wizard("Damledore", 105);
var drag1 = new Dragon("Smaug", 5000);

drag1.Talk();
drag1.Attack(wiz2);

wiz2.Status();

drag1.Attack(wiz2);
drag1.Attack(wiz2);

wiz1.Heal(wiz2);

wiz2.Status();
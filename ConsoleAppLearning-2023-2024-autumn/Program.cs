// See https://aka.ms/new-console-template for more information
using ConsoleAppLearning_2023_2024_autumn;
using System.ComponentModel;

var wiz1 = new Wizard();
var wiz2 = new Wizard();

wiz1.name = "Gendalf";
wiz1.age = 200;
wiz1.health = 100;
wiz1.energy = 500;

wiz2.name = "Dubledorf";
wiz2.age = 105;
wiz2.health = 100;
wiz2.energy = 100;

wiz1.Talk();
wiz1.Heal();

wiz2.Talk();
wiz2.Heal();

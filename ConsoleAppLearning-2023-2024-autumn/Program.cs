﻿// See https://aka.ms/new-console-template for more information
using ConsoleAppLearning_2023_2024_autumn;
using System.ComponentModel;

var wiz1 = new Wizard
{
    name = "Gandalf",
    age = 200,
    health = 100,
    energy = 500
};

var wiz2 = new Wizard
{
    name = "Dumbledore",
    age = 105,
    health = 100,
    energy = 100
};

var drag1 = new Dragon
{
    name = "Smaug",
    age = 5000,
    health = 100,
    energy = 100
};

drag1.Talk();
drag1.Attack(wiz2);

wiz2.Status();

drag1.Attack(wiz2);
drag1.Attack(wiz2);

wiz1.Heal(wiz2);

wiz2.Status();
// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("I start learning functions and variables today.");

int MultiplyTwoNumbers(int num1, int num2)
{
    return num1 * num2;
}

Console.WriteLine(MultiplyTwoNumbers(5, 4));

string SayHello()
{
    return "Hey hey!";
}

Console.WriteLine(SayHello());


void SendEmail(string address)
{
    // Procedure for sending an email
    Console.WriteLine($"E-mail to {address} is sent.");
}

SendEmail("customer@someemail.com");
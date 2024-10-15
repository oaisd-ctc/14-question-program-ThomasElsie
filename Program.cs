using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What's your name?");
        string name= Console.ReadLine();
        Console.WriteLine("What is your age?");
        string age= Console.ReadLine();
        Console.WriteLine("What is your eye color?");
        string eye= Console.ReadLine();
        Console.WriteLine("What's your hair color?");
        string hair= Console.ReadLine();
        Console.WriteLine("What is your shoe size?");
        string shoe= Console.ReadLine();
        Console.WriteLine("What's your favorite color?");
        string color= Console.ReadLine();
        Console.WriteLine("What is your favorite tv show or movie?");
        string movie= Console.ReadLine();
        Console.WriteLine("Who is your favorite teacher?");
        string teacher= Console.ReadLine();
        Console.WriteLine("What's your favorite class?");
        string clas= Console.ReadLine();
        Console.WriteLine("What is your favorite holiday?");
        string holiday= Console.ReadLine();
        Console.WriteLine("What's your favorite season?");
        string season= Console.ReadLine();
        Console.WriteLine("What's your dream job?");
        string job= Console.ReadLine();
        int number = int.Parse(age);
        Console.WriteLine("How many siblings do you have?");
        string siblings= Console.ReadLine();
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + " has " + eye + " eyes. " + name + " has " + hair + " hair. "
         + name + " has a shoe size of " + shoe + ". " + name + "'s favorite color is " + color + ". " + name + "'s favorite movie is " + movie + ". " + name + "'s favorite teacher is "
          + teacher + ". " + name + "'s favorite class is " + clas + ". " + name + "'s favorite holiday is " + holiday + ". " + name + "'s prefered season is " + season + ". "
           + name + "'s dream job is to be an " + job + ". " + name + "'s has a total number of " + siblings + " siblings. " + name + " will be " + (number + 5) + " years old in 5 years.");
    }
}
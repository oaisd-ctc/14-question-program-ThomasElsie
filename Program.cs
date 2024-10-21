using System;

public class Program
{
    public static string name;
    public static string age;
    public static string eye;
    public static string hair;
    public static string shoe;
    public static int shoes;
    public static string color;
    public static string movie;
    public static string teacher;
    public static string clas;
    public static string holiday;
    public static string season;
    public static string job;
    public static string siblings;
    public static int ageIn5Years;
    public static string message;
    public static void Main(string[] args)
    {
        Name();
        Age();
        Eye();
        Hair();
        Shoe();
        Color();
        Movie();
        Teacher();
        Clas();
        Holiday();
        Season();
        Job();
        AgeIn5Years();
        Siblings();
        Message();
    }
    public static void Name()
    {
        Console.WriteLine("What's your name?");
        name= Console.ReadLine();
    }
    public static void Age()
    {
        Console.WriteLine("What is your age?");
        age= Console.ReadLine();
    }
    public static void Eye()
    {
        Console.WriteLine("What is your eye color?");
        eye= Console.ReadLine();
    }
    public static void Hair()
    {
        Console.WriteLine("What's your hair color?");
        hair= Console.ReadLine();
    }
    public static void Shoe()
    {
        Console.WriteLine("What is your shoe size?");
        int shoes = int.Parse(Console.ReadLine());
    }
    public static void Color()
    {
        Console.WriteLine("What's your favorite color?");
        color= Console.ReadLine();
    }
    public static void Movie()
    {
        Console.WriteLine("What is your favorite tv show or movie?");
        movie= Console.ReadLine();
    }
    public static void Teacher()
    {
        Console.WriteLine("Who is your favorite teacher?");
        teacher= Console.ReadLine();
    }
    public static void Clas()
    {
        Console.WriteLine("What's your favorite class?");
        clas= Console.ReadLine();
    }
    public static void Holiday()
    {
        Console.WriteLine("What is your favorite holiday?");
        holiday= Console.ReadLine();
    }
    public static void Season()
    {
        Console.WriteLine("What's your favorite season?");
        season= Console.ReadLine();
    }
    public static void Job()
    {
        Console.WriteLine("What's your dream job?");
        job= Console.ReadLine();
    }
    public static void AgeIn5Years()
    {
        int number = int.Parse(age);
        ageIn5Years = number + 5;
    }
    public static void Siblings()
    {
        Console.WriteLine("How many siblings do you have?");
        siblings= Console.ReadLine();
    }
    public static void Message()
    {
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + " has " + eye + " eyes. " + name + " has " + hair + " hair. "
         + name + " has a shoe size of " + shoes + ". " + name + "'s favorite color is " + color + ". " + name + "'s favorite movie is " + movie + ". " + name + "'s favorite teacher is "
          + teacher + ". " + name + "'s favorite class is " + clas + ". " + name + "'s favorite holiday is " + holiday + ". " + name + "'s prefered season is " + season + ". "
           + name + "'s dream job is to be an " + job + ". " + name + "'s has a total number of " + siblings + " siblings. " + name + " will be " + ageIn5Years + " years old in 5 years.");
    }
}
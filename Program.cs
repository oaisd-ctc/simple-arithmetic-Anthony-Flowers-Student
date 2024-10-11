using System;


public class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine ("type add, subtract, multiply, or divide. (no capitals)");
       string operation = Console.ReadLine();
    //    I had to look up basic if statement syntax, other than that it was just previous knowledge.
       if (operation == "add") 
       {
            Console.WriteLine("Addition selected, what's the first number?");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is " + firstNum + ". What is your second number?");
            float secondNum = float.Parse(Console.ReadLine());
            float finalNum = secondNum + firstNum;
            Console.WriteLine("Your equation is " + firstNum + " + " + secondNum + ". Which equals to " + finalNum);
       }
        else if (operation == "subtract")
         {
            Console.WriteLine("Subtraction selected, what's the first number?");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is " + firstNum + ". What is your second number?");
            float secondNum = float.Parse(Console.ReadLine());
            float finalNum = firstNum - secondNum;
            Console.WriteLine("Your equation is " + firstNum + " - " + secondNum + ". Which equals to " + finalNum);
        }
        else if (operation == "multiply")
         {
            Console.WriteLine("Multiplication selected, what's the first number?");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is " + firstNum + ". What is your second number?");
            float secondNum = float.Parse(Console.ReadLine());
            float finalNum = secondNum * firstNum;
            Console.WriteLine("Your equation is " + firstNum + " * " + secondNum + ". Which equals to " + finalNum);
        }
        else if (operation == "divide") 
        {
            Console.WriteLine("Division selected, what's the first number?");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is " + firstNum + ". What is your second number?");
            float secondNum = float.Parse(Console.ReadLine());
            float finalNum = firstNum / secondNum;
            Console.WriteLine("Your equation is " + firstNum + " / " + secondNum + ". Which equals to " + finalNum);
        }
        else 
        {
            Console.WriteLine("Invalid input detected, restart program");
        }
    }
}

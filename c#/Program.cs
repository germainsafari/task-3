// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");

//Console.WriteLine("enter the username");

//string userName = Console.ReadLine();

//Console.WriteLine("your name is :" + userName);

//switch (int day = 2) {
//    case 1:
//    Console.WriteLine("Monday");

//    case 2:
//    Console.WriteLine("Tuesday");
//}
do
{
    Console.WriteLine("-------------------");
    Console.WriteLine("Calculator");
    Console.WriteLine("-------------------");

    Console.WriteLine("enter the first number");
    string input1 = Console.ReadLine();
    double num1 = Convert.ToDouble(input1);
    Console.WriteLine("the first number is : " + num1);

    Console.WriteLine("enter the second number");
    string input2 = Console.ReadLine();
    double num2 = Convert.ToDouble(input2);
    Console.WriteLine("the second number is : " + num2);

    Console.WriteLine("enter a sign:");
    Console.WriteLine("\t +");
    Console.WriteLine("\t -");
    Console.WriteLine("\t *");
    Console.WriteLine("\t /");

    double result = 0;

    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine("the answer is " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine("the answer is " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine("the answer is " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine("the answer is " + result);
            break;
    }
    Console.WriteLine(" WOULD YOU LIKE TO CONTINUE?(Y = YES , N = NO) ");

} while (Console.ReadLine().ToUpper() == "Y");
    Console.WriteLine("bye");

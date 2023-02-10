using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeCheck1_Calculator;
using static KnowledgeCheck1_Calculator.InputValidation;

Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

var input = Console.ReadLine();
var calculator = new Calculator();

switch (input)
{
    case "1":
        Console.WriteLine("Enter 2 integers to add");
        string plusNumber1 = Console.ReadLine();
        string plusNumber2 = Console.ReadLine();

        (int plusnum1, int plusnum2, string plusMessage, bool plusResponce) = Validate(plusNumber1,plusNumber2, " + ");

        if (plusResponce)
        {
            Console.Write(plusMessage);
            Console.Write(calculator.Add(plusnum1, plusnum2));
        }
        else
        {
            Console.WriteLine(plusMessage);
        }
        break;

    case "2":
        Console.WriteLine("Enter 2 integers to subtract");
        string minusNumber1 = Console.ReadLine();
        string minusNumber2 = Console.ReadLine();

        (int minusnum1, int minusnum2, string minusMessage, bool minusResponce) = Validate(minusNumber1, minusNumber2, " - ");

        if (minusResponce)
        {
            Console.Write(minusMessage);
            Console.Write(calculator.Subtract(minusnum1, minusnum2));
        }
        else
        {
            Console.WriteLine(minusMessage);
        }
        break;

    case "3":
        Console.WriteLine("Enter 2 integers to multiply");
        string timesNumber1 = Console.ReadLine();
        string timesNumber2 = Console.ReadLine();

        (int timesnum1, int timesnum2, string timesMessage, bool timesResponce) = Validate(timesNumber1, timesNumber2, " x ");

        if (timesResponce)
        {
            Console.Write(timesMessage);
            Console.Write(calculator.Multiply(timesnum1, timesnum2));
        }
        else
        {
            Console.WriteLine(timesMessage);
        }
        break;

    case "4":
        Console.WriteLine("Enter 2 integers to divide");
        string divNumber1 = Console.ReadLine();
        string divNumber2 = Console.ReadLine();

        (int divnum1, int divnum2, string divMessage, bool divResponce) = Validate(divNumber1, divNumber2, " / ");

        if (divResponce)
        {
            Console.Write(divMessage);
            Console.Write(calculator.Divide(divnum1, divnum2));
        }
        else
        {
            Console.WriteLine(divMessage);
        }

        break;

    default:
        Console.WriteLine("Unknown input");
        break;
}

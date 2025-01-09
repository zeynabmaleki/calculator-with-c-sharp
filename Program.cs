int num1, num2;
char answer;

Console.WriteLine("Enter the first number :");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number :");
num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("What type of operation wold you like to do?(+,-,*,/)");
answer = Convert.ToChar(Console.ReadLine());



switch (answer)
{
    case '+':
        Console.WriteLine($"num1 + num2 = {num1 + num2}");
        break;
    case '-':
        Console.WriteLine($"num1 - num2 = {num1 - num2}");
        break;
    case '*':
        Console.WriteLine($"num1 * num2 = {num1 * num2}");
        break;
    case '/':
        if (num2 != 0)
        {
            Console.WriteLine($"num1 / num2 = {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
        break;
    default:
        Console.WriteLine("Invalid Operation!");
        break;
}

Console.ReadKey();
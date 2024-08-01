Console.WriteLine("Welcome");

Console.WriteLine("Press 1 To Sum");

Console.WriteLine("Press 2 To Subtraction");

Console.WriteLine("Press 3 To Multiplication");

Console.WriteLine("Press 4 To Division");

int chooice = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your first number");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter your Second number");
double number2 = Convert.ToDouble(Console.ReadLine());

if (chooice == 1)
{
    double result = number1 + number2;
    Console.WriteLine("The Result = " + result);

}
else if (chooice == 2)
{
    double result = number1 - number2;
    Console.WriteLine("The Result = " + result);
}
else if (chooice == 3)
{
    double result = number1 * number2;
    Console.WriteLine("The Result = " + result);
}
else if (chooice == 4)
{
    double result = number1 / number2;
    Console.WriteLine("The Result = " + result);
}

Console.ReadLine();







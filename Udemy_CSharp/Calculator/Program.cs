// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello");
Console.WriteLine("Input the first number:");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
Console.WriteLine("Input the second number:");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
Console.WriteLine("Select an operation: [A]dd, [S]ubtract, [M]ultiply, [D]ivide");
string operation = Console.ReadLine();
int result = 0;
if (operation == "A" || operation == "a")
{
    result = number1 + number2;
    printResult(result, number1, number2, "+");
}
else if (operation == "S" || operation == "s")
{
    result = number1 - number2;
    printResult(result, number1, number2, "-");
}
else if (operation == "M" || operation == "m")
{
    result = number1 * number2;
    printResult(result, number1, number2, "*");
}
else if (operation == "D" || operation == "d")
{
    result = number1 / number2;
    printResult(result, number1, number2, "/");
}
else
{
    Console.WriteLine("Invalid option");
}
void printResult(int result,int number1,int number2,string operation)
{
    Console.WriteLine("The result of " + number1 + " " + operation + " " + number2 + " is: " + result);
} 

Console.ReadKey();
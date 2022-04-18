while(true)
{
    Console.Write("Do you want to add, subtract, multiply, or divide? You can exit at any time by typing exit: ");
    string userInput = Console.ReadLine().ToLower();
    if(userInput == "exit")
    {
        return;
    }
    while (string.IsNullOrEmpty(userInput) | userInput != "add" & userInput != "subtract" & userInput != "multiply" & userInput != "divide")
    {
        Console.Write("Please Try again or type exit to quit. ");
        userInput = Console.ReadLine().ToLower();
        if (userInput == "exit")
        {
            return;
        }
    }
    if (userInput == "add")
    {
        Console.Write("What is the first number you would like to add?: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("What is the second number you would like to add?: ");
        int b = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"{a} + {b} = {addition(a, b)}");
    }
    else if (userInput == "subtract")
    {
        Console.Write("What is the first number you would like to subtract?: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("What is the second number you would like to subtract?: ");
        int b = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"{a} - {b} = {subtraction(a, b)}");
    }
    else if (userInput == "multiply")
    {
        Console.Write("What is the first number you would like to multiply?: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("What is the second number you would like to multiply?: ");
        int b = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"{a} * {b} = {multiplication(a, b)}");
    }
    else if (userInput == "divide")
    {
        Console.Write("What is the first number you would like to divide?: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("What is the second number you would like to divide?: ");
        int b = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"{a} / {b} = {division(a, b)}");
    }
}


int addition(int a, int b)
{
    int answ = a + b;
    return answ;
    
}
int subtraction(int a, int b)
{
    int answ = a - b;
    return answ;
}
int multiplication(int a, int b)
{
    int answ = a * b;
    return answ;
}
int division(int a, int b)
{
    int answ = a / b;
    return answ;
}
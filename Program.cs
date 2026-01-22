Console.WriteLine("Choose conversion:");
Console.WriteLine("1 - Decimal to base");
Console.WriteLine("2 - Base to decimal");

int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.Write("Enter decimal number: ");
    int decNum = int.Parse(Console.ReadLine());

    Console.Write("Enter base (2 - 16): ");
    int toBase = int.Parse(Console.ReadLine());

    string converted = DecimalToBase(decNum, toBase);
    Console.WriteLine("Result: " + converted);
}
else if (choice == 2)
{
    Console.Write("Enter number: ");
    string num = Console.ReadLine().ToUpper();

    Console.Write("Enter base (2 - 16): ");
    int fromBase = int.Parse(Console.ReadLine());

    int decResult = BaseToDecimal(num, fromBase);
    Console.WriteLine("Decimal result: " + decResult);
}
else
{
    Console.WriteLine("Invalid choice!");
}

static string DecimalToBase(int number, int baseTo)
{
    if (number == 0)
        return "0";

    string digits = "0123456789ABCDEF";
    string result = "";

    while (number > 0)
    {
        int remainder = number % baseTo;
        result = digits[remainder] + result;
        number /= baseTo;
    }

    return result;
}

static int BaseToDecimal(string number, int baseFrom)
{
    string digits = "0123456789ABCDEF";
    int result = 0;
    int power = 1;

    for (int i = number.Length - 1; i >= 0; i--)
    {
        int digitValue = digits.IndexOf(number[i]);
        result += digitValue * power;
        power *= baseFrom;
    }

    return result;
}
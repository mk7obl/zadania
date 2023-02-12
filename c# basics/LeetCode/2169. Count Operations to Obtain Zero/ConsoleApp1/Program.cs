Console.WriteLine("Hello, World!");

int num1 = 2; //Convert.ToInt32(Console.ReadLine());
int num2 = 3; //Convert.ToInt32(Console.ReadLine());

int result = 0;
int count = 0;

do
{
    if (num1 >= num2)
    {
        result = num1 - num2;
        num1 = result;
        count++;
    }

    else
    {
        result = num2 - num1;
        num2 = result;
        count++;
    }
} while (num1 > 0 || num2 > 0);

Console.WriteLine(count);

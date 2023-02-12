// See https://aka.ms/new-console-template for more information

int count = 0;

int CountOperations(int num1, int num2)
{
    if ((num1 >= 0) && (num2 <= Math.Pow(10, 5)))    //not necessary
    {
        while (num1 > 0 && num2 > 0)
        {
            int result = 0;                  //-=, int result not necessary (memory)

            if (num1 >= num2)
            {
                result = num1 - num2;        //-= ^
                num1 = result;
                count++;
            }

            else
            {
                result = num2 - num1;        //-= ^^
                num2 = result;
                count++;
            }

        };
    }
    return count;
}

CountOperations(0, 3);
Console.WriteLine(count);



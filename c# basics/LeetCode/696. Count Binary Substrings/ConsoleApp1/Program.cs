//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int CountBinarySubstrings(string s)
{

    int size = s.Length;
    int count1;
    int count0;
    int results = 0;

    for (int i = 0; i < size; i++)
    {
        count0 = 0;
        count1 = 0;
        for (int j = i; j < s.Length; j++)
        {
            char c = s[j];

            if (c == '1')
            {
                count1++;
            }

            if (c == '0')
            {
                count0++;
            }

            if (count0 == count1)
            {
                results++;
                break;
            }
        }
    }

    return results;
    Console.WriteLine(results);
}

string input = "00110011";
CountBinarySubstrings(input);





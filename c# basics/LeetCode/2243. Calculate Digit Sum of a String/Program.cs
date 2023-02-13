
//try it with StringBuilder to check runtime & memory
string result = "";
int sum = 0;
string DigitSum(string s, int k)
{
    while (s.Length > k)
    {
        result = "";

        for (int j = 0; j < s.Length; j += k)
        {
            int i;
            for (i = j; (i < j + k) && (i < s.Length); i++)
            {
                sum += Int32.Parse(s[i].ToString());
            }

            result += sum;
            sum = 0;
        }

        s = result;

    }

    if (s.Length <= k)
        result = s;

    return result;
}


DigitSum("1", 2);
Console.WriteLine(result);
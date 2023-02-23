//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Given an integer n, return the number of strings of length n that consist only of vowels (a, e, i, o, u) and are lexicographically sorted.

//A string s is lexicographically sorted if for all valid i, s[i] is the same as or comes before s[i+1] in the alphabet.

//doesnt work for n>2
int CountVowelStrings(int n)
{

    Dictionary<int, string> dict = new Dictionary<int, string>()
    {
        {0, "a"},
        {1, "e"},
        {2, "i"},
        {3, "o"},
        {4, "u"}
    };

    string result = "";
    int count = 0;

    if (n == 1)
        return dict.Count;

    for (int i = 0; i < dict.Count; i++)
    {
        for (int j = i; j < dict.Count; j++)
        {
            if (n==2)
                result = dict[i] + dict[j];

            for(int k= j; k < dict.Count;k++)
            {
                result += dict[k];

                
                if (result.Length==n)
                {
                    Console.WriteLine(result);
                    count++;
                    break; 
                }

                if (k == dict.Count)
                    k = 0;
            }

        }
    }

    Console.WriteLine(count);
    return count;
}

CountVowelStrings(3);



﻿int CountBinarySubstrings(string s)
{

    int size = s.Length;
    int count1 = 0;
    int count0 = 0;
    int results = 0;

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < s.Length; j++)
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
            }
        }
    }

    return results;

}

string input = "00110011";
CountBinarySubstrings(input);




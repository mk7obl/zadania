﻿//wrong one
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

    Console.WriteLine(results);
    return results;

}

string input = "1100111110110110011111111111110011001011111111100110111111111101010010011110001111110111101111110101110100001111001110011101011000111011101011111110101100101111110101101101111111001111111000011110110101111111111010101001111100010000001001101001100101111110110111110111111010011001110111101110001011100110011010001011100000001101000011100111111010110101110110000011110110111101010110010101111101011111111111110100110101111101111001101011101111111111100111011011010010110111111101110011011111111110001110110000101111111111101110011111011100010111110011110111111110111000110101011101101011101011011100011101101111110111000111110101100110111111001111110111111101101110011101110111110111111101001111100111010111011110011011100101100101010110001011100110111101111110111111111110010101100100111110101011111010101101101111110111111011011001001111001111000111010111100100110011111111100100111100011111011100001001101111011011110010101110001111010000001111110001011000110110111111000110001110101100111111100011100101000111011101110011111111111011111101111110011110111101110011111101110111110111111101111101011010111110110011011101101111100001000101010110110111011111110111111100110111011001111011100011011100101010111111111101110010101101001111011110111011110011000000110111111111101111010110010010111111100111110111000101111010111011111111111000001011111011110111111111111100100100001101101111110010000111101001111111101011010011110011011111000111010000010110011011011011111111110011111101100010111011010111011111111110101110101001101100010111111001101011011111001000101011111011111011110110101111111011011110101111001010110001101011000110110011111101100111110100101111011001000111111110100111101100101111111010110110011110010010111010111111101111101111101001110011101111110001110111010011011101111100011111111101010101101011111111100110111100111101110110010110111100011111010110011111101101101000110110001010001111011100100111111111011111011111111100101111001111110011010010010111111110110001001101111110011111010110011101111110110010000001111111000110111101101111010111110001011100011111011100100000111111011011010010100110101011001111111101111010111111000101110001011111010110110111111111111101101011100000110101001111010110111100011011110100110111111111111111100011011011110011010011100111111111110110111001110100110111010010110111111111111111110001101111011111110111010001101110111110100111110111111110110111111111011111000000101101101111011011111111111111011111000101111111101111111111111111111111100100111000011010001000110110110111111110101111000110100100001111011100111111010100101101010100000111001111101011001111110111011111011010111111011111011010100111011110001000010111110110111110111011011010001010101101111111101111100010010111101100000110100101111010100111101110111011101001101101111001110111101101111101000110110110111101111011011101010001111010011111110111011011100001111111111111000111010101001110010100011011011101111010111110011111010101101010101111110010101111010111001110000011110100011110110111101001110011101110110101111111000101111010111110111110001111110100100001101010001011111110010110110000101111110110111101000101111011111011001100000111111111101010010100111100111110111100011111101111011111100111110000101111011101001001111001101110100100101101111001111111111000110111111101010110011010010011001000111100010100111111001101111110011111000111101011101111110101111101111010110111111101111011111111111100001101100110110011111111101111111101011010010110110011101000111101111110111111011111111110110011100001111110001111011100111111101011111110100110000110011001011111001001110111011110101101101011011011010011110111011100101011011001110001001101011010111000001101011111111101011001111001001100001111110101001111111011100000111100110101010010111101110111011111010110101111101100111111110011011101011101111110011000110111010110011111111111100111011101111011111101111110011101011100101100100111111111111011011100111111111100101111111001111010100011011111001000010111101111111011111100111110111010101111111011111011010000110010111011011000111111011010000111001010101111101011111010111100011001011110111011101110001000111111111100101100110011011011110111111000100010111111011110100111010111111111001011111111111001111110110010011001111100111011110011111000101101111100110011000010100110111101100111110111101111011111100110011011111011001101010111111111010111111100101101011111111011100001111011011111111011111110010100110000000011000010111011101111101111111101101111001011111010110110101011100001110100101001111001111011101101010011010110111101111110101101111100110111101111111101010000101010010001110111000110101101100101111101101011100101111011111101111011110100001011110110111111111011000111111001111010111011010111000101110011010110010111111101111111110111011111010110111111001010111001110110101011000111110000010001101111111000011010110111100010111110010001110011111001110101001000100111011110000100111101101111010011101011010101101000011111111011101111111101111101101110111011111001110111101010111000101010111010111110110010110110111111110111111110011101111011111011111111001111110100110100010110001111101111000111100111101101010110100110110110111001111111111010011011001111111111111010111011101101010100111111011111000110111111011111010111110101110100011110110100100100101111111111111111011110001100011101011101111010111111000000011100111001011110111110110110101100011100101110010001111110011110110101011001101101110001001111110110111111110110011101100111011111011010110011010100011111101101000100010001111110110101000010110111111111111101111001011101011000000101011011101111001010110011111101100110011100101101110111100011011111100110111111111011111001110110000010010111001111110010111111010110010100011101111100111011111011110110101110101101100000001011101001111111000001110010110111011111111011110110111011001111111101000101110111110111001110001001011011010111111011000111111111101111111100000110110011110011010110101101111101000101101011110111001100110111111100111101001000001001110101110111111110011101001011111011010110111100001110110011111010111111011111110111010101110011010100100110111111111011011011010100001001100010111101110110111001110011011111101111001001111111111100110101111011110111111111010101101011110111111101001111001011011110011111110111011110101100011111111011110111101011111011011110111100100101101101111110111110011110100011010111001100011111110101111101100011111111010111011100011110110111101110001111111110011011101111111010010110010100111111111111111010101111111101111010001010001001101110001100101101101001000101111110110110011010101100101101100110011111010011000010111001011110110110101101010011110011101101100011110110011100010111100111101001000011101110111100111010101111011111001100111011010111001101101110000011011000111101111010111001101111111101110111010110111110111011111101101001001110110011111011101111010001111011111100110011100111011111111001111111111010010001111111111001011010010101110111101111111001011110010111101011111111111111000001111100101111111011101101110011110111101110110111101001100000110000111110001010010111111111011011011011111110111101101011011111101101011100111111101001111011110011101101111010111011011100111100101111111011100111101101010101000111111111101101101111111101110011111111101011101011111111010110110101111001111010011100011111011111100001101011010110101100011111101100111110011011110100110001111011110100111010111111010110111111111011001011111111011111100110110111100111110010011110110011011110110001111011100111101101110011101001101100110110111101000011110011010110101111111111011101110110100101110100011110101010101110111011111101111001011011100101011011010111111010111100000011010011111010110101001111111011101000001010011101111100101111011111111111010110111111011100110111001011001011111111101110111011001111111111111110010101101011011010011101110111000011111010111001011111111111101011111011110100011111010010101110111100110111011010000111001001001111110010110011101110101101011011110001001011100000100101111111100101111011010111111101011100011100111011100100101100111101001011110011001100110001000111110110110001110110111100110111111100111111111101110111111111000001110110101110110010011101110100111001001110110110101101111001001111111100101101101101011101111111010011011101011110111010000011101111001101011111011011110111101010101110101100111110011001111101111111011101001101111111111010001011011010110110001110111111110011111111001110100101111011111110100111110111110011111110011111101111110101100100001110110111110101110011100101111100110111111011111100101111110100001010011110010110101111110010010011100001011001011010101110111011111010101101001101010101111110111011110111101111111111110111011111010101011000110001110111111110111010110110111111110101101111001101111010111010110101110011101111011111111010111111111101010011001101111111011011101110011100101110001111011111010110111111110101011111010111111110111110011111110111001011100111111110111110101101110011011110011110101111111111011011101111110110001001111101100100000111110101010000110011111101011111101111100110011111011010011011011010000001101111111011010111100100111100101101011010101010010111110010010111010001011101011111110000011111010110111101011101101101010010011100111011010110011111110010010111111101011111111111101111111110101100101111111110000110011000101011110111010110011001011000011000001000100110011100111111110011011111111001010011110011101101110011011110010101011101011111010101011001111110010111011111001100100110011010011100110111101010111101110101011111111111111000101111111011010111111010010000101111010101001111111001111010000111111010011111111010001010011011100111111001110011111011101010001111111011001001101111111010111101000111001010111001011111111011110001001111111110111111011100110101111010111101011111111100010000111011111011000111111111111100111011001001111001111110000101110100011101111111101110111111111111111110110001101010101110111110111101111110011010111011101111110111111011101111111001111111011110111111";
CountBinarySubstrings(input);





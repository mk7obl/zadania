//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Given a string s consisting of only the characters 'a' and 'b', return true if every 'a' appears before every 'b' in the string. Otherwise, return false.

//runtime 91%, memory 20%

bool CheckString(string s)
{
    int size = s.Length;
    int aIndex;
    int bIndex;


    aIndex = s.LastIndexOf('a');
    bIndex = s.IndexOf('b');

    Console.WriteLine(aIndex);
    Console.WriteLine(bIndex);

    if (bIndex < aIndex && bIndex != -1)
        return false;

    return true;
}

string s = "a";
CheckString(s);

//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//time limit exceeded


//bool Check(int x, int j, string s)
//{
//    //"00110011";
//    int count = 0;

//    for (int k = x; k <j; k++)
//    {
//        if (s[k] != s[k + 1])
//            count++;

//        if (count == 2)
//        {
//            return false;
//        }
//    }

//    return true;
//}
int CountBinarySubstrings(string s)
{

    int size = s.Length-1;
    int results = 0;
    int balance;
    int check;

    for (int i = 0; i < size; i++)
    {
        balance = 0;
        check = 0;

        for (int j = i; j <= size; j++)
        {
            if (s[j] == '1')
                balance++;

            if (s[j] == '0')
                balance--;

            if(s[j] != s[j+1])
            {
                check++;

                    if (check == 2)
                        break;
            }
                    


            if (balance == 0)
            {


                ////"00110011";
                //int count = 0;

                //for (int k = i; k < j; k++)
                //{
                //    if (s[k] != s[k + 1])
                //        count++;

                //    if (count == 2)
                //    {
                //        break;
                //    }
                //}
                //if (count < 2)
                //{
                //    results++;
                //    break;
                //}
                results++;
            }
        }
    }

    Console.WriteLine(results);
    return results;

}

string input = "00110011";
CountBinarySubstrings(input);

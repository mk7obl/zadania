

//int BinaryGap(int n)
//{
//    string bin = Convert.ToString(n, 2);
//    int distance = 0;

//    ///                                      value  index  
//    Dictionary<int, int> dict = new Dictionary<int, int>();

//    for (int i = 0; i < bin.Length; i++)
//    {

//        if (bin[i] == 1)
//        {
//            dict.Add(bin[i], bin.IndexOf(bin[i]));
//        }

//    }

//    for (int i = 0; i < dict.Count; i++)
//    {

//        if (distance[i] > distance[i - 1])
//        {
//            distance = dict[i + 1] - dict[i];
//        }

//        Console.WriteLine(distance);
//    }
//}

//BinaryGap(22);

/////liczenie do i
/////liczenie i[j]
///// i=j
///// i od nowa
///// 

using System.Globalization;
///

int BinaryGap(int n)
{
    string dec = Convert.ToString(n, 2);
    int distance = 0;

    for (int i = 0; i < dec.Length; i++)
    {
        if (dec[i] == '1')
        {
            distance = 1;
            for (int j = i; j < dec.Length; j++)
            {
                if (dec[j] == '0' || j==0)
                {
                    distance++;
                }

                else if (dec[j] == '1' && j!=i)
                    break;
                i = j;
            }
        }

        if (distance == dec.Length - 1)
            distance = 0;
    }
    return distance;
}

BinaryGap(5);


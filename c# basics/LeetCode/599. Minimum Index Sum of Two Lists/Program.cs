//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//dictionaries solution was ok

string[] FindRestaurant(string[] list1, string[] list2)
{

    //Dictionary<int, string> dict = new Dictionary<int, string>();

    List<int> list = new List<int>();
    int min;
    int count = 0;

    for (int i = 0; i < list1.Length; i++)
    {
        for (int j = 0; j < list2.Length; j++)
        {

            if (list1[i] == list2[j])
            {
                list.Add(i + j);
            }
        }
    }

    min = list.Min();

    foreach (int k in list)
    {
        if (k == min)
            count++;
    }

    string[] results = new string[count];


    for (int i = 0; i < results.Length; i++)
    {
        results[i] = list2[min];
    }

    return results;
}


string[] list1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
string[] list2 = { "KFC", "Shogun", "Burger King" };

FindRestaurant(list1, list2);
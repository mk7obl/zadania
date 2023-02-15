/// <summary>
/// using switch
/// </summary>
//public class Solution
//{

//    int count = 0;
//    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
//    {

//        switch (ruleKey)
//        {

//            case "type":
//                for (int i = 0; i < items.Count; i++)
//                {
//                    var item = items[i];

//                    if (item[0] == ruleValue)
//                    {
//                        count++;
//                    }

//                }
//                break;

//            case "color":
//                for (int i = 0; i < items.Count; i++)
//                {
//                    var item = items[i];

//                    if (item[1] == ruleValue)
//                    {
//                        count++;
//                    }

//                }
//                break;

//            case "name":
//                for (int i = 0; i < items.Count; i++)
//                {
//                    var item = items[i];

//                    if (item[2] == ruleValue)
//                    {
//                        count++;
//                    }

//                }
//                break;

//        }
//        return count;
//    }
//}

/// <summary>
/// dictionary
/// </summary>
public class Solution
{
    int count = 0;
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            {"type",0},
            {"color",1},
            {"name",2},
        };

        int key = dictionary[ruleKey];

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i][key] == ruleValue)
            {
                count++;
            }
        }

        return count;
    }
}
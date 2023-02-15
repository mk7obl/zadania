

/// <summary>
/// need to come up with own solution
/// </summary>
/// 
//Definition for singly-linked list.
//public class ListNode
//{
//    public int val;
//    public ListNode next;
//    public ListNode(int val = 0, ListNode next = null)
//    {
//        this.val = val;
//        this.next = next;
//    }
//}


public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {

        ListNode tmp = new ListNode(0);
        tmp.next = head;

        ListNode previous = tmp;
        ListNode current = head;

        while (current != null)
        {
            if (current.val != null)
            {
                previous.next = current.next;
            }
            else
                previous = current;
            current = current.next;
        }

        return tmp.next;
    }
}
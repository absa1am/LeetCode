/**
* public class ListNode
* {
*     public int val;
*     public ListNode next;
* 
*     public ListNode(int val = 0, ListNode next = null)
*     {
*         this.val = val;
*         this.next = next;
*     }
* }
**/

public class MergeTwoSortedListsSolution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = null;
        ListNode tail = head;

        if(list1 == null) return list2;
        if(list2 == null) return list1;

        if(list1.val < list2.val)
        {
            head = list1;
            tail = list1;
            list1 = list1.next;
        }
        else
        {
            head = list2;
            tail = list2;
            list2 = list2.next;
        }

        while(list1 != null || list2 != null)
        {
            if(list2 == null)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else if(list1 == null)
            {
                tail.next = list2;
                list2 = list2.next;
            }
            else if(list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }

            tail = tail.next;
        }

        return head;
    }
}
/**
*public class ListNode
*{
*    public int val;
*    public ListNode next;
*
*    public ListNode(int val = 0, ListNode next = null)
*    {
*        this.val = val;
*        this.next = next;
*    }
*}
**/

public class RemoveDuplicatesFromSortedListSolution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode curr = head;

        while(curr != null)
        {
            ListNode node = curr.next;

            while(node != null)
            {
                if(curr.val != node.val)
                {
                    curr.next = node;
                    break;
                }
                else if(curr.val == node.val && node.next == null)
                {
                    curr.next = node.next;
                    break;
                }

                node = node.next;
            }

            curr = curr.next;
        }

        return head;
    }
}
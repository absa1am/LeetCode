/**
public class ListNode
{
    public int val;
    public ListNode next;
 
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
**/

public class ReverseLinkedListSolution
{
    public ListNode ReverseList(ListNode head)
    {
        if(head == null) return head;

        ListNode newHead = new ListNode(head.val);
        ListNode current = head.next;

        while(current != null)
        {
            newHead = new ListNode(current.val, newHead);
            current = current.next;
        }

        return newHead;
    }
}
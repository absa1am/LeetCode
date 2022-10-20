/**
*public class ListNode
*{
*    public int val;
*    public ListNode next;
*
*    public ListNode(int val = 0, ListNode next = null) {
*        this.val = val;
*        this.next = next;
*    }
*}
*/

public class RemoveLinkedListElementsSolution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode curr = null;
        ListNode newHead = null;

        while(head != null)
        {
            if(head.val != val)
            {
                if(newHead == null)
                {
                    newHead = new ListNode(head.val);
                    curr = newHead;
                }
                else {
                    curr.next = new ListNode(head.val);
                    curr = curr.next;
                }
            }

            head = head.next;
        }

        return newHead;
    }
}
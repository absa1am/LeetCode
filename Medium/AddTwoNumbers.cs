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
 */

public class AddTwoNumbersSolution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode sum = new ListNode(((l1.val + l2.val) % 10));
        int carry = (l1.val + l2.val) / 10;
        l1 = l1.next; l2 = l2.next;
        ListNode curr = sum;

        while(l1 != null && l2 != null)
        {
            curr.next = new ListNode(((l1.val + l2.val + carry) % 10));
            carry = (l1.val + l2.val + carry) / 10;
            l1 = l1.next; l2 = l2.next;
            curr = curr.next;
        }

        if(l1 == null)
        {
            while(l2 != null)
            {
                curr.next = new ListNode(((l2.val + carry) % 10));
                carry = (l2.val + carry) / 10;
                curr = curr.next;
                l2 = l2.next;
            }
        }
        else if(l2 == null)
        {
            while(l1 != null)
            {
                curr.next = new ListNode(((l1.val + carry) % 10));
                carry = (l1.val + carry) / 10;
                curr = curr.next;
                l1 = l1.next;
            }
        }

        if(carry > 0) curr.next = new ListNode(carry);

        return sum;
    }
}
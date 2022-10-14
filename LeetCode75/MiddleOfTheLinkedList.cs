public class MiddleOfTheLinkedListSolution
{
    public ListNode MiddleNode(ListNode head)
    {
        int nodeAt = GetLength(head);

        if(nodeAt % 2 == 0) nodeAt = (nodeAt + 1) / 2;
        else nodeAt = nodeAt / 2;

        int count = 0;
        ListNode current = head;
        while(current != null)
        {
            if(count == nodeAt)
                return current;

            current = current.next;
            count++;
        }

        return current;
    }

    public int GetLength(ListNode head)
    {
        int size = 0;

        ListNode current = head;
        while(current != null)
        {
            current = current.next;
            size++;
        }

        return size;
    }
}
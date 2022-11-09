public class KthLargestElementInAnArraySolution
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> pq = new(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        for(int i = 0; i < nums.Length; i++)
            pq.Enqueue(i, nums[i]);

        for(int i = 0; i < k - 1; i++)
            pq.Dequeue();
        
        pq.TryDequeue(out int a, out int m);
        
        return m;
    }
}
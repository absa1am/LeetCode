public class BinarySearchSolution
{
    public int Search(int[] nums, int target)
    {
        int lo = 0;
        int hi = nums.Length - 1;

        while(lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;

            if(nums[mid] == target ) return mid;
            else if(nums[mid] < target) lo = mid + 1;
            else hi = mid - 1;
        }

        return -1;
    }
}
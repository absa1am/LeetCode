public class FindAllNumbersDisappearedInAnArraySolution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> absent = new();
        bool[] exist = new bool[nums.Length];

        for(int i = 0; i < nums.Length; i++)
            exist[nums[i] - 1] = true;

        for(int i = 0; i < nums.Length; i++)
            if(!exist[i]) absent.Add(i + 1);

        return absent;
    }
}
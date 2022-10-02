public class FirstBadVersionSolution
{
    public int FirstBadVersion(int n)
    {
        int lo = 1;
        int hi = n;
        int bv = 0;

        while(lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;

            if(IsBadVersion(mid)) {
                bv = mid;
                hi = mid - 1;
            }
            else lo = mid + 1;
        }

        return bv;
    }
}
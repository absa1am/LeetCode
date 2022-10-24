public class NumberOfSegmentsInAStringSolution
{
    public int CountSegments(string s)
    {
        int count = 0;

        for(int i = 0; i < s.Length;)
        {
            if(s[i] != ' ')
            {
                count++;
                while(s[i] != ' ')
                {
                    i++;
                    if(i == s.Length) break;
                }
            }
            else i++;
        }

        return count;
    }
}
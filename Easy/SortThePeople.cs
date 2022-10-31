public class SortThePeopleSolution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        SortedDictionary<int, string> info = new();

        for(int i = 0; i < names.Length; i++)
            info.Add(heights[i], names[i]);

        string[] sortedNames = info.Values.ToArray();
        Array.Reverse(sortedNames);
        
        return sortedNames;
    }
}
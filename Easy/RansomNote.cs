public class RansomeNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> ransomMap = new();
        Dictionary<char, int> magazineMap = new();

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (!ransomMap.ContainsKey(ransomNote[i]))
                ransomMap.Add(ransomNote[i], 0);

            ransomMap[ransomNote[i]]++;
        }

        for (int i = 0; i < magazine.Length; i++)
        {
            if (!magazineMap.ContainsKey(magazine[i]))
                magazineMap.Add(magazine[i], 0);

            magazineMap[magazine[i]]++;
        }

        foreach (var key in ransomMap.Keys)
        {
            if (!magazineMap.ContainsKey(key) || magazineMap[key] < ransomMap[key])
                return false;
        }

        return true;
    }

    public bool CanConstructV2(string ransomNote, string magazine)
    {
        int[] track = new int[26];

        for (int i = 0; i < ransomNote.Length; i++)
            track[ransomNote[i] - 97]--;

        for (int i = 0; i < magazine.Length; i++)
            track[magazine[i] - 97]++;

        for (int i = 0; i < 26; i++)
            if (track[i] < 0) return false;

        return true;
    }
}
public class Solution 
{
    public int RomanToInt(string s) 
    {
        int result = 0;
        Dictionary<char, int> romanLookup = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i != s.Length - 1)
                j = i + 1;
            if (j > i && (romanLookup[s[j]] > romanLookup[s[i]]))
            {
                result += romanLookup[s[j]] - romanLookup[s[i]];
                i++;
            }
            else
                result += romanLookup[s[i]];
        }
        return result;
    }
}
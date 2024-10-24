public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
            return false;
        Dictionary<char, int> charCount = new Dictionary<char, int>();
       for (int i = 0; i < s.Length; i++)
       {
            if (!charCount.ContainsKey(s[i]))
                charCount.Add(s[i], 1);
            else
                charCount[s[i]]++;
       }
       for (int j = 0; j < t.Length; j++)
       {
            if (!charCount.ContainsKey(t[j]))
                return false;
            else
                charCount[t[j]]--;
       }
       foreach(int count in charCount.Values)
       {
            if(count != 0)
                return false;
       }
       return true;
    }
}
public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        s = new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray());
        return IsPalindrome(s, 0, s.Length - 1);
    }
    public bool IsPalindrome(string s, int start, int end)
    {
        if (start > end)
            return true;
        return (s[start] == s[end] && IsPalindrome(s, start + 1, end - 1));
    }
}
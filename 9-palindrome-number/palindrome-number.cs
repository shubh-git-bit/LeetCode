public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        var originalNo = x;
        int reversedNo = 0;
        if (originalNo > 0)
        {
            while (x > 0)
            {
                int lastDigit = x % 10;
                reversedNo = reversedNo * 10 + lastDigit;
                x = x / 10;
            }
        }
        return reversedNo == originalNo;
    }
}
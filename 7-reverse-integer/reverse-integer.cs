public class Solution 
{
    public int Reverse(int x) 
    {
        int MAX = int.MaxValue / 10;
        int MIN = int.MinValue / 10;
        bool isNegative = false;
        int reversedNo = 0;

        if (x == int.MaxValue || x == int.MinValue)
            return 0;
        if (x < 0)
        {
            isNegative = true;
            x = Math.Abs(x);
        }
        while (x > 0)
        {
            reversedNo = 10 * reversedNo + x % 10;
            x /= 10;
            if (reversedNo > MAX && x != 0)
                return 0;
        }
        if (isNegative)
            return -reversedNo;
        else
            return reversedNo;
    }
}
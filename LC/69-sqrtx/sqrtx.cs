public class Solution 
{
    public int MySqrt(int x) 
    {
        if (x == 0)
            return 0;
        if (x == 1)
            return 1;
        long low = 1;
        long high = x;
        while (high >= low)
        {
            long mid = (high + low) / 2;
            if (mid * mid == x)
                return Convert.ToInt32(mid);
            if (mid * mid > x)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return Convert.ToInt32(high);  
    }
}
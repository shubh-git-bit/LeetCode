public class Solution 
{
    public double MyPow(double x, int n) 
    {
        bool isNegative = n < 0;
        long exp = n;
        exp = Math.Abs(exp);
        double ans = 1;

        if (x == 0)
            return 0;
        if (n == 0)
            return 1;

        while (exp > 0)
        {
            if (exp % 2 != 0)
            {
                ans *= x;
                exp--;
            }
            else
            {
                exp /= 2;
                x *= x;
            }
        }
        return isNegative ? 1.0 / ans : ans;
    }
}
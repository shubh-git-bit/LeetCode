public class Solution 
{
    public List<long> LcmAndGcd(long A, long B) 
    {
        List<long> result = new List<long>();
        long gcd = FindGcd(A, B);
        long lcm = Math.Abs(A * B) / gcd;

        result.Add(lcm);
        result.Add(gcd);
        return result;
    }

    public long FindGcd(long a, long b) 
    {
        while (a > 0 && b > 0) 
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }
        return Math.Max(a, b);
    }
}


public class Solution 
{
    public int Fib(int n) 
    {
        Dictionary<int,int> memo = new Dictionary<int,int>();
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        if (memo.ContainsKey(n))
            return memo[n];

        memo[n] = Fib(n - 1) + Fib(n -2);   
        return memo[n];
    }
}
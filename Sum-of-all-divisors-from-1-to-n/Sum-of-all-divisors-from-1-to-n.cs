class Solution
{
    //Complete this function
    public long sumOfDivisors(long N)
    {
        long sum = 0;
        for (long i = 1; i <= N; i++)
            sum += i * (N / i);
        return sum;
    }
}

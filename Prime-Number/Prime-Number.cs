class Solution
{
    
    public int isPrime(int N)
    {
        int divisorCount = 0;
        for (int i = 1; i * i <= N; i++)
        {
            if (divisorCount > 2)
                return 0;
            if (N % i == 0)
            {
                divisorCount++;
                if (i != N/i)
                    divisorCount++;
            }
        }
        if (divisorCount == 2)
            return 1;
        else
            return 0;
    }
}

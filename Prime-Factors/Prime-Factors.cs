class Solution
{
    public List<int> AllPrimeFactors(int N)
    {
        var primeFactors = new List<int>();
        for (int i = 2; i * i <= N; i++)
        {
            if (N % i == 0)
            {
                primeFactors.Add(i);
                
                while(N % i == 0)
                {
                    N /= i;
                }
            }
        }
        if (N > 1)
            primeFactors.Add(N);
        return primeFactors;
    }
}

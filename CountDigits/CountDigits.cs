class Solution{
    //Complete this function
    public int evenlyDivides(int N)
    {
        int resultCount = 0;
        List<int> divisors = new List<int>();
        int originalNumber = N;
        while (N > 0)
        {
            divisors.Add(N % 10);
            N /= 10;
        }
        foreach (int divisor in divisors)
        {
            if (divisor != 0 && originalNumber % divisor == 0)
                resultCount++;
        }
        return resultCount;
    }
}

class Solution 
{
    public List<long> factorialNumbers(long n) 
    {
        List<long> result = new List<long>();
        Factorial(1, 1, n, result);
        return result;
    }
    public void Factorial(long i, long currentFactorial, long n, List<long> factorialNumbers)
    {
        if (currentFactorial > n)
            return;
        if (!factorialNumbers.Contains(currentFactorial))
            factorialNumbers.Add(currentFactorial);
        Factorial (i + 1, currentFactorial * (i + 1), n, factorialNumbers);
    }
}

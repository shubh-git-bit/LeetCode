public class Solution 
{
    public int CountPrimes(int n) 
    {
        int primeCount = 0;
        //Initialize a sieve of size n + 1
        int[] sieve = new int[n + 1];
        //Initialize all elements in it to 1
        for (int i = 0; i <= n; i++)
            sieve[i] = 1;

        //Iterate from 2 till sqrt of n
        for (int i = 2; i * i <= n; i++)
        {
            if (sieve[i] == 1)
            {
                //Mark multiples of prime as 0
                for (int j = i * i; j <= n; j += i)
                sieve[j] = 0;
            }
        }

        //Count remaining primes
        for (int i = 2; i < n; i++)
        {
            if (sieve[i] == 1)
                primeCount++;
        }
        return primeCount;
    }
}
class Solution
{
  public List<int> findPrimeFactors(int N)
  {
    var primeNumbers = Sieve(N);
    List<int> primeFactors = new List<int>();
    foreach (var primeNo in primeNumbers)
    {
      while (N % primeNo == 0)
      {
        primeFactors.Add(primeNo);
        N /= primeNo;
      }
    }
    if (N != 1)
      primeFactors.Add(N);
    return primeFactors;
  }
  public static List<int> Sieve(int N)
  {
    List<int> primeNumbers = new List<int>();
    int sieveSize = Convert.ToInt32(Math.Sqrt(N));
    int[] sieve = new int[sieveSize];
    for (int i = 0; i < sieveSize; i++)
      sieve[i] = 1;

    for (int i = 2; i * i < sieveSize; i++)
    {
      if (sieve[i] == 1)
      {
        for (int j = i * i; j < sieveSize; j += i)
          sieve[j] = 0;
      }
    }
    for (int i = 2; i < sieveSize; i++)
    {
      if (sieve[i] == 1)
        primeNumbers.Add(i);
    }
    return primeNumbers;
  }
}


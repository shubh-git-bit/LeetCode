class Solution
{
    public void print_divisors(int n)
    {
        var divisors = new List<int>();
        for (int i = 1; i * i <= n; i++)
        {
          if (n % i == 0)
          {
            divisors.Add(i);
            if (i != (n / i))
              divisors.Add(n / i);
          }
        }
        divisors.Sort();
        foreach (var divisor in divisors)
          Console.Write(divisor + " ");
    }
}

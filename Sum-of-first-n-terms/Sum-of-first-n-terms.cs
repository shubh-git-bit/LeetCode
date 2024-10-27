public class Solution
{
  public static void Main(string[] args)
  {
      sumOfSeries(3);
  }
  public static long sumOfSeries(long n)
  {
      if (n == 0)
          return 0;
      return (n * n * n) + sumOfSeries(n - 1);
  }
}

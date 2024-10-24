class Solution
{
    public void printNos(int N)
    {
       if (N == 0)
        return;

       printNos(N - 1);
       Console.Write(N + " ");
    }
}

class Solution
{
    public void printNos(int N)
    {
        if (N == 0)
            return;
        Console.Write(N + " ");
        printNos(N - 1);
    }
}

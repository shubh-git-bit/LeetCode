public class Solution
{
    public void insertionSort(int[] arr, int n)
    {
        int j = 0;
        for (int i = 1; i <= n-1; i++)
        {
            j = i;
            while (j > 0 && arr[j] < arr[j - 1])
            {
                Swap(arr, j, j - 1);
                j--;
            }
        }
    }
    public void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}

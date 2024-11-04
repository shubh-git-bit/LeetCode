public class Solution
{
    public void quickSort(int[] arr, int low, int high)
    {
        if (low >= high) 
            return;
        int j = partition(arr, low, high);
        quickSort(arr, low, j - 1);
        quickSort(arr, j + 1, high);
    }

    public int partition(int[] arr, int low, int high)
    {
        int pivot = arr[low];
        int i = low + 1;
        int j = high;
        while (i <= j)
        {
            while (i <= j && arr[i] <= pivot)
                i++;
            while (i <= j && arr[j] > pivot)
                j--;
            if (i < j)
                Swap(arr, i, j);
        }
        Swap(arr, low, j);
        return j;
    }

    public void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}

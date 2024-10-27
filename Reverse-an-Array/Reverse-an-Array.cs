public class Solution
{
    public void ReverseArray(int[] arr)
    {
        ReverseArray(arr, 0, arr.Length - 1);
    }

    public void ReverseArray(int[] arr, int start, int end)
    {
        if (start > end)
            return;
        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        ReverseArray(arr, start + 1, end - 1);
    }
}

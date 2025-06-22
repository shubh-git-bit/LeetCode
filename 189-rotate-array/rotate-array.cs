public class Solution 
{
    public void Rotate(int[] nums, int k) 
    {
        int n = nums.Length;
        k %= n;
        Reverse(nums, 0, n - k - 1);
        Reverse(nums, n - k, n - 1);
        Reverse(nums, 0, n - 1);
    }
    private void Reverse(int[] arr, int start, int end)
    {
        int temp = 0;
        while (start < end)
        {
            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}
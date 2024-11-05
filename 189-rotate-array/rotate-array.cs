public class Solution 
{
    public void Rotate(int[] nums, int k) 
    {
        int n = nums.Length;
        k = k % n;
        if (n > 1)
        {
            //Reverse the entire array
            Reverse(nums, 0, n- 1);

            //Reverse till k
            Reverse(nums, 0, k - 1);

            //Reverse from k to last
            Reverse(nums, k, n - 1);
        }
    }
    public void Reverse(int[] nums, int start, int end)
    {
        while(start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp; 
            start++;
            end--;
        }
    }
}
public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        int sum = 0;
        int n = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return ((n * (n + 1)) / 2 - sum);
    }
}
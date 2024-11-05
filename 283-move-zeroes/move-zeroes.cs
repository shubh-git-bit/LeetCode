public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int i = 0;
        if (nums.Length > 1)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != 0)
                {
                    Swap(nums, i, j);
                    i++;
                }
            }
        }
    }
    public void Swap(int[] nums, int a, int b)
    {
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }
}
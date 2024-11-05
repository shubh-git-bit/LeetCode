public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int i = 0;
        if (nums.Length > 1)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != 0)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            for (int j = i;j < nums.Length;j++)
            {
                nums[j] = 0;
            }
        }
    }
}
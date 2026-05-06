public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int slowPtr = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[slowPtr] = nums[i];
                slowPtr++;
            }
        }
        for (int i = slowPtr; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
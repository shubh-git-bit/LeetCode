public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int i = 0;
        int j = 1;
        if (nums.Length > 1)
        {
            for (j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    nums[i + 1] = nums[j];
                    i++;
                }
            }
        }
        else 
            return 1;
        return i + 1;
    }
}
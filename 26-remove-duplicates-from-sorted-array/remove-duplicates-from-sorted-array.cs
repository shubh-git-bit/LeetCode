public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int i = 0;
        int j = 0;
        for(j = 0; j < nums.Length; j++)
        {
            if (nums[j] != nums[i])
            {
                nums[i + 1] = nums[j];
                i++;
            }
        }
        
        return (i + 1);
    }
}
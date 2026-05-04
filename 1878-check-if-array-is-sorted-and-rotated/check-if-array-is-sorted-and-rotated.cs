public class Solution 
{
    public bool Check(int[] nums) 
    {
        byte decreases = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            
            if (nums[(i + 1) % nums.Length] < nums[i])
            {
                decreases++;
            }
        }
        if (decreases <= 1)
            return true;
        else
            return false;
    }
}
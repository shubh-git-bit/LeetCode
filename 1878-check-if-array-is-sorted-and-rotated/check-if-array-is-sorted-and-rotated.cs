public class Solution 
{
    public bool Check(int[] nums) 
    {
       int dips = 0;
       if (nums.Length > 1)
       {
        for (int i = 0;i < nums.Length; i++)
        {
            var next = nums[(i + 1) % nums.Length];
            if (next < nums[i])
                dips++;
        }
       }

        return (dips <= 1); 
    }
}
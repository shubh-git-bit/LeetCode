public class Solution 
{
    public bool Check(int[] nums) 
    {
        int dips = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
                dips++;
        }

        if (nums[nums.Length - 1] > nums[0])
            dips++;
        return dips < 2;
    }
}
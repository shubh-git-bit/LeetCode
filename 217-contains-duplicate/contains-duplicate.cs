public class Solution {
    public bool ContainsDuplicate(int[] nums) 
    {
        var uniqueKeys = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!uniqueKeys.Contains(nums[i]))
                uniqueKeys.Add(nums[i]);
            else
                return true;
        }   
        return false;
    }
}
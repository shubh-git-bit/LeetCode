public class Solution
{
    public int[] TwoSum(int[] nums, int target) 
    {
        SortedDictionary<int, int> complements = new SortedDictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!complements.ContainsKey(target - nums[i]))
            {
                if (!complements.ContainsKey(nums[i]))
                    complements.Add(nums[i], i);
            }
            else
            {
                return new[] { complements[target - nums[i]], i };
            }
        }

        return new int[] { };
    }
}
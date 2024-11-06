public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int currentStreak = 0;
        int maxStreak = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                currentStreak++;
            else
            {
                maxStreak = Math.Max(currentStreak, maxStreak);
                currentStreak = 0;
            }
        }
        return Math.Max(currentStreak, maxStreak);
    }
}
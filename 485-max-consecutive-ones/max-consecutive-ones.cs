public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int currentStreak = 0;
        int maxStreak = 0;
        int i = 0;
        if (nums.Length > 1)
        {
            while (i < nums.Length)
            {
                if (nums[i] == 0)
                {
                    if (maxStreak < currentStreak)
                        maxStreak = currentStreak;
                    currentStreak = 0;
                }
                else if (nums[i] == 1)
                {
                    currentStreak++;
                }
                i++;
            }
            if (maxStreak < currentStreak)
                maxStreak = currentStreak;
            return maxStreak;
        }
        else if (nums.Length == 1 && nums[0] == 0)
            return 0;
        else
            return 1;

    }
}
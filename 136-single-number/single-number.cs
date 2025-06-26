public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        int xorSum = 0;
        foreach (var element in nums)
        {
            xorSum ^= element;
        }
        return xorSum;
    }
}
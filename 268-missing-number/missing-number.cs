public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        int n = nums.Length;
        int totalSum = (n * (n + 1)) / 2;
        int arraySum = 0;
        foreach (var element in nums)
        {
            arraySum += element;
        }
        return (totalSum - arraySum);
    }
}
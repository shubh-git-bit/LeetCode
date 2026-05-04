public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int p1 = 0;
        int p2 = 1;
        while(p2 < nums.Length)
        {
            if (nums[p2] > nums[p1])
            {
                Swap(p1 + 1, p2, nums);
                p2++;
                p1++;
            }
            else
                p2++;
        }
        return (p1 + 1);
    }
    private void Swap(int source, int destination, int[] nums)
    {
        int temp = nums[source];
        nums[source] = nums[destination];
        nums[destination] = temp;
    }
}
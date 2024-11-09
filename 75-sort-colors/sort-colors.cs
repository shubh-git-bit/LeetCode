public class Solution 
{
    public void SortColors(int[] nums) 
    {
        int low = 0;
        int mid = 0;
        int high = nums.Length - 1;
        while (mid <= high)
        {
            if (nums[mid] == 0)
            {
                Swap(nums, mid, low);
                mid++;
                low++;
            }

            else if (nums[mid] == 1)
            {
                mid++;
            }

            else
            {
                Swap(nums, mid, high);
                high--;
            }
        }
    }

    private static void Swap(int[] nums, int a, int b)
    {
        (nums[a], nums[b]) = (nums[b], nums[a]);
    }
}
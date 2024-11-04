public class Solution 
{
    public bool Check(int[] nums) 
    {
        int current = nums[0];
        int index = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (current <= nums[i])
                current = nums[i];
            else
            {
                index = i;
                break;
            }
                
        }

        if (index != 0)
        {
            int[] rotateArray = Rotate(nums, nums.Length - index);
            current = rotateArray[0];
            for (int i = 1; i < rotateArray.Length; i++)
            {
                if (current <= rotateArray[i])
                    current = rotateArray[i];
                else
                    return false;
            }

            return current == rotateArray[^1];
        }
        return current == nums[^1];
    }
    public int[] Rotate(int[] nums, int pos)
    {
        int[] rotateArray = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
            rotateArray[(i + pos) % nums.Length] = nums[i];
        return rotateArray;
    }
}
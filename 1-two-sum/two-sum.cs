public class Solution
{
    public int[] TwoSum(int[] nums, int target) 
    {
        IndexedValues[] indexedArray = new IndexedValues[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            indexedArray[i] = new IndexedValues
            {
               Index = i,
               Value = nums[i]         
            };
        }
        Array.Sort(indexedArray, (a,b) => a.Value.CompareTo(b.Value));
        int start = 0;
        int end = indexedArray.Length - 1;
        while (start < end)
        {
            if (indexedArray[start].Value + indexedArray[end].Value < target)
                start++;
            else if (indexedArray[start].Value + indexedArray[end].Value > target)
                end--;
            else if (indexedArray[start].Value + indexedArray[end].Value == target)
                return new int[]{indexedArray[start].Index, indexedArray[end].Index};
        }
        return new int[]{};
    }
}
public class IndexedValues
{
    public int Value {get; set;}
    public int Index {get; set;}
}
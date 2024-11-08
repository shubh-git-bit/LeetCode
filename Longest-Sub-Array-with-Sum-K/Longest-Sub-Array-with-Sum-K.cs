class Solution 
{
    public int lenOfLongestSubarr(int[] arr, int k) 
    {
        Dictionary<int, int> prefixSum = new Dictionary<int, int>() { [0] = -1 };
        int length = 0;
        int sum = 0;
        int maxLength = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if (!prefixSum.ContainsKey(sum))
                prefixSum.Add(sum, i);
            if (prefixSum.ContainsKey(sum - k))
            {
                length = i - prefixSum[sum - k];
                maxLength = Math.Max(length, maxLength);
            }
        }

        return maxLength;
    }
}

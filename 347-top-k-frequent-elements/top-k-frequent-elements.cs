public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var pq = new PriorityQueue<int, int>();
        var result = new int[k];
        var frequencies = new Dictionary<int, int>();

        foreach (var element in nums)
        {
            if (frequencies.ContainsKey(element))
                frequencies[element]++;
            else
                frequencies.Add(element, 1);
        }
        foreach (var element in frequencies)
        {
            pq.Enqueue(element.Key, element.Value);
            if (pq.Count > k)
                pq.Dequeue();
        }
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = pq.Dequeue();
        }
        return result;
    }
}
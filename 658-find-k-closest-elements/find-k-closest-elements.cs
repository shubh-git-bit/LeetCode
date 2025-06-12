public class Solution 
{
    public IList<int> FindClosestElements(int[] arr, int k, int x) 
    {
        var pq = new PriorityQueue<int, (int, int)>();
        var result = new List<int>();
        int diff = 0;
        foreach (var element in arr)
        {
            diff = Math.Abs(x - element);
            pq.Enqueue(element, (-diff, -element));
            if (pq.Count > k)
                pq.Dequeue();
        }
        while(pq.Count > 0)
            result.Add(pq.Dequeue());
        result.Sort();
        return result;
    }
}
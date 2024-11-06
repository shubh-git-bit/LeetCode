public class Solution
{
    public List<int> findUnion(int[] a, int[] b)
    {
        List<int> result = new List<int>();
        int right = 0;
        int left = 0;
        while (left < a.Length && right < b.Length)
        {
            if (a[left] == b[right])
            {
                result.Add(a[left]);
                left++;
                right++;
            }
            else if (a[left] < b[right])
            {
                result.Add(a[left]);
                left++;
            }
            else
            {
                result.Add(b[right]);
                right++;
            }
        }

        while (left < a.Length)
        {
            if (a[left] > a[left - 1])
                result.Add(a[left]);

            left++;
        }

        while (right < b.Length)
        {
            if (b[right] > b[right - 1])
                result.Add(b[right]);

            right++;
        }

        return result;
    }
};

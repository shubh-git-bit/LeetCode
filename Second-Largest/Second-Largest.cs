public class Solution
{
    public  int getSecondLargest(int[] arr)
    {
        if (arr.Length < 2)
            return -1;
        int first = int.MinValue;
        int second = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > first)
            {
                second = first;
                first = arr[i];
            }

            if (arr[i] > second && arr[i] < first)
                second = arr[i];
        }

        return second == int.MinValue ? -1 : second;
    }
}

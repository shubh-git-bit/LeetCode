public class Solution
{
    bool searchInSorted(int[] arr, int k) 
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (k == arr[mid])
                return true;
            if (k > arr[mid])
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
}

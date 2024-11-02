public class Solution
{
    public void mergeSort(int[] arr, int l, int r)
    {
        if (l == r)
            return;
        int mid = (l + r) / 2;
        mergeSort(arr, l, mid);
        mergeSort(arr, mid + 1, r);
        Merge(arr, l, mid, r);
    }

    public void Merge(int[] arr, int l, int mid, int r)
    {
        List<int> temp = new List<int>();
        int left = l;
        int right = mid + 1;
        //Compare and insert the elements in order
        while (left <= mid && right <= r)
        {
            if (arr[left] <= arr[right])
            {
                temp.Add(arr[left]);
                left++;
            }
            else
            {
                temp.Add(arr[right]);
                right++;
            }
        }
        //If there are remaining elements, insert into temp array
        while (left <= mid)
        {
            temp.Add(arr[left]);
            left++;
        }
        //If there are remaining elements, insert into temp array
        while (right <= r)
        {
            temp.Add(arr[right]);
            right++;
        }
        //Copy the elements into the array
        for (int i = 0; i < temp.Count; i++)
        {
            arr[l + i] = temp[i];
        }
    }
}

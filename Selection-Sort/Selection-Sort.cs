class Solution
{
        //Complete this function
        //Function to sort an array using selection sort algorithm
        public int[] selectionSort(int[] arr, int n)
        {
            int minIndex = 0;
            for (int i = 0; i < n; i++)
            {
                minIndex = i;
                minIndex = select(arr, minIndex);
                if (minIndex != i)
                    Swap(arr, minIndex, i);
            }
        
            return arr;
        }
            
        public int select(int[] arr, int i)
        {
            int minimum = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minimum])
                    minimum = j;
            }
            return minimum;
        }
	public void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
}

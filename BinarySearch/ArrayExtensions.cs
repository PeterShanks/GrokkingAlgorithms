namespace BinarySearch
{
    // Suppose you have a sorted list of 128 names, and you’re searching
    // through it using binary search.What’s the maximum number of
    // steps it would take?
    // Answer = 7 steps

    // Suppose you double the size of the list. What’s the maximum
    // number of steps now?
    // Answer = 8 steps

    // O (log n)
    public static class ArrayExtensions
    {
        public static int? BinarySearch(this int[] items, int elementToSearchFor)
        {
            int low = 0;
            int high = items.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int item = items[mid];

                if (item == elementToSearchFor)
                    return mid;

                if (item < elementToSearchFor)
                    low = mid + 1;
                else 
                    high = mid - 1;
            }

            return null;
        }
    }
}
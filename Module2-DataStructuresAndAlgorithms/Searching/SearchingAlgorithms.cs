using System;

namespace DataStructuresAndAlgorithms.SearchingAlgorithms
{
    /// <summary>
    /// Linear Search: O(n), works on unsorted/sorted arrays
    /// Binary Search: O(log n), requires a SORTED array
    /// </summary>
    class SearchingAlgorithms
    {
        // ---------------- Linear Search ----------------
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        // ---------------- Binary Search (Iterative) ----------------
        static int BinarySearchIterative(int[] arr, int target)
        {
            int low = 0, high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }

        // ---------------- Binary Search (Recursive) ----------------
        static int BinarySearchRecursive(int[] arr, int target, int low, int high)
        {
            if (low > high)
                return -1;

            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                return BinarySearchRecursive(arr, target, mid + 1, high);
            else
                return BinarySearchRecursive(arr, target, low, mid - 1);
        }

        static void Main(string[] args)
        {
            int[] unsorted = { 23, 5, 42, 8, 16, 4 };
            int[] sorted = { 4, 5, 8, 16, 23, 42 };

            int target = 16;

            int linearResult = LinearSearch(unsorted, target);
            Console.WriteLine(linearResult != -1
                ? $"Linear Search: Found {target} at index {linearResult}"
                : "Linear Search: Not found");

            int binaryIterResult = BinarySearchIterative(sorted, target);
            Console.WriteLine(binaryIterResult != -1
                ? $"Binary Search (Iterative): Found {target} at index {binaryIterResult}"
                : "Binary Search: Not found");

            int binaryRecResult = BinarySearchRecursive(sorted, target, 0, sorted.Length - 1);
            Console.WriteLine(binaryRecResult != -1
                ? $"Binary Search (Recursive): Found {target} at index {binaryRecResult}"
                : "Binary Search: Not found");

            // Searching for a value not present
            int missing = 99;
            Console.WriteLine(BinarySearchIterative(sorted, missing) == -1
                ? $"{missing} not found in array (as expected)"
                : "Unexpected result");
        }
    }
}

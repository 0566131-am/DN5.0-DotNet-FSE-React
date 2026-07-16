using System;

namespace DataStructuresAndAlgorithms.Arrays
{
    /// <summary>
    /// Demonstrates basic array operations: traversal, insertion, deletion,
    /// and time-complexity-aware searching.
    /// </summary>
    class ArrayOperations
    {
        // Traverse and print all elements - O(n)
        static void Traverse(int[] arr)
        {
            Console.Write("Array elements: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Insert an element at a given index - O(n) due to shifting
        static int[] Insert(int[] arr, int index, int value)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < index; i++)
                newArr[i] = arr[i];

            newArr[index] = value;

            for (int i = index; i < arr.Length; i++)
                newArr[i + 1] = arr[i];

            return newArr;
        }

        // Delete an element at a given index - O(n) due to shifting
        static int[] Delete(int[] arr, int index)
        {
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i == index) continue;
                newArr[j++] = arr[i];
            }
            return newArr;
        }

        // Linear search - O(n)
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        // Find max and min in a single traversal - O(n)
        static void FindMinMax(int[] arr)
        {
            int min = arr[0], max = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
            Console.WriteLine($"Min: {min}, Max: {max}");
        }

        // Reverse an array in place - O(n)
        static void Reverse(int[] arr)
        {
            int start = 0, end = arr.Length - 1;
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            Traverse(arr);

            arr = Insert(arr, 2, 25);
            Console.WriteLine("After Insertion at index 2:");
            Traverse(arr);

            arr = Delete(arr, 0);
            Console.WriteLine("After Deleting index 0:");
            Traverse(arr);

            int searchResult = LinearSearch(arr, 40);
            Console.WriteLine(searchResult != -1
                ? $"Element found at index: {searchResult}"
                : "Element not found");

            FindMinMax(arr);

            Reverse(arr);
            Console.WriteLine("After Reversing:");
            Traverse(arr);
        }
    }
}

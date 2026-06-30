using System;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    /// <summary>
    /// Implements common sorting algorithms with time complexity notes:
    /// Bubble Sort: O(n^2) worst/avg, O(n) best
    /// Insertion Sort: O(n^2) worst/avg, O(n) best
    /// Heap Sort: O(n log n) all cases
    /// Quick Sort: O(n log n) avg, O(n^2) worst
    /// Merge Sort: O(n log n) all cases
    /// </summary>
    class SortingAlgorithms
    {
        // ---------------- Bubble Sort ----------------
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                    }
                }
                if (!swapped) break; // already sorted - best case O(n)
            }
        }

        // ---------------- Insertion Sort ----------------
        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        // ---------------- Heap Sort ----------------
        static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);
                Heapify(arr, i, 0);
            }
        }

        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                Heapify(arr, n, largest);
            }
        }

        // ---------------- Quick Sort ----------------
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }

        // ---------------- Merge Sort ----------------
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
                arr[k++] = (L[i] <= R[j]) ? L[i++] : R[j++];

            while (i < n1) arr[k++] = L[i++];
            while (j < n2) arr[k++] = R[j++];
        }

        // ---------------- Utility ----------------
        static void Print(string label, int[] arr)
        {
            Console.WriteLine($"{label}: {string.Join(", ", arr)}");
        }

        static void Main(string[] args)
        {
            int[] data = { 64, 34, 25, 12, 22, 11, 90 };

            int[] bubble = (int[])data.Clone();
            BubbleSort(bubble);
            Print("Bubble Sort", bubble);

            int[] insertion = (int[])data.Clone();
            InsertionSort(insertion);
            Print("Insertion Sort", insertion);

            int[] heap = (int[])data.Clone();
            HeapSort(heap);
            Print("Heap Sort", heap);

            int[] quick = (int[])data.Clone();
            QuickSort(quick, 0, quick.Length - 1);
            Print("Quick Sort", quick);

            int[] merge = (int[])data.Clone();
            MergeSort(merge, 0, merge.Length - 1);
            Print("Merge Sort", merge);
        }
    }
}

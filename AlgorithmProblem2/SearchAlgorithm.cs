using System;

namespace SearchAlgorithms
{
    public class SearchAlgorithm
    {
        public static int LinearSearch(int[] array, int valueToSearch) // Временная O(N); Пространственная O(1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valueToSearch)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FastLinearSearch(int[] array, int valueToSearch) // Временная O(N); Пространственная O(1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > valueToSearch)
                {
                    return -1;
                }
                else if (array[i] == valueToSearch)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int BinarySearch(int[] array, int value) // Временная O(log (N)); Пространственная O(1)
        {
            int result = -1;
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == value)
                {
                    result = mid;
                    right = mid - 1;
                }

                else if (array[mid] < value)
                {
                    left = mid + 1;
                }

                else if (array[mid] > value)
                {
                    right = mid - 1;
                }
            }
            return result;
        }

        public static int BinarySearchRecursive(int[] array, int value, int left, int right)
        {

            if (left > right)
            {
                return -1;
            }

            int mid = (left + right) / 2;

            if (array[mid] == value)
            {
                int result = BinarySearchRecursive(array, value, left, mid - 1);

                if (result == -1)
                {
                    return mid;
                }
                else
                {
                    return result;
                }
            }
            else if (array[mid] < value)
            {
                return BinarySearchRecursive(array, value, mid + 1, right);
            }
            else
            {
                return BinarySearchRecursive(array, value, left, mid - 1);
            }

        }

        public static int JumpSearch(int[] array, int valueToSearch) // Временная O(sqrt (N)); Пространственная O(1)
        {
            int jumpStep = (int)Math.Sqrt(array.Length);
            int previousStep = 0;

            while (array[Math.Min(jumpStep, array.Length) - 1] < valueToSearch)
            {
                previousStep = jumpStep;
                jumpStep += (int)Math.Sqrt(array.Length);
                if (previousStep >= array.Length)
                {
                    return -1;
                }

            }
            while (array[previousStep] < valueToSearch)
            {
                previousStep++;
                if (previousStep == Math.Min(jumpStep, array.Length))
                {
                    return -1;
                }
            }

            if (array[previousStep] == valueToSearch)
            {
                return previousStep;
            }
            return -1;
        }

        public static int InterpolationSearch(int[] array, int valueToSearch) // Временная O(log log N); Пространственная O(1)
        {
            if (array[0] == valueToSearch)
            {
                return 0;
            }
            if (array[array.Length - 1] == valueToSearch)
            {
                return array.Length - 1;
            }

            int startIndex = 0;
            int lastIndex = (array.Length - 1);

            while ((startIndex <= lastIndex) && (valueToSearch >= array[startIndex]) &&
                   (valueToSearch <= array[lastIndex]))
            {
                int position = Math.Abs(startIndex + ((valueToSearch - array[startIndex]) * (lastIndex - startIndex) /
                  (array[lastIndex] - array[startIndex])));

                if (array[position] == valueToSearch)
                {
                    return position;
                }

                if (array[position] < valueToSearch)
                {
                    startIndex = position + 1;
                }
                else
                {
                    lastIndex = position - 1;
                }
            }
            return -1;
        }
    }
}


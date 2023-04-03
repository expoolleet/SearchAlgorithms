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

        public static int BinarySearch(int[] array, int valueToSearch) // Временная O(log (N)); Пространственная O(1)
        {
            if (array[0] == valueToSearch)
            {
                return 0;
            }
            if (array[array.Length - 1] == valueToSearch)
            {
                return array.Length - 1;
            }

            int firstIndex = 0;
            int lastIndex = array.Length - 1;

            while (firstIndex <= lastIndex)
            {
                int middleIndex = (firstIndex + lastIndex) / 2;

                if (array[middleIndex] == valueToSearch)
                {
                    return middleIndex;
                }

                else if (array[middleIndex] < valueToSearch)
                {
                    firstIndex = middleIndex + 1;
                }

                else if (array[middleIndex] > valueToSearch)
                {
                    lastIndex = middleIndex - 1;
                }
            }
            return -1;
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


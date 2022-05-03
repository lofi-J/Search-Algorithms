using System;


public class BinarySearch
{
    //with repeat
    public int BinarySearchFunc(int[] array, int target)
    {
        int start = 0;
        int end = array.Length - 1;
        int mid;
        while( start <= end)
        {
            mid = (start + end) / 2;

            if (array[mid] == target)
                return mid;
            else if (array[mid] > target)
                end = mid - 1;
            else
                start = mid + 1;
        }
        return -1;
    }

    //with recursive
    public int BinaraySearchWithRecursive(int[] array, int target, int start, int end)
    {
        if (start > end)
            return -1;

        int mid = (start + end) / 2;
        if (array[mid] == target)
            return mid;
        else if (array[mid] > target)
            return BinaraySearchWithRecursive(array: array, target: target, start: 0, end: mid - 1);
        else
            return BinaraySearchWithRecursive(array: array, target: target, start: mid + 1, end: end);

    }
}
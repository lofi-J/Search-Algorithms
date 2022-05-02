using System;

public class LinearSearch
{
    public int LinearSearchFunc(int[] list, int target)
    {
        int count = 0;
        foreach(int x in list)
        {
            if (x == target)
                return count;
            else
                count++;
        }
        return -1;
    }
}
using System;

public class LinearSearch
{
    public int LinearSearchFunc(int[] list, int target)
    {
        for (int i=0; i<list.Length; i++)
        {
            if (list[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}
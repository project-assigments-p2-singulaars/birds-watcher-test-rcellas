using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        // foreach (int count in birdsPerDay)
        // {
        //     if (count == 0)
        //         return true;
        // }
        // return false;
        return Array.IndexOf(birdsPerDay, 0) != -1;
        // return Array.Exists(birdsPerDay, count => count == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        // int sum = 0;
        // for (int i = 0; i < numberOfDays && i < birdsPerDay.Length; i++)
        // {
        //     sum += birdsPerDay[i];
        // }
        // return sum;
        return birdsPerDay[..Math.Min(numberOfDays, birdsPerDay.Length)].Sum();
    }

    public int BusyDays()
    {
        // int busyDaysCount = 0;
        // foreach (int count in birdsPerDay)
        // {
        //     if (count >= 5)
        //         busyDaysCount++;
        // }
        // return busyDaysCount;
        return Array.FindAll(birdsPerDay,count =>count >= 5).Length;
    }
}
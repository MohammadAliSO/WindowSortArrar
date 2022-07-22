using System;

public class Program
{

    // Main Method
    public static void Main(String[] args)
    {

        int[] a =  { 16,15,14,13,12,10,11,8,9,5,4,6,7,1,56,2 }; 



        for (int i = 0; i < a.Length; i++)
        {
            if ((a.Length - 1) - i == Math.Sqrt(a.Length))
            {
                break;
            }
            var arr= Sort(a[0..(a.Length -i)] , (int)Math.Sqrt(a.Length));


            for (int j = 0; j < a.Length-i; j++)
            {
                a[j] = arr[j];
            }
            
         
        }


        Console.ReadKey();

    }

    static bool WindowSort(int[] arr, int index , int windowsize)
    {
        List<int> windowList = new List<int>();

        for (int i = index; i < arr.Length && i < windowsize + index; i++)
        {
            windowList.Add(arr[i]);
        }

        windowList.Sort();

        for (int i = index; i - index < windowList.Count; i++)
        {
            arr[i] = windowList[i - index];
        }
        return true;
    }

    static int[] Sort(int[] arr , int windowsize)
    {
        for (int i = 0; i<= arr.Length- windowsize; i++)
        {
            WindowSort(arr, i , windowsize);
        }

        return arr;
    }
}


using System;

class CopyArray
{
    static void Main()
    {
        int[] sArray = new int[] { 2, 2, 2, 2 };
        int[] bArray = new int[] { 8, 8, 8, 8, 8, 8, 8, 8 };
        //int[] sArray = new int[] { 3, 3, 3 };
        //int[] bArray = new int[] { 8, 8, 8, 8, 8, 8, 8, 8, 8 };
        int merge = (bArray.Length - sArray.Length) / 2;

        for (int i = 0; i < sArray.Length; i++)
        {
            Console.WriteLine("sArray[" + i + "] = " + sArray[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < bArray.Length; i++)
        {
            Console.WriteLine("bArray[" + i + "] = " + bArray[i]);
        }

        Array.Copy(sArray, bArray, sArray.Length);
        Console.WriteLine("====================================");

        for (int i = 0; i < sArray.Length; i++)
        {
            Console.WriteLine("sArray[" + i + "] = " + sArray[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < bArray.Length; i++)
        {
            Console.WriteLine("bArray[" + i + "] = " + bArray[i]);
        }

        for (int i = 0; i <= sArray.Length; i++)
        {
            bArray[sArray.Length - i] = bArray[sArray.Length - i] + bArray[sArray.Length + merge - i];
            bArray[sArray.Length + merge - i] = bArray[sArray.Length - i] - bArray[sArray.Length + merge - i];
            bArray[sArray.Length - i] = bArray[sArray.Length - i] - bArray[sArray.Length + merge - i];
        }


        Console.WriteLine();

        for (int i = 0; i < bArray.Length; i++)
        {
            Console.WriteLine("bArray[" + i + "] = " + bArray[i]);
        }

        Console.ReadKey();
    }
}

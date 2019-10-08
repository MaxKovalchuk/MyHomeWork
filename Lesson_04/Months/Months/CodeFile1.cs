using System;

class Months
{

    // 31 28 31 30 31 30 31 31 30 31 30 31
    static void Main()
    {
        int[] Months = new int[12];

        for (int i = 0; i < 12; i++)
            Months[i] = (i == 1 ? 28 : (i <= 6 && i % 2 == 0) || (i > 6 && i % 2 != 0) ? 31 : 30);


        for (int i = 0; i < 12; i++)
            Console.Write(Months[i] + "  ");
        Console.ReadLine();
    }
}
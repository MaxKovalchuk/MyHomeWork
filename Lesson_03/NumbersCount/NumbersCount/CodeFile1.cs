using System;

class NumbersCount
{
    static void Main()
    {
        Console.WriteLine("Enter a number :");
        int value;
        while (true)
        {
            value = Convert.ToInt32(Console.ReadLine());
            if (value >= 0)
            {
                break;
            }
            else
            {
                continue;
            }
        }

        int sum = 0;
        int i, j;
        i = j = 0;

        while (value > 0)
        {
            if ((value % 10)% 2 == 0)
            {
                sum += value % 10;
            }

            if ((value % 10) % 3 == 0)
            {
                j++;
            }

            value /= 10;
            i++;
        }

        Console.WriteLine("Amount of numbers is : {0}", i);
        Console.WriteLine("Sum of pair numbers is : {0}", sum);
        Console.WriteLine("Amount of numbers divided completely by 3 is : {0}", j);

        Console.ReadKey();
    }
}
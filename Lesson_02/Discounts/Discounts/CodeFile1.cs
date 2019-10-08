using System;

class Discouts
{
    static void Main()
    {
        decimal sum = 696.00m;
        decimal discount = 0.00m;

        if (sum >= 520.00m)
        {
            discount = 7.00m;
        }
        else if (sum >= 400.00m)
        {
            discount = 5.00m;
        }
        else if (sum >= 300.00m)
        {
            discount = 3.00m;
        }

        Console.WriteLine("Your discount is : {0}. Total to pay : {1}", discount, (sum - (sum / 100) * discount));

            Console.ReadKey();
    }
}
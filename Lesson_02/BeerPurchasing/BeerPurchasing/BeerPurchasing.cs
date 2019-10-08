using System;

class BeerPurchasing
{
    static void Main()
    {
        decimal money = 56.00m;
        decimal Obolon = 7.00m;
        decimal Chernihivske = 20.00m;
        decimal Stella = 30.00m;
        decimal Bud = 45.00m;
        decimal Leffe = 60.00m;
        string beer = "Obolon";
        decimal cost = Obolon;

        Console.WriteLine("You have " + money);

        if (money >= 60.00m)
        {
            beer = "Leffe";
            cost = Leffe;
        }
        else if (money >= 45.00m)
        {
            beer = "Bud";
            cost = Bud;
        }
        else if (money >= 30.00m)
        {
            beer = "Stella";
            cost = Stella;
        }
        else if (money >= 20.00m)
        {
            beer = "Bud";
            cost = Bud;
        }


        if (money >= 7.00m)
        {
            Console.WriteLine("You can buy " + beer);
            Console.WriteLine("Your rest will be : {0}", (money - cost));
        }
        else
            Console.WriteLine("You can not buy any beer");

        Console.ReadKey();
    }
}
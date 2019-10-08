using System;

class GuessNumber
{
    static void Main()
    {
        Random rnd = new Random();
        int value = rnd.Next(0, 100);
        int input;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Try number {0}. Enter your number : ", i);
            input = Convert.ToInt32(Console.ReadLine());

            if (input > value)
            {
                Console.WriteLine("Wrong! My number is lesser.");
            }
            else if (input < value)
            {
                Console.WriteLine("Wrong! My number is bigger.");
            }
            else
            {
                Console.WriteLine("Exactly! You win!");
                break;
            }
            if (i == 5 & input != value)
            {
                Console.WriteLine("Lose!");
            }
        }

        Console.ReadKey();
    }
}

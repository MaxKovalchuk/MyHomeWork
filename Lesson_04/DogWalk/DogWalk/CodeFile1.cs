using System;

class DogWalk
{
    static void Main()
    {
        Random rnd = new Random();
        char[] way = new char[] {'@','_', '_', '_', '_', '_', '_', '_', '_', '_' };
        char KID = '+';
        char BOMB = '*';
        int kid = rnd.Next(1, 10);
        int bomb = rnd.Next(1, 10);
        int HP = 100;
        char KEY, temp;
        int dog = 0;


        while (kid == bomb)
        {
            bomb = rnd.Next(1, 10);
        }

        way[bomb] = BOMB;
        way[kid] = KID;

        Console.WriteLine(" Your way looks like : \n");
        Console.Write("\t");
        for (int i = 0; i < way.Length; i++)
        {
            Console.Write(way[i]);
        }

        Console.WriteLine();

        Console.Write("Enter a movement you want to perform : \n " +
            "d or D - go right, a or A - go left. \n\n" +
            "Every movement costs 5 hit points. \nTry not to waste them =)\n");

        while (HP != 0)
        {
            KEY = Convert.ToChar(Console.ReadLine());

            if (KEY == 'D' | KEY == 'd')
            {
                if (way[dog + 1] == '*')
                {
                    HP -= 45;
                    if(HP <= 0)
                    {
                        Console.WriteLine("Your HP = 0. You lose!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You catch a bomb! You have -40 HP!");
                        way[dog + 1] = way[dog];
                        way[dog] = '_';
                        dog++;
                    }
                    Console.WriteLine("You have " + HP + " HP");
                }
                else if (way[dog + 1] == '+')
                {
                    HP -= 5;
                    Console.WriteLine("Grats! You found a KID, +40 HP!");
                    if (HP >= 60)
                        HP = 100;
                    else
                        HP += 40;
                    Console.WriteLine("You have " + HP + " HP");
                    way[dog + 1] = way[dog];
                    way[dog] = '_';
                    dog++;
                }
                else
                {
                    HP -= 5;
                    Console.WriteLine("You have " + HP + " HP");
                    temp = way[dog];
                    way[dog] = way[dog + 1];
                    way[dog + 1] = temp;
                    dog++;
                }

                Console.Write("\t");
                for (int i = 0; i < way.Length; i++)
                {
                    Console.Write(way[i]);
                }
                Console.WriteLine();

            }
            else if (KEY == 'A' | KEY == 'a')
            {
                if (dog == 0)
                {
                    Console.WriteLine("You can not go left right now!");
                }
                else
                {
                    way[dog - 1] = way[dog];
                    way[dog] = '_';
                    dog--;
                    HP -= 5;
                    Console.WriteLine("You have " + HP + " HP");
                    Console.Write("\t");
                    for (int i = 0; i < way.Length; i++)
                    {
                        Console.Write(way[i]);
                    }
                    Console.WriteLine();
                }
            }
            if (way[9] == '@')
            {
                Console.WriteLine("Congratulations! You win!");
                break;
            }
        }
        
        Console.ReadKey();
    }
}
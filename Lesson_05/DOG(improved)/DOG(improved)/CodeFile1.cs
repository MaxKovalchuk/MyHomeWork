using System;

class DogWalk
{
    static void Main()
    {
        Random rnd = new Random();
        char[][] field = new char[10][];
        for (int i = 0; i < field.Length; i++)
        {
            field[i] = new char[] { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', };
        }

        char KIT = '+';
        char BOMB = '*';
        int HP = 100;
        char KEY;                                           // @ _ _ _ _ _ _ _ _ _   
        int dog_x = 0;                                      // _ _ _ _ _ _ _ _ _ _
        int dog_y = 0;                                      // _ _ _ _ _ _ _ _ _ _
                                                            // _ _ _ _ _ _ _ _ _ _
        for (int i = 0; i < field.Length; i++)              // _ _ _ _ _ _ _ _ _ _       
        {                                                   // _ _ _ _ _ _ _ _ _ _
            int kit = rnd.Next(1, 10);                      // _ _ _ _ _ _ _ _ _ _
            int bomb = rnd.Next(1, 10);                     // _ _ _ _ _ _ _ _ _ _
            field[i][kit] = KIT;                            // _ _ _ _ _ _ _ _ _ _
                                                            // _ _ _ _ _ _ _ _ _ _
            while (kit == bomb)
            {
                bomb = rnd.Next(1, 10);
            }
            field[i][bomb] = BOMB;
        }

        field[0][0] = '@';
        Console.WriteLine(" Your way looks like : \n");

        for (int i = 0; i < field.Length; i++)
        {
            Console.Write("\t");
            for (int j = 0; j < field[i].Length; j++)
            {
                Console.Write(field[i][j]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.Write("Enter a movement you want to perform : \n " +
            "d or D - go right, a or A - go left, W or w - go up, s or S - go down. \n\n" +
            "Every movement costs 5 hit points. \nTry not to waste them =)\n");
        while (HP != 0)
        {
            KEY = Convert.ToChar(Console.ReadLine());
            if (KEY == 'D' | KEY == 'd')
            {
                Console.Clear();
                if (dog_x == 9)
                {
                    field[dog_y][0] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_x = 0;
                    HP -= 5;
                    Console.WriteLine("You have " + HP + " HP");
                }
                else if (field[dog_y][dog_x + 1] == '*')
                {
                    HP -= 45;
                    if (HP <= 0)
                    {
                        Console.WriteLine("Your HP = 0. You lose!");
                        break;
                    }
                    Console.WriteLine("You catch a bomb! You have -40 HP!");
                    field[dog_y][dog_x + 1] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_x++;
                    Console.WriteLine("You have " + HP + " HP");
                }
                else if (field[dog_y][dog_x + 1] == '+')
                {
                    Console.WriteLine("Grats! You found a KIT, +40 HP!");
                    if (HP > 60)
                        HP = 100;
                    else
                        HP += 35;
                    Console.WriteLine("You have " + HP + " HP");
                    field[dog_y][dog_x + 1] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_x++;
                }
                else
                {
                    HP -= 5;
                    Console.WriteLine("You have " + HP + " HP");
                    field[dog_y][dog_x + 1] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_x++;
                }
            }
            else if (KEY == 'A' | KEY == 'a')
            {
                Console.Clear();
                if (dog_x == 0)
                {
                    if (field[dog_y][9] == '*')
                    {
                        Console.WriteLine("You catch a bomb! You have -40 HP!");
                        field[dog_y][9] = field[dog_y][dog_x];
                        field[dog_y][dog_x] = '_';
                        dog_x = 9;
                        HP -= 45;
                        Console.WriteLine("You have " + HP + " HP");
                    }
                    else if (field[dog_y][9] == '+')
                    {
                        if (HP > 60)
                            HP = 100;
                        else
                            HP += 35;
                        Console.WriteLine("Grats! You found a KIT, +40 HP!");
                        field[dog_y][9] = field[dog_y][dog_x];
                        field[dog_y][dog_x] = '_';
                        dog_x = 9;
                        Console.WriteLine("You have " + HP + " HP");
                    }
                    else
                    {
                        field[dog_y][9] = field[dog_y][dog_x];
                        field[dog_y][dog_x] = '_';
                        dog_x = 9;
                        HP -= 5;
                        Console.WriteLine("You have " + HP + " HP");
                    }
                }
                else if (field[dog_y][dog_x - 1] == '*')
                {
                    HP -= 45;
                    if (HP <= 0)
                    {
                        Console.WriteLine("Your HP = 0. You lose!");
                        break;
                    }
                    Console.WriteLine("You catch a bomb! You have -40 HP!");
                    field[dog_y][dog_x - 1] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_x--;
                    Console.WriteLine("You have " + HP + " HP");
                }
                else if (field[dog_y][dog_x - 1] == '+')
                {
                    Console.WriteLine("Grats! You found a KIT, +40 HP!");
                    if (HP > 60)
                        HP = 100;
                    else
                        HP += 35;
                    Console.WriteLine("You have " + HP + " HP");
                    field[dog_y][dog_x - 1] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_x--;
                }
                else
                {
                    field[dog_y][dog_x - 1] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_x--;
                    HP -= 5;
                    Console.WriteLine("You have " + HP + " HP");
                }
            }
            else if (KEY == 'W' | KEY == 'w')
            {
                Console.Clear();
                if (dog_y == 0)
                {
                    if (field[9][dog_x] == '*')
                    {
                        Console.WriteLine("You catch a bomb! You have -40 HP!");
                        field[9][dog_x] = field[dog_y][dog_x];
                        field[dog_y][dog_x] = '_';
                        dog_y = 9;
                        HP -= 45;
                        Console.WriteLine("You have " + HP + " HP");
                    }
                    else if (field[9][dog_x] == '+')
                    {
                        Console.WriteLine("Grats! You found a KIT, +40 HP!");
                        if (HP >= 60)
                            HP = 100;
                        else
                            HP += 35;
                        Console.WriteLine("Grats! You found a KIT, +40 HP!");
                        field[9][dog_x] = field[dog_y][dog_x];
                        field[dog_y][dog_x] = '_';
                        dog_y = 9;
                        Console.WriteLine("You have " + HP + " HP");
                    }
                    else
                    {
                        field[9][dog_x] = field[dog_y][dog_x];
                        field[dog_y][dog_x] = '_';
                        dog_y = 9;
                        HP -= 5;
                        Console.WriteLine("You have " + HP + " HP");
                    }
                }
                else if (field[dog_y - 1][dog_x] == '*')
                {
                    HP -= 45;
                    if (HP <= 0)
                    {
                        Console.WriteLine("Your HP = 0. You lose!");
                        break;
                    }
                    Console.WriteLine("You catch a bomb! You have -40 HP!");
                    field[dog_y - 1][dog_x] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_y--;
                    Console.WriteLine("You have " + HP + " HP");
                }
                else if (field[dog_y - 1][dog_x] == '+')
                {
                    Console.WriteLine("Grats! You found a KIT, +40 HP!");
                    if (HP > 60)
                        HP = 100;
                    else
                        HP += 35;
                    Console.WriteLine("You have " + HP + " HP");
                    field[dog_y - 1][dog_x] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_y--;
                }
                else
                {
                    field[dog_y - 1][dog_x] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_y--;
                    HP -= 5;
                    Console.WriteLine("You have " + HP + " HP");
                }
            }
            else if (KEY == 'S' | KEY == 's')
            {
                Console.Clear();
                if (dog_y == 9)
                {
                    if (field[0][dog_x] == '*')
                    {
                        Console.WriteLine("You catch a bomb! You have -40 HP!");
                        field[0][dog_x] = field[dog_y][dog_x];
                        field[dog_y][dog_x] = '_';
                        dog_y = 0;
                        HP -= 45;
                        Console.WriteLine("You have " + HP + " HP");
                    }
                    else if (field[0][dog_x] == '+')
                    {
                        Console.WriteLine("Grats! You found a KIT, +40 HP!");
                        if (HP > 60)
                            HP = 100;
                        else
                            HP += 35;
                        field[0][dog_x] = field[dog_y][dog_x];
                        field[dog_y][dog_x] = '_';
                        dog_y = 0;
                        Console.WriteLine("You have " + HP + " HP");
                    }
                    else
                    {
                        field[0][dog_x] = field[dog_y][dog_x];
                        field[dog_y][dog_x] = '_';
                        dog_y = 0;
                        HP -= 5;
                        Console.WriteLine("You have " + HP + " HP");
                    }
                }
                else if (field[dog_y + 1][dog_x] == '*')
                {
                    HP -= 45;
                    if (HP <= 0)
                    {
                        Console.WriteLine("Your HP = 0. You lose!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You catch a bomb! You have -40 HP!");
                        field[dog_y + 1][dog_x] = field[dog_y][dog_x];
                        field[dog_y][dog_x] = '_';
                        dog_y++;
                    }
                    Console.WriteLine("You have " + HP + " HP");
                }
                else if (field[dog_y + 1][dog_x] == '+')
                {
                    Console.WriteLine("Grats! You found a KIT, +40 HP!");
                    if (HP > 60)
                        HP = 100;
                    else
                        HP += 35;
                    Console.WriteLine("You have " + HP + " HP");
                    field[dog_y + 1][dog_x] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_y++;
                }
                else
                {
                    HP -= 5;
                    Console.WriteLine("You have " + HP + " HP");
                    field[dog_y + 1][dog_x] = field[dog_y][dog_x];
                    field[dog_y][dog_x] = '_';
                    dog_y++;
                }
            }
            if (HP == 0)
            {
                Console.WriteLine("Your HP = 0. You lose!");
            }
            if (field[9][9] == '@')
            {
                Console.WriteLine("Congratulations! You win!");
                break;
            }
            for (int i = 0; i < field.Length; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
        Console.ReadKey();
    }
}
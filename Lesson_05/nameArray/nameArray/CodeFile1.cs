using System;

class nameArray
{
    static void Main()
    {
        string[][] names = new string[3][];
        names[0] = new string[3];
        names[1] = new string[3];
        names[2] = new string[3];

        for (int i = 0; i < names.Length; i++)
        {
            string temp = Console.ReadLine();
            names[i][0] = temp.Substring(0, temp.IndexOf(" "));
            names[i][1] = temp.Substring(temp.IndexOf(" ") + 1, temp.LastIndexOf(" ") - temp.IndexOf(" ") - 1);
            names[i][2] = temp.Substring(temp.LastIndexOf(" ") + 1, temp.Length - temp.LastIndexOf(" ") - 1);
        }

        Console.WriteLine("Write symbols to search :");
        string search = Console.ReadLine();
        bool s_result = false;

        for (int i = 0; i < names.Length; i++)
        {
            for (int j = 0; j < names[i].Length; j++)
            {
                if (names[i][j].Contains(search))
                {
                    Console.WriteLine("Serch result :");
                    Console.Write(names[i][0] + " " + names[i][1] + " " + names[i][2]);
                    s_result = true;
                }
            }
            Console.WriteLine();
        }

        if(!s_result)
        {
            Console.WriteLine("There is no matches !");
        }

        Console.ReadKey();
    }
}
//    Smorzhevskyi Nazarii Valentynovich
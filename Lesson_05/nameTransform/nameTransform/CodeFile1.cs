using System;

class nameTrasform
{
    static void Main()
    {
        Console.Write("Enter a full name in lower case \n" +
            "1 - surname, 2 - name, 3 - family name");
        Console.WriteLine();
        string fullname = Console.ReadLine();

        int firstSpace = fullname.IndexOf(" ");

        string surname = fullname.Substring(0, firstSpace);

        int secondSpace = fullname.LastIndexOf(" ");

        string name = fullname.Substring(firstSpace + 1, 1);

        string family_name = fullname.Substring(secondSpace + 1, 1);

        char[] first_symbol = surname.ToCharArray();
        Console.WriteLine(Char.ToUpper(first_symbol[0]) + fullname.Substring(1, firstSpace) + " "
            + name.ToUpper() + ". " + family_name.ToUpper() + ".");

        Console.ReadKey();
    }
}
//     smorzhevkyi nazarii valentinovich
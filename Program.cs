using System;

class Program
{
    static void Main()
    {
        // Foydalanuvchidan sonni kiritishni so'raymiz
        Console.Write("Sonni kiriting: ");
        int x = int.Parse(Console.ReadLine());

        // Foydalanuvchidan stringni kiritishni so'raymiz
        Console.Write("Stringni kiriting: ");
        string str = Console.ReadLine();

        // Agar x soni string uzunligidan katta bo'lsa, stringni katta harflarga o'giramiz
        string result;
        if (x > str.Length)
        {
            result = str.ToUpper();
        }
        else
        {
            result = str.ToLower();
        }

        // Natijani consolega chiqaramiz
        Console.WriteLine(result);
    }
}

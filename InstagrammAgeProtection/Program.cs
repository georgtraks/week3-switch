using System;

namespace InstagrammAgeProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma sünniaasta");
            int YearOfBitrh = Convert.ToInt32(Console.ReadLine());

            if (YearOfBitrh > 2008)
            {
                Console.WriteLine("oled liiga noor, et kontot luua.");
            }
            else if (YearOfBitrh < 2008)
            {
                Console.WriteLine("oled piisavalt vana, et luuakonto.");
            }
            else
            {
                Console.WriteLine("oled piisavalt vana, et luuakonto.");
            }







        }
    }
}

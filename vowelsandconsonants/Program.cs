using System;

namespace vowelsandconsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tähte
            //programm kotrollib, kas sisestatud täht on
            //täishäälik või kaashäälik
            //kui sisestatud täht on täishäälik - programm kuvab
            //"täishäälik"
            //kui sisestatud täht on kaashäälik
            //programm kuvab "kaashäälik"


            Console.WriteLine("sisesta täht");
            char usercharecter = Convert.ToChar(Console.ReadLine().ToLower());

            switch (usercharecter)
            {
                case 'a':
                    Console.WriteLine("täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("täishäälik");
                    break;

                default:
                    Console.WriteLine("kaashäälik");
                    break;



                    Console.WriteLine("kena päeva!");
            }
        }  
    }
}

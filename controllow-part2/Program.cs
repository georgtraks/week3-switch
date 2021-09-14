using System;

namespace controllow_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi
            //programm võrdleb sisustatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234,
            //programm kuvab konsoolis"tere tulemast"!
            //kui sisustatud PIN on vale, programm kuvab konsoolis 
            //"vale PIN. proovi uuesti"

            Console.WriteLine("sisesta pin-kood.");

            int userPIN = Convert.ToInt32(Console.ReadLine());

            /*if(userPIN == 1234) //!= ei võrdu
            {
                Console.WriteLine("proovi uuesti!");
            }
            else
            {
                Console.WriteLine("tere tulemast!");
            }*/


        }
    }
}

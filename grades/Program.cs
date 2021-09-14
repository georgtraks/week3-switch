using System;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mis hinde sa said?");
            int hinne = Convert.ToInt32(Console.ReadLine());

          switch(hinne)
          {
                case 5:
                    Console.WriteLine("suurepärane");
                    break;
                case 4:
                    Console.WriteLine("väga hea");
                    break;
                case 3:
                    Console.WriteLine("hea");
                    break;
                case 2:
                    Console.WriteLine("rahuldav");
                    break;
                case 1:
                    Console.WriteLine("puudulik");
                    break;
                default:
                    Console.WriteLine("korda kursust!");
                    break;











            }     
            
            
            
            
            
            /*if (hinne == 5)
            {
                Console.WriteLine("suuremärane!");
            }
            else if (hinne == 4)
            {
                Console.WriteLine("väga hea");
            }
            else if (hinne == 3)
            {
                Console.WriteLine("hea");
            }
            else if (hinne == 2)
            {
                Console.WriteLine("rahuldav");
            }
            else if (hinne == 1)
            {
                Console.WriteLine("puudulik");
            }
            else
            {
                Console.WriteLine("puudulik");
            }*/


                













        }
    }
}

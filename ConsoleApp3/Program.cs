using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string inputnumber = Console.ReadLine();

            int inputnumber2 = Convert.ToInt32(inputnumber);

            if (0 < inputnumber2)
            { 
   
                for (int i = 0; i < inputnumber2; i++) 
                {
                    
                    Console.WriteLine(i);


                }

                Console.WriteLine(inputnumber2);



            }    
            else
            {

                Console.Write("Ошибка");


            }

            int inputnumber3;


            
        }
    }
}

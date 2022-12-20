using System;

namespace prime_number_task_discrete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE FIRST NUMBER");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE SECOND NUMBER");
            int secondnumber = int.Parse(Console.ReadLine());

            for (int i = firstnumber; i <= secondnumber; i++)
            {
                if (i == 1) { continue; }
                bool isprime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0  )


                    { 
                        isprime = false;
                        break;


                    }
                    
                        
                    
                    else
                    {
                        isprime = true;

                    }


                }
                if (isprime == true)
                {
                    Console.WriteLine("THE NUMBER {0} IS PRIME", i);
                }



            }



        }
    }
}


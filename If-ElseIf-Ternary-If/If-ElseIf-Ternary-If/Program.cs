using System;

namespace IfElseIfTernaryIf
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            
            //Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number%2 == 1)
            {
                Console.WriteLine("Weird");

            }
            else if(number%2 == 0 && number >=2 && number <= 5 ){
                Console.WriteLine("Not Weird");
            }

            else if (number % 2 == 0 && number >= 6 && number <= 20)
            {
                Console.WriteLine("Weird");
            }

            else if (number % 2 == 0 && number > 20 )
            {
                Console.WriteLine("Not Weird");
            }




        }
    }
}

/*
Given an integer, , perform the following conditional actions:
If is odd, print Weird ****
If  is even and in the inclusive range of 2 to 5, print Not Weird *****
If  is even and in the inclusive range of 6 to ,20 print Weird ********
If  is even and greater than 20, print Not Weird
Complete the stub code provided in your editor to print whether or not  is weird. */
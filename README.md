### Day-3-Intro-to-Conditional-Statements
HackerRank PrepareTutorials30 Days of CodeDay 3: Intro to Conditional Statements

#### Task

> Given an integer,n , perform the following conditional actions:

> If n is odd, print Weird

> If n is even and in the inclusive range of 2 to 5 , print Not Weird

> If n is even and in the inclusive range of 6 to 20 , print Weird

> If n is even and greater than 20 , print Not Weird

> Complete the stub code provided in your editor to print whether or not n is weird.

<img width="977" alt="Ekran Resmi 2022-05-19 18 22 59" src="https://user-images.githubusercontent.com/105243448/169335424-8a0dd3e2-58ce-4e31-900c-1d3cdf665a9c.png">


```
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

```



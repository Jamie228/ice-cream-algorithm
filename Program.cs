using System;

namespace ice_cream_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = 1;
            int strawberry = 0;
            int chocolate = 0;
            int vanilla = 0;

            int userResponse = 0;

            bool consensusReached = false;

            while (consensusReached == false) {

                while (inputCount < 11) {
                    Console.WriteLine("Select your ice cream flavour");
                    Console.WriteLine("1. Vanilla");
                    Console.WriteLine("2. Chocolate");
                    Console.WriteLine("3. Strawberry");
                    userResponse = Convert.ToInt32(Console.ReadLine());

                    if (userResponse == 1) {
                        vanilla ++;
                    }

                    else if (userResponse == 2) {
                        chocolate ++;
                    }

                    else if (userResponse == 3) {
                        strawberry ++;
                    }

                    inputCount ++;
                }

                Console.WriteLine("Survey Complete");
                Console.WriteLine("Results:");
                Console.WriteLine("Vanilla: " + vanilla);
                Console.WriteLine("Chocolate: " + chocolate);
                Console.WriteLine("Strawberry: " + strawberry);

                if (vanilla == 10 || chocolate == 10 || strawberry == 10) {
                    Console.WriteLine("Consensus Reached! Congratulations!");
                    consensusReached = true;
                }

                else {
                    Console.WriteLine("No consesnsus reached - try again");
                    consensusReached = false;
                    inputCount = 1;
                    chocolate = 0;
                    strawberry = 0;
                    vanilla = 0;
                    Console.WriteLine();
                }

            }

            Console.ReadKey(true);
        }
    }
}

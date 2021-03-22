using System;
using System.Diagnostics;

namespace Collatz_Conjecture {
    class Program {
        static void Main(string[] args) {
        
            bool is_number_invaid = true;
            long num = 0;
            int steps = 0;
            long starting_num = 0;
            long largest_num = 0;
            
            // Validating Input
            while(is_number_invaid) {           
                try {
                
                    Console.Write("Enter a number greater than 0: ");

                    num = Convert.ToInt64(Console.ReadLine());
                    if(num > 0) {
                        is_number_invaid = false;
                    }
                } catch {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            starting_num = num;

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            while(num > 1) {
            
                steps++;

                if(num > largest_num) { largest_num = num; }

                if(num % 2 == 0) { 
                    num /= 2; 
                } else {
                    num *= 3;
                    num++;
                }

                Console.WriteLine(steps + ". " + "Current value: " + num);               
            }

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{00}", ts.Milliseconds);

            Console.WriteLine("\nIt took " + steps + " steps to go from " + starting_num + " to " + num);
            Console.WriteLine("This was calculated in: " + elapsedTime + " Milliseconds.");
            Console.WriteLine("The largest number reached during calculation was: " + largest_num);

        }
    }
}

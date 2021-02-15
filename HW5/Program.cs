using System;
using System.Collections.Generic;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            var primes = new List<int> { 2, 3 };
            int sieveNumber = 3;
            var factors = new List<int> { };

            while (input != 0 )
            {
                Console.Write("Enter a positive number (or press 0 to quit): ");
                input = Int32.Parse(Console.ReadLine());
                if (input < 0)
                {
                    Console.WriteLine("Invalid input!");
                } else if (input == 1)
                {
                    Console.WriteLine("1 = 1");
                    Console.WriteLine();
                } else
                {
                    Console.Write(input + " = ");
                    while (input > 1)
                    {
                        bool primeDivisionFlag = false;
                        foreach (int prime in primes)
                        {
                            if (input % prime == 0)
                            {
                                factors.Add(prime);
                                input /= prime;
                                primeDivisionFlag = true;
                            }
                        }

                        if (primeDivisionFlag == false)
                        {
                            sieveNumber += 2;
                            bool sievePrimeFlag = false;
                            foreach (int prime in primes)
                            {
                                if (sieveNumber % prime == 0)
                                {
                                    sievePrimeFlag = true;
                                }
                            }

                            if (!(sievePrimeFlag))
                            {
                                primes.Add(sieveNumber);
                                if (input % sieveNumber == 0)
                                {
                                    factors.Add(sieveNumber);
                                    input /= sieveNumber;
                                }
                            }
                        }                        
                    }
                    for (int i = 0; i <= factors.Count - 1; i++)
                    {
                        Console.Write(factors[i]);
                        if (i != factors.Count - 1)
                        {
                            Console.Write(" x ");
                        }
                    }

                    factors.Clear();
                    Console.WriteLine();
                    Console.WriteLine();

                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}

using System;
using System.Collections.Generic;
using PrimeFinder;

namespace PrimeTime
{
public class program
{
  public static void Main()
  {
      Console.WriteLine("Give me a number, and I will tell you all the primes leading up to it.");
      int userNumber = int.Parse(Console.ReadLine());
      List<int> primes = CPrimeFinder.FindPrimes(userNumber);

      foreach (int num in primes)
      {
        Console.WriteLine(num);
      }

    }
  }

}
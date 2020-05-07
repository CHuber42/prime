using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFinder{
  public class CPrimeFinder
  {
    
    public static void FindPrimes(int userNumber)
    {
      IEnumerable<int> numbers = from value in Enumerable.Range(2, userNumber - 1) select value;

      List<int> distinct = numbers.ToList();

      foreach (int value in distinct)
      {
        while (value <= userNumber){

        }
      }
    }
  }
}
//IEnumerable<int> numbers = Enumerable.Range(0, 10);
//var evens = from num in numbers select num;


// for (all items in enumlist)
// {
//   take item, add self. 
//   remove new result from the enum list
//   repeat until we reach usernum
// }

// Console.Writeline() all multiples of 2 between 2 and 21;
// List<int> input = new List<int>();
// two = 2;
// foreach (int two in input )
// {
  
// }
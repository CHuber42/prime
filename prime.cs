using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFinder{
  public class CPrimeFinder
  {
    
    public static List<int> FindPrimes(int userNumber)
    {
      IEnumerable<int> numbers = from value in Enumerable.Range(2, userNumber - 1) select value;

      List<int> distinct = numbers.ToList();

      for (int index = 0; index < distinct.Count; index++)
      {
        int removeNum = distinct[index];
        int startNum = distinct[index];
        while (removeNum <= userNumber)
        {
          removeNum += startNum;
          distinct.Remove(removeNum);
        }
      }
      return distinct;
    }
  }
}

using System;

namespace Searching
{
  public class LinearSearch
  {
    public int search(int[] arrayOfNumber, int numberToFind)
    {
      int lengthOfArray = arrayOfNumber.Length;

      for (int i = 0; i < lengthOfArray; i++)
      {
        if (arrayOfNumber[i] == numberToFind)
        {
          return i;
        }
      }
      
      return -1;
    }
  }
  
  public class Program
  {
    public static void Main(string[] args)
    {
      int[] arrayOfNumber = { 22, 33, 44, 10, 50 };
      int numberToFind = 10;

      // Linear Search Algorithm
      LinearSearch linearSearch = new LinearSearch();
      int linearSearchResult = linearSearch.search(arrayOfNumber, numberToFind);
      
      Console.WriteLine(linearSearchResult);
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giraffe
{
  class Program
  {
    static void Main(string[] args)
    {
      string phrase = "Giraffe Academy" + " is cool";
      Console.WriteLine(phrase.Length);

      char[] helloChars = { 'h', 'e', 'l', 'l', 'o' };
      string helloStr = new string(helloChars);

      Console.WriteLine(helloStr.Substring(1, 3));

      Console.ReadLine();
    }
  }
}

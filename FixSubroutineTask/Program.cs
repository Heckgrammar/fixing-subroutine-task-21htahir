// incorrect code:
//﻿namespace FixSubroutineTask
//{
//    internal class Program
  //  {
    //    static void Main(string[] args)
      //  {
        //    for(int i = 8;i >= 0; i++) {
          //      Console.WriteLine(diffCurrencies(i));            
            //}
        //}
        //static string diffCurrencies(int x)
        //{
          //  string[] currencies = { "baht", "dollar", "euro", "koruna", "lira", "rand", "rupee", "yen" };
// return currencies[1];
//
  //      }
 //   }
//}

//corrected code
namespace FixSubroutineTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i >= 0; i--) 
            {
                Console.WriteLine(DiffCurrencies(i));
            }
        }

        static string DiffCurrencies(int x)
        {
            string[] currencies = { "baht", "dollar", "euro", "koruna", "lira", "rand", "rupee", "yen" };

            if (x >= 0 && x < currencies.Length) 
            {
                return currencies[x];  
            }
            else
            {
                return "Invalid index"; 
            }
        }
    }
}


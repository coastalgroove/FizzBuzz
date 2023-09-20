using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace FizzBuzz
{
    internal class Program
    {

        public static string FBChallenge(int tmpNbr)
        {
            if (tmpNbr %3 ==0  &&  tmpNbr %5 ==0) 
            {
                return "fizzbuzz";
            }
            else if (tmpNbr %3 == 0) 
            {
                return "fizz";
            }
            else if (tmpNbr %5 == 0) 
            {
                return "buzz";
            }
            else
            {
                return "nobuzz";
            }
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter an integer> ");
            int tmpNum = int.Parse((Console.ReadLine()));
            Console.WriteLine(FBChallenge(tmpNum));


        }
    }
}
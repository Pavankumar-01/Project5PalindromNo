using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5PalindromNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rem, sum = 0, temp;
            Console.Write("Enter the Number to Check : ");
            n = Convert.ToInt16(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = (sum * 10) + rem;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Entered Number is Palindrome\n");
            else
                Console.Write("Entered Number is not Palindrome\n");
        }
    }
}

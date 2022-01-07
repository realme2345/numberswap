using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raja_project
{
    internal class NumberSwap
    {
        public static void ReadingInputFromUser()
        {
            Console.WriteLine(" enter a values of first number ");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter a second number ");
            int second=Convert.ToInt32(Console.ReadLine());
            NumberSwap Swap=new NumberSwap();
            Swap.SwapValues( first, second);
        }
        public void SwapValues(int first,int second)
        {
            int temp=0;
            Console.WriteLine("Before swapping first={0} second={1}", first, second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After swapping first={0} second={1}", first, second);
         }
    }
}

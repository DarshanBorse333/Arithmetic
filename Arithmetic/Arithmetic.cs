using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticDemo
{
    internal class Arithmetic
    {

        public int A { get; set; }

        public int B { get; set; }


        public void Add(int num1, int num2)  //parameters and arguments, accpeting multiple parameter
        {
            int result = num1 + num2;   
            //Console.WriteLine("Addition of " +num1+ " and " +num2+ " is = " +result );
            Console.WriteLine($"Addition of {num1} and {num2} is = {result}");
        }

        //function complex arguments or parameters 

        public void Sub(Arithmetic arth)
        {
            int result = arth.A - arth.B;
            Console.WriteLine($"Substraction of {arth.A} and {arth.B} is = {result}");
        }

        public void Mul(int num1, int num2, out int result)
        {
            result = num1 * num2;
        }

        public void Div(int num1 , int num2, out int result)
        {
            result = num1 / num2;
        }
    }
}

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

        ////function complex arguments or parameters 

        public void Sub(Arithmetic arth)
        {
            int result = arth.A - arth.B;
            Console.WriteLine($"Substraction of {arth.A} and {arth.B} is = {result}");
        }


        //// Output parametre
        public void Mul(int num1, int num2, out int result)
        {
            result = num1 * num2;
        }

        public void Div(int num1 , int num2, out int result)
        {
            result = num1 / num2;
        }

        ////output formal parameter
        
        public void Mul1(int Num1, int Num2, out int result1)
        {
            result1 = Num1 * Num2;
        }

        //// input output parameters / ref
        

        public void Div1(int a , int b, ref int resultnew)
        {
            resultnew = resultnew + b / a;
        }

        public int Mod(int Num1, int Num2)
        {
            int result = Num1 % Num2;
            return result;
        }

        public int ArithmeticOperations(int a, int b,out int SubtractionResult, out int MultiplicationResult,
                                        out int DivisionResult, out int Modresult)
        {
            int AdditionResult = a + b;
            SubtractionResult = a - b;
            MultiplicationResult = a * b;
            DivisionResult = a / b;
            Modresult = a % b;

            return AdditionResult;
        }

        public int ArithmeticOperations1(int x, int y, out int SubResult, out int MulResult, out int DivResult,
                                         out int ModResult1)
        {
            int AddResult = x + y;
            SubResult = x - y;
            MulResult = x * y;
            DivResult = x / y;
            ModResult1 = x % y;

            return AddResult;
        }
    }
}

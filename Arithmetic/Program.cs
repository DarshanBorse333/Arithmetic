using ArithmeticDemo;

public class Program
{
    public static void Main()
    {
        ////Arithmetic arithmetic = new Arithmetic();
        ////arithmetic.Add(20,10);



        Arithmetic arithmetic1 = new Arithmetic();
        arithmetic1.A = 20;
        arithmetic1.B = 10;

        Arithmetic arithmetic2= new Arithmetic();
        arithmetic2.Sub(arithmetic1);




        int result;

        arithmetic2.Mul(10, 20, out result);
        Console.WriteLine($"Multiplication of 10 and 20 is {result}");

        arithmetic2.Div(20, 5, out result);
        Console.WriteLine($"Division of 20 and 5 is {result}");




        int result1;
        int Num1 = 10, Num2 = 20;

        // //Actual parameter
        Arithmetic arithmetic5 = new Arithmetic();
        arithmetic5.Mul1(Num1, Num2, out result1);
        Console.WriteLine($"Multiplication of {Num1} & {Num2} is {result1} ");


        int resultnew = 2;

        arithmetic5.Div1(Num1, Num2, ref resultnew);
        Console.WriteLine($"Result = {resultnew}");



         int Modresult = arithmetic5.Mod(100, 10);
         Console.WriteLine(Modresult);




        int AdditionResult = arithmetic5.ArithmeticOperations(20, 10, out int SubtractionResult, out int MultiplicationResult, 
                               out int DivisionResult, out int ModResult);
        Console.WriteLine($"Addition = {AdditionResult} Subtraction = {SubtractionResult} " +
                          $" Multiplication = {MultiplicationResult} Division = {DivisionResult}" +
                          $"Mod =  {ModResult}");



        int AddResult = arithmetic5.ArithmeticOperations1(30, 20, out int SubResult, out int MulResult,
                          out int DivResult, out int ModResult1);
        Console.WriteLine($"Addition = {AddResult} Subtraction = {SubResult} Multiplication = {MulResult} " +
                          $"Division = {DivResult} Mod = {ModResult1}");
    } 
}
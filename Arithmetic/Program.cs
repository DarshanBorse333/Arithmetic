using ArithmeticDemo;

public class Program
{
    public static void Main()
    {
        //Arithmetic arithmetic = new Arithmetic();
        //arithmetic.Add(20,10);



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
    } 
}
namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                divideByZero(5);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\nCan't divide by zero!");
            }
            //catch all
            catch (Exception e)
            {
                Console.WriteLine("\n:(");
            }
        }
        
        static int divideByZero(int x)
        {
            return x / 0;
        }
    }
}

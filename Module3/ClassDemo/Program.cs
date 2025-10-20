/* 
Author: Lauren Holmgren
Date: 10/19/2025
Assignment: PA3
*/

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Hilbert", "123 NE Vilbert St", 0067);
            Student student2 = new Student("Bilbert");
            Student student3 = new Student();

            Console.WriteLine();
            student1.PrintState();
            student2.PrintState();
            student3.PrintState();
            Console.WriteLine();
        }
    }
}

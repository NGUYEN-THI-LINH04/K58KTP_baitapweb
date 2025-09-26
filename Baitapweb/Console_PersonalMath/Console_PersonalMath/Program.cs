using System;
using PersonalMathLib;

namespace Console_PersonalMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PersonalMath - Console (LINH2025)";
            Console.Write("Nhap so A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so B: ");
            int b = int.Parse(Console.ReadLine());

            MathTool tool = new MathTool();
            tool.PersonalSignature = "LINH Nguyen (LINH2025)";
            tool.InputA = a;
            tool.InputB = b;

            string result = tool.ComputeSummary();
            Console.WriteLine("\nKet qua:");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}

using System;
namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter (5) grades: ");//separated by new line
            double grades1 = Convert.ToDouble(Console.ReadLine());
            double grades2 = Convert.ToDouble(Console.ReadLine());
            double grades3 = Convert.ToDouble(Console.ReadLine());
            double grades4 = Convert.ToDouble(Console.ReadLine());
            double grades5 = Convert.ToDouble(Console.ReadLine());

            double average = (grades1+grades2+grades3+grades4+grades5)/5; //computes average
            int roundedOffAverage = (int)Math.Round(average);//round off to whole number

            Console.WriteLine("The average is " + average + " and round off to " + roundedOffAverage);
        }
    }
}//made by January Toribio Jr
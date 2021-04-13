using System;

namespace Calculator_using_Polymorphism
{

    public class PerformCalculation
    {
        private double[] num;
        public virtual double[] InputNumbers()
        {
            Console.WriteLine("Enter how many numbers you want to Evaluate? ");
            num = new double[Convert.ToInt32(Console.ReadLine())];
            for(int i=0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
        public virtual double[] InputNumbers(int a, int b)   // Overloaded Function
        {
            num = new double[2];
            num[0] = a;
            num[1] = b;
            return num;
        }
        public virtual double Sum()
        {
            return 0;
        }
        public virtual double Products()
        {
            return 0;
        }
        public virtual double Subtraction()
        {
            return 0;
        }
        public virtual double DivideNow(int a,int b)
        {
            return 0;
        }
    }

    //Functions Overriding in below classes!
    public class Add : PerformCalculation
    {
        public override double[] InputNumbers()
        {
            return base.InputNumbers();
        }
        public override double Sum()
        {
            double sum = 0;
            double[] numbers = InputNumbers();
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        
    }
    public class Product : PerformCalculation
    {
        public override double[] InputNumbers()
        {
            return base.InputNumbers();
        }
        public override double Products()
        {
            double prod = 1;
            double[] numbers = InputNumbers();
            for (int i = 0; i < numbers.Length; i++)
            {
                prod *= numbers[i];
            }
            return prod;
        }
    }
    public class Difference : PerformCalculation
    {
        public override double[] InputNumbers()
        {
            return base.InputNumbers();
        }
        public override double Subtraction()
        {
            double diff = 0;
            double[] numbers = InputNumbers();
            for (int i = 0; i < numbers.Length; i++)
            {
                diff -= numbers[i];
            }
            return diff;
        }
    }
    public class Division : PerformCalculation
    {
        public override double[] InputNumbers(int a,int b)
        {
            return base.InputNumbers(a, b);
        }
        public override double DivideNow(int a,int b)
        {
            double[] numbers=InputNumbers(a,b);
            return numbers[0] / numbers[1];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
       
            PerformCalculation p;
            p = new Product();
          
            Console.WriteLine(p.Products());
        }
    }

}

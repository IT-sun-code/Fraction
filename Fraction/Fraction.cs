using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionWork
{
    public class Fraction
    {
        public double Numerator { get; set; } = 0;

        private double denominator;
        public double Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                    throw new DivideByZeroException("Denominator must be > 0 or < 0");
                else denominator = value;
            }
        }

        public int Integer { get; set; } = 0;


        public Fraction()
        {
            Numerator = 1.1;
            Denominator = 2.2;
            Integer = 3;
        }

        public Fraction(Fraction fraction)
        {
            Numerator = fraction.Numerator;
            Denominator = fraction.Denominator;
            Integer = fraction.Integer;
        }

        public Fraction(double Numerator, double Denominator, int Integer)
        {
            this.Numerator = Numerator;
            this.Denominator = Denominator;
            this.Integer = Integer;
        }

        public void Input()
        {
            Numerator = Convert.ToDouble(Console.ReadLine());
            Denominator = Convert.ToDouble(Console.ReadLine());
            Integer = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Fraction = {Numerator}/{Denominator} \n");
        }
        public string IsFractionEquals(Fraction fraction) //Проверка на равенство дробей
        {
            if (Numerator == fraction.Numerator && Denominator == fraction.Denominator)
            {
                return $"True";
            } else if (Numerator / Denominator == fraction.Numerator / fraction.Denominator)
            {
                return $"True";
            } else
            {
                return $"False";
            }
        }

        public string GetMultiplication(Fraction fraction) //Умножение дроби на другую дробь
        {
            return $"{Numerator * fraction.Numerator}/{Denominator * fraction.Denominator}";
        }

        public string GetDivision(Fraction fraction) //Деление дроби на другую дробь
        {
            return $"{Numerator * fraction.Denominator}/{Denominator * fraction.Numerator}";
        }

        public string GetSum(Fraction fraction) //Сумма дробей
        {
            if (Denominator != fraction.Denominator)
            {
                return $"{((Numerator * fraction.Denominator) + (Denominator * fraction.Numerator))}/{Denominator * fraction.Denominator}";
            } else
            {
                return $"{Numerator + fraction.Numerator}/{Denominator}";
            }
        }

        public string GetDifference(Fraction fraction) //Разница между дробями
        {
            {
                if (Denominator != fraction.Denominator)
                {
                    return $"{((Numerator * fraction.Denominator) - (Denominator * fraction.Numerator))}/{Denominator * fraction.Denominator}";
                }
                else
                {
                    return $"{Numerator - fraction.Numerator}/{Denominator}";
                }
            }
        }

        public string GetMultiplicationWithInteger() //Умножение дроби на целое число
        {
        return $"{Numerator * Convert.ToDouble(Integer)}/{Denominator}";
        }

        public string GetSumWithInteger() //Сложение дроби с целым числом
        {
            return $"{Convert.ToDouble(Integer) * Denominator + Numerator}/{Denominator}";
        }

        static void Main(string[] args)
        {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(2.1, 4.2, 1);
        Console.WriteLine("Insert Fraction1 parameters and an integer " + "\n");
        fraction1.Input();
        Console.WriteLine("Fraction1 parameters are \n");
        fraction1.Print();
        Console.WriteLine("Fraction2 parameters are \n");
        fraction2.Print();

        Console.WriteLine($"Is fraction1 equals fraction2 = {fraction1.IsFractionEquals(fraction2)} \n");
        Console.WriteLine($"Multiplication with fraction2 = {fraction1.GetMultiplication(fraction2)} \n");
        Console.WriteLine($"Division by fraction2 = {fraction1.GetDivision(fraction2)} \n");
        Console.WriteLine($"Sum with fraction2 = {fraction1.GetSum(fraction2)} \n");
        Console.WriteLine($"Difference with fraction2 = {fraction1.GetDifference(fraction2)} \n");
        Console.WriteLine($"Multiplication with an integer = {fraction1.GetMultiplicationWithInteger()} \n");
        Console.WriteLine($"Sum with an integer = {fraction1.GetSumWithInteger()} \n");

        Console.ReadKey();
        }
    }
}

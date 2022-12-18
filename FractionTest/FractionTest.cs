using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FractionWork;

namespace FractionTest
{
    [TestClass]
    public class FractionTest
    {
        [TestMethod] //Тест выводит ошибку при введении значения 0 для знаменателя
        public void Set_Fraction_With_Invalid_Denominator_Should_Throw_DivideByZeroException()
        {
            //Arrange
            double Denominator = 0;
            Fraction fraction = new Fraction();

            //Act and Assert
            Assert.ThrowsException<System.DivideByZeroException>(() => fraction.Denominator = Denominator);
        }

        [TestMethod] //Тест для сложения дроби и целого числа
        public void Fraction_With_Valid_Denominator_Get_Sum_With_Integer()
        {
            //Arrange
            double Denominator = 2.2;
            string expected = $"7,7/2,2";
            Fraction fraction = new Fraction();

            //Act
            fraction.Denominator = Denominator;
            string actual = fraction.GetSumWithInteger();

            //Assert
            Assert.AreEqual(expected, actual, "Sum with an integer wasn't calculated correctly");
        }

        [TestMethod] //Тест для умножения дроби на целое число
        public void Fraction_With_Valid_Denominator_Get_Multiplication_With_Integer()
        {
            //Arrange
            double Denominator = -2.2;
            string expected = $"3,3/-2,2";
            Fraction fraction = new Fraction();

            //Act
            fraction.Denominator = Denominator;
            string actual = fraction.GetMultiplicationWithInteger();

            //Assert
            Assert.AreEqual(expected, actual, "Multiplication with an integer wasn't calculated correctly");
        }

        [TestMethod] //Тест для умножения дроби на другую дробь
        public void Fraction_With_Valid_Denominator_Get_Multiplication()
        {
            //Arrange
            double Numerator1 = 1.1;
            double Denominator1 = 2.2;
            double Numerator2 = 3.3;
            double Denominator2 = 4.4;
            int Integer = 0;
            string expected = $"3,63/9,68";
            Fraction fraction1 = new Fraction(Numerator1, Denominator1, Integer);
            Fraction fraction2 = new Fraction(Numerator2, Denominator2, Integer);

            //Act
            string actual = fraction1.GetMultiplication(fraction2);

            //Assert
            Assert.AreEqual(expected, actual, "Multiplication with another fraction wasn't calculated correctly");
        }

        [TestMethod] //Тест для деления дроби на другую дробь
        public void Fraction_With_Valid_Denominator_Get_Division()
        {
            //Arrange
            double Numerator1 = 1.5;
            double Denominator1 = 2.5;
            double Numerator2 = 3.5;
            double Denominator2 = 4.5;
            int Integer = 0;
            string expected = $"6,75/8,75";
            Fraction fraction1 = new Fraction(Numerator1, Denominator1, Integer);
            Fraction fraction2 = new Fraction(Numerator2, Denominator2, Integer);

            //Act
            string actual = fraction1.GetDivision(fraction2);

            //Assert
            Assert.AreEqual(expected, actual, "Division with another fraction wasn't calculated correctly");
        }

        [TestMethod] //Тест для сложения двух дробей с разными знаменателями
        public void Fraction_With_Different_Denominator_Get_Sum()
        {
            //Arrange
            double Numerator1 = 1.5;
            double Denominator1 = 5.1;
            double Numerator2 = 1.2;
            double Denominator2 = 2.1;
            int Integer = 0;
            string expected = $"9,27/10,71";
            Fraction fraction1 = new Fraction(Numerator1, Denominator1, Integer);
            Fraction fraction2 = new Fraction(Numerator2, Denominator2, Integer);

            //Act
            string actual = fraction1.GetSum(fraction2);

            //Assert
            Assert.AreEqual(expected, actual, "Denominators are the same");
        }

        [TestMethod] //Тест для сложения двух дробей с одинаковыми знаменателями
        public void Fraction_With_The_Same_Denominator_Get_Sum()
        {
            //Arrange
            double Numerator1 = 1.5;
            double Denominator1 = 7.1;
            double Numerator2 = 3.5;
            double Denominator2 = 7.1;
            int Integer = 0;
            string expected = $"5/7,1";
            Fraction fraction1 = new Fraction(Numerator1, Denominator1, Integer);
            Fraction fraction2 = new Fraction(Numerator2, Denominator2, Integer);

            //Act
            string actual = fraction1.GetSum(fraction2);

            //Assert
            Assert.AreEqual(expected, actual, "Denominators are different");
        }

        [TestMethod] //Тест для вычитания из дроби другой дроби с разными знаменателями
        public void Fraction_With_Different_Denominator_Get_Difference()
        {
            //Arrange
            double Numerator1 = 7.6;
            double Denominator1 = 8.7;
            double Numerator2 = 9.8;
            double Denominator2 = 10.9;
            int Integer = 0;
            string expected = $"-2,42/94,83";
            Fraction fraction1 = new Fraction(Numerator1, Denominator1, Integer);
            Fraction fraction2 = new Fraction(Numerator2, Denominator2, Integer);

            //Act
            string actual = fraction1.GetDifference(fraction2);

            //Assert
            Assert.AreEqual(expected, actual, "Denominators are the same");
        }

        [TestMethod] //Тест для вычитания из дроби другой дроби с одинаковыми знаменателями
        public void Fraction_With_The_Same_Denominator_Get_Difference()
        {
            //Arrange
            double Numerator1 = 7.6;
            double Denominator1 = 10.9;
            double Numerator2 = 9.8;
            double Denominator2 = 10.9;
            int Integer = 0;
            string expected = $"-2,2/10,9";
            Fraction fraction1 = new Fraction(Numerator1, Denominator1, Integer);
            Fraction fraction2 = new Fraction(Numerator2, Denominator2, Integer);

            //Act
            string actual = fraction1.GetDifference(fraction2);

            //Assert
            Assert.AreEqual(expected, actual, "Denominators are different");
        }

        [TestMethod] //Тест для проверки двух дробей с одинаковыми числителями и знаменателями на равенство 
        public void Fraction_With_The_Same_Numerator_And_Denominator_Is_Fraction_Equals()
        {
            //Arrange
            double Numerator1 = 1.5;
            double Denominator1 = 3.0;
            double Numerator2 = 1.5;
            double Denominator2 = 3.0;
            int Integer = 0;
            string expected = $"True";
            Fraction fraction1 = new Fraction(Numerator1, Denominator1, Integer);
            Fraction fraction2 = new Fraction(Numerator2, Denominator2, Integer);

            //Act
            string actual = fraction1.IsFractionEquals(fraction2);

            //Assert
            Assert.AreEqual(expected, actual, "Fractions are not equals");
        }

        [TestMethod] //Тест для проверки двух равных дробей, но с разными числителями и знаменателями на равенство 
        public void Fraction_With_Different_Numerator_And_Denominator_But_The_Same_Is_Fraction_Equals()
        {
            //Arrange
            double Numerator1 = 1.5;
            double Denominator1 = 3.0;
            double Numerator2 = 2.5;
            double Denominator2 = 5.0;
            int Integer = 0;
            string expected = $"True";
            Fraction fraction1 = new Fraction(Numerator1, Denominator1, Integer);
            Fraction fraction2 = new Fraction(Numerator2, Denominator2, Integer);

            //Act
            string actual = fraction1.IsFractionEquals(fraction2);

            //Assert
            Assert.AreEqual(expected, actual, "Fractions are not equals");
        }

        [TestMethod] //Тест для проверки двух разных дробей на равенство 
        public void Fraction_With_Different_Numerator_And_Denominator_Is_Fraction_Equals()
        {
            //Arrange
            double Numerator1 = 1.6;
            double Denominator1 = 3.7;
            double Numerator2 = 4.1;
            double Denominator2 = 12.5;
            int Integer = 0;
            string expected = $"False";
            Fraction fraction1 = new Fraction(Numerator1, Denominator1, Integer);
            Fraction fraction2 = new Fraction(Numerator2, Denominator2, Integer);

            //Act
            string actual = fraction1.IsFractionEquals(fraction2);

            //Assert
            Assert.AreEqual(expected, actual, "Fractions are equals");
        }
    }
}

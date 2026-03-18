using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pr4_Trudova_Rezantsev;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, 2 + 2);
            Assert.IsTrue(5 > 3);
            Assert.IsFalse(2 > 10);
            Assert.IsNull(Formuler.ParseString("не_число"));
        }
        [TestMethod]
        public void TestFormula1_ValidInput_ReturnsCorrectResult()
        {
            double x = 1, y = 3, z = 0;
            double expected =
                Math.Abs(Math.Pow(x, y / x) - Math.Pow(y / x, 1.0 / 3.0))
                + (y - x) * (Math.Cos(y) - z / (y - x)) / (1 + Math.Pow(y - x, 2));

            double result = Formuler.CalculateFormul1(x, y, z);

            Assert.AreEqual(expected, result, 1e-10);
        }

        [TestMethod]
        public void TestFormula2_XGreaterThanAbsP_ReturnsFirstBranch()
        {
            Func<double, double> f = t => Math.Sinh(t);

            double x = 10, p = 3; 
            double fx = Math.Sinh(x);
            double expected = 2 * Math.Pow(fx, 3) + 3 * Math.Pow(p, 2);

            double result = Formuler.CalculateFormul2(f, x, p);

            Assert.AreEqual(expected, result, 1e-6);
        }

        [TestMethod]
        public void TestFormula3_KnownInput_ReturnsCorrectResult()
        {
            double result = Formuler.CalculateFormul3(x: 4, b: 1);
            double expected = 0.0025 * 1 * Math.Pow(4, 3) + Math.Sqrt(4) + Math.Exp(0.82);

            Assert.AreEqual(expected, result, 1e-10);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC2017;

namespace AoC2017.Test
{
    [TestClass]
    public class Day01Test
    {
        [DataTestMethod]
        [DataRow("1212", 6)]
        [DataRow("1221", 0)]
        [DataRow("123425", 4)]
        [DataRow("123123", 12)]
        [DataRow("12131415", 4)]
        public void GetSumBTest(string input, int expected)
        {
            int sum = AoC2017.Day01.GetSumB(input);
            Assert.AreEqual(expected, sum);
        }
    }
}
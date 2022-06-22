using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        //Odmiana [Fact] - < 2
        [TestMethod]
        public void InputIsMinus1_ReturnFalse()
        {
            var result = _primeService.IsPrime(-1);

            Assert.IsFalse(result, $"-1 should not be prime");
        }

        [TestMethod]
        public void InputIs0_ReturnFalse()
        {
            var result = _primeService.IsPrime(0);

            Assert.IsFalse(result, $"0 should not be prime");
        }

        [TestMethod]
        public void InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, $"1 should not be prime");
        }
        
        //Odmiana [Fact] - > 1
        [TestMethod]
        public void InputIs2_ReturnTrue()
        {
            var result = _primeService.IsPrime(2);

            Assert.IsTrue(result, $"2 should be prime");
        }

        [TestMethod]
        public void InputIs3_ReturnTrue()
        {
            var result = _primeService.IsPrime(3);

            Assert.IsTrue(result, $"3 should be prime");
        }

        [TestMethod]
        public void InputIs4_ReturnTrue()
        {
            var result = _primeService.IsPrime(4);

            Assert.IsFalse(result, $"4 should be prime");
        }

        [TestMethod]
        public void InputIs5_ReturnTrue()
        {
            var result = _primeService.IsPrime(5);

            Assert.IsTrue(result, $"5 should be prime");
        }

        [TestMethod]
        public void InputIs6_ReturnTrue()
        {
            var result = _primeService.IsPrime(6);

            Assert.IsFalse(result, $"6 should be prime");
        }

        [TestMethod]
        public void InputIs7_ReturnTrue()
        {
            var result = _primeService.IsPrime(7);

            Assert.IsTrue(result, $"7 should be prime");
        }

        [TestMethod]
        public void InputIs8_ReturnTrue()
        {
            var result = _primeService.IsPrime(8);

            Assert.IsFalse(result, $"8 should be prime");
        }

        [TestMethod]
        public void InputIs9_ReturnTrue()
        {
            var result = _primeService.IsPrime(9);

            Assert.IsFalse(result, $"9 should be prime");
        }

        //Odmiana [Theory] - < 2
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }

        //Odmiana [Theory] - > 1
        [DataTestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(7)]
        public void IsPrime_PrimeValuesMoreThan1_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsTrue(result, $"{value} should be prime");
        }

        [DataTestMethod]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(8)]
        [DataRow(9)]
        public void IsPrime_NotPrimeValuesMoreThan1_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
    }
}

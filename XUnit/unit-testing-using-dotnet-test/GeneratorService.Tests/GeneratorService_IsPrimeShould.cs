using Xunit;
using SimpleBank;

namespace Generate.UnitTests.Services
{
    public class GenerateService_IsGenerateShould
    {
        //Testowanie [Fact] - testowane za pomocą kalkulatora: https://simplycalc.com/luhn-calculate.php
        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt1()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 1, 2, 3, 4, 5, 6 });

            Assert.Equal(7, result);
        }

        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt2()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 6, 2, 1, 0, 4, 8, 1, 8, 8, 3, 2, 4, 1, 6, 9, 4 });

            Assert.Equal(5, result);
        }

        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt3()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 4, 6, 1, 7, 3, 9, 3, 3, 6, 7, 2, 4, 2, 7, 5, 9 });

            Assert.Equal(4, result);
        }

        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt4()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 1, 1, 1, 2, 6, 6, 1, 9, 0, 1, 7, 0, 5, 5, 3, 4 });

            Assert.Equal(7, result);
        }

        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt5()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 3, 2, 4, 4, 7, 1, 5, 6, 8, 7, 9, 9, 0, 3, 9, 9 });

            Assert.Equal(9, result);
        }

        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt6()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 6, 6, 9, 0, 3, 6, 7, 6, 9, 7, 3, 9, 7, 4, 5, 1 });

            Assert.Equal(8, result);
        }

        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt7()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 2, 4, 7, 4, 0, 5, 5, 8, 2, 3, 0, 8, 0, 3, 8, 3 });

            Assert.Equal(7, result);
        }

        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt8()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 7, 1, 4, 8, 2, 6, 8, 0, 7, 7, 8, 1, 5, 6, 3, 0 });

            Assert.Equal(4, result);
        }

        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt9()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 6, 2, 8, 4, 7, 6, 2, 8, 8, 5, 0, 4, 3, 6, 8, 3 });

            Assert.Equal(8, result);
        }

        [Fact]
        public void IsGenerate_InputIsArray_ReturnInt10()
        {
            var generateService = new Generator();
            int result = generateService.GenerateCheckDigit(new int[] { 8, 1, 9, 5, 7, 1, 3, 6, 7, 3, 1, 0, 0, 9, 4, 0 });

            Assert.Equal(8, result);
        }
    }
}
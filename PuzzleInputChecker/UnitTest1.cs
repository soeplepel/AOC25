

using _01_SecretEntrance;
using FluentAssertions;

namespace PuzzleInputChecker
{

    public class UnitTest1
    {


        [Theory]
        [InlineData("..\\..\\..\\TestData\\Sample_1.txt", 3)]
        [InlineData("..\\..\\..\\TestData\\input_1.txt", 1048)]
        public void SecretEntranceExample(string input, int expected)
        {
            //arrange
            var str = File.ReadAllText(input);

            //act
            Day1 day1 = new Day1(str);
            var exampleResult = day1.Calculate();

            //assert
            exampleResult.Should().Be(expected);
        }

       
        
    }
}

using _04_PrintingDepartment;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleInputChecker
{
    public class UnitTest4
    {
        [Theory]
        [InlineData("..\\..\\..\\..\\..\\TestData\\Sample_4.txt", 13)]
        [InlineData("..\\..\\..\\..\\..\\TestData\\input_4.txt", 1587)]
        public void LobbyUnitTest(string path, int result)
        {
            //aarrange
            var str = File.ReadAllText(path);

            //act
            Day4 day = new Day4(str);
            var exampleResult = day.Calculate();

            //assert
            exampleResult.Should().Be(result);
        }
    }
}

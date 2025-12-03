
using _02_GiftShop;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleInputChecker
{
    public class UnitTest2
    {
        [Theory]
        [InlineData("..\\..\\..\\..\\..\\TestData\\Sample_2.txt", 1227775554)]
        [InlineData("..\\..\\..\\..\\..\\TestData\\input_2.txt", 53420042388)]
        public void GiftShop(string path, UInt64 result)
        {
            //aarrange
           var str = File.ReadAllText(path);

            //act
            Day2 day2 = new Day2(str);
            var exampleResult = day2.Calculate();

            //assert
            exampleResult.Should().Be(result);
        }
    }
}

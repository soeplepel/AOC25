using _02_GiftShop;
using _03_Lobby;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleInputChecker
{
    public class UnitTest3
    {
        [Theory]
        [InlineData("..\\..\\..\\..\\..\\TestData\\Sample_3.txt", 357)]
       // [InlineData("..\\..\\..\\..\\..\\TestData\\input_3.txt", )]
        public void GiftShop(string path, int result)
        {
            //aarrange
            var str = File.ReadAllText(path);

            //act
            Day3 day = new Day3(str);
            var exampleResult = day.Calculate();

            //assert
            exampleResult.Should().Be(result);
        }
    }
}

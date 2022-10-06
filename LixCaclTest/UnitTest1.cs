using System;
using Xunit;

namespace LixCaclTest
{
    public class UnitTest1
    {
        [Fact]
        public void LixScoreCaluculationTest()
        {
            LixCalcLibrary.Services.LixCalcService lixService = new LixCalcLibrary.Services.LixCalcService();
            var res = lixService.CalculateLixScore(@".\TxtFile.txt");

            Assert.Equal(18, res.TotalWordCount);
            Assert.Equal(2, res.StopCount);
            Assert.Equal(37, res.LixScore);
            Assert.Equal(5, res.LongWordCount);
        }

        [Fact]
        public void LixScoreCaluculationTest2()
        {
            LixCalcLibrary.Services.LixCalcService lixService = new LixCalcLibrary.Services.LixCalcService();
            var res = lixService.CalculateLixScore(@".\TxtFile.txt");

            Assert.Equal("Middel, dagblade og tidsskrifter.", res.LixDifficulty);
        }

    }
}

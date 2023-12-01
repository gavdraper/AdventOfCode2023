using AdventBase;
using Xunit;

namespace DayTwo
{
    public class TestHarness : AdventBaseHarness
    {
        [Fact]
        public void TestSolvesSample()
        {
            var solution = new Solution();
            var sample = solution.Solve(SampleInput);
            Assert.Equal(281, sample);
            //var real = solution.Solve(RealInput);
        }
    }
}
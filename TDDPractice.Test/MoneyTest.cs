using Xunit;

namespace TDDPractice.Test
{
    public class MoneyTest
    {
        [Fact]
        public void Š|‚¯ŽZ()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.Equal(10, five.amound);
        }
    }
}
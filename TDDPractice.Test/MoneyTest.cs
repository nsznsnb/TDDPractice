using Xunit;

namespace TDDPractice.Test
{
    public class MoneyTest
    {
        [Fact]
        public void Š|‚¯ŽZ()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.Equal(10, product.Amount);
            product = five.Times(3);
            Assert.Equal(15, product.Amount);
        }
    }
}
using Xunit;

namespace TDDPractice.Test
{
    public class MoneyTest
    {
        [Fact]
        public void ä|ÇØéZ()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.Equal(new Dollar(10), product);
            product = five.Times(3);
            Assert.Equal(new Dollar(15), product);
        }

        [Fact]
        public void ìôâøê´()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
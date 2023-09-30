using Xunit;

namespace TDDPractice.Test
{
    public class MoneyTest
    {
        [Fact]
        public void Dollar‚ÌŠ|‚¯Z()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.Equal(new Dollar(10), product);
            product = five.Times(3);
            Assert.Equal(new Dollar(15), product);
        }

        [Fact]
        public void Dollar‚Ì“™‰¿«()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }

        [Fact]
        public void Franc‚ÌŠ|‚¯Z()
        {
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10), five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
        }

        [Fact]
        public void Franc‚Ì“™‰¿«()
        {
            Assert.True(new Franc(5).Equals(new Franc(5)));
            Assert.False(new Franc(5).Equals(new Franc(6)));
        }

        [Fact]
        public void Dollar‚ÆFranc‚Ì“™‰¿«()
        {
            Assert.False(new Franc(5).Equals(new Dollar(5)));
        }

    }
}
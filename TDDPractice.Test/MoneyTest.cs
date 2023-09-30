using Xunit;

namespace TDDPractice.Test
{
    public class MoneyTest
    {
        [Fact]
        public void Dollar‚ÌŠ|‚¯Z()
        {
            Money five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
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
            Money five = Money.Franc(5);
            Assert.Equal(Money.Franc(10), five.Times(2));
            Assert.Equal(Money.Franc(15), five.Times(3));
        }

        [Fact]
        public void Franc‚Ì“™‰¿«()
        {
            Assert.True(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.False(Money.Franc(5).Equals(Money.Franc(6)));
        }

        [Fact]
        public void Dollar‚ÆFranc‚Ì“™‰¿«()
        {
            Assert.False(Money.Dollar(5).Equals(Money.Franc(5)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

    }
}
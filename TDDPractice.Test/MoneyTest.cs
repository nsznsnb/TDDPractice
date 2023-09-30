using Xunit;

namespace TDDPractice.Test
{
    public class MoneyTest
    {
        [Fact]
        public void Dollar�̊|���Z()
        {
            Money five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
        }

        [Fact]
        public void Dollar�̓�����()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }

        [Fact]
        public void Franc�̊|���Z()
        {
            Money five = Money.Franc(5);
            Assert.Equal(Money.Franc(10), five.Times(2));
            Assert.Equal(Money.Franc(15), five.Times(3));
        }

        [Fact]
        public void Franc�̓�����()
        {
            Assert.True(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.False(Money.Franc(5).Equals(Money.Franc(6)));
        }

        [Fact]
        public void Dollar��Franc�̓�����()
        {
            Assert.False(Money.Dollar(5).Equals(Money.Franc(5)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

    }
}
using System;
using Xunit;
using static LAB02.Program;

namespace LAB02Test
{
    public class UnitTest1
    {
        [Fact]
        public decimal void ViewBalance()
        {
            int number = 5000;
            Assert.Equal(5000);
        }
        public decimal void Withdraw()
        {

        }
        public decimal void Deposit()
        {

        }
    }
}

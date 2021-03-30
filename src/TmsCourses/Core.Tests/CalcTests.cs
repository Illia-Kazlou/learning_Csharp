using Xunit;

namespace Core.Tests
{
    public class CalcTests
    {
        [Fact]
        public void Add_WhenTwoPositiveNumbers_ReturtnPosiyiveValue()
        {
            // Arrange
            Calc calc = new Calc();
            var exp = 3;

            // Act 
            var result = calc.Add(1, 2);

            // Assert (утверждать, отстаивать)
            Assert.Equal(exp, result);
        }

        [Fact]
        public void Add_WhenNotTwoPositiveNumbers_ReturtnNotPosiyiveValue()
        {
            // Arrange
            Calc calc = new Calc();
            var exp = -1;

            // Act 
            var result = calc.Add(1, -2);

            // Assert (утверждать, отстаивать)
            Assert.Equal(exp, result);
        }

        [Fact]
        public void Add_WhenNotTwoPositiveNumbers_ReturtnPosiyiveValue()
        {
            // Arrange
            Calc calc = new Calc();
            var exp = 2;

            // Act 
            var result = calc.Add(3, -1);

            // Assert (утверждать, отстаивать)
            Assert.Equal(exp, result);
        }
    }
}

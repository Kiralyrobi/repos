using Functions;

namespace Functions.Tests
{
    public class LongerWordTests
    {
        [Fact]
        public void FirstWordLonger_ReturnFirstWord()
        {
            // Arrange
            var service = new FunctionService();

            // Act
            var result = service.GetLongerWorld("Gesztenye", "Dió");

            // Assert
            Assert.Equal("Gesztenye", result);
        }


    }
    public class LongerWordTests
    {
        [Fact]
        public void FirstWordLonger_ReturnFirstWord()
        {
            // Arrange
            var service = new FunctionService();

            // Act
            var result = service.GetLongerWorld("Gesztenye", "Dió");

            // Assert
            Assert.Equal("Gesztenye", result);
        }


    }
}
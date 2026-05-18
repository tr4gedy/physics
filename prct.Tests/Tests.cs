using Xunit;
using prct.Features;
namespace prct.Tests
{
    public class Tests
    {
        [Fact]
        public void IsNegative_WithPositiveNum_ReturnsFalse()
        {
            // Arrange 
            double num = 4.4;   
            // Act
            bool res = prct.Features.Validation.isNegative(num);
            // Assert
            Assert.Equal(false, res);
        }

        [Fact]
        public void IsNegative_WithNegativeNum_ReturnsTrue()
        {
            // Arrange 
            double num = -4.4;
            // Act
            bool res = prct.Features.Validation.isNegative(num);
            // Assert
            Assert.Equal(true, res);
        }
        [Fact]
        public void IsZero_WithZeroNum_ReturnsTrue()
        {
            // Arrange 
            double num = 0;
            // Act
            bool res = prct.Features.Validation.isZero(num);
            // Assert
            Assert.Equal(true, res);
        }
        [Fact]
        public void IsZero_WithDefaultNum_ReturnsFalse()
        {
            // Arrange 
            double num = 1.0;
            // Act
            bool res = prct.Features.Validation.isZero(num);
            // Assert
            Assert.Equal(false, res);
        }
        [Fact]
        public void IsOverMaxLeght_WithStrSmallerThan25Characters_ReturnsFalse()
        {
            // Arrange 
            string str = "strstr";
            // Act
            bool res = prct.Features.Validation.isOverMaxLength(str, 25);
            // Assert
            Assert.Equal(false, res);
        }
        public void IsOverMaxLeght_WithStrBiggerThan25Characters_ReturnsFalse()
        {
            // Arrange 
            string str = "strstrstrdasdasdhsadghgsadggsgdagsgadgasgdgasgdgasg";
            // Act
            bool res = prct.Features.Validation.isOverMaxLength(str, 25);
            // Assert
            Assert.Equal(true, res);
        }
        [Fact]
        public void IsEmptyName_WithDefaultName_ReturnsFalse()
        {
            // Arrange 
            string str = "name"; 
            // Act
            bool res = prct.Features.Validation.isEmptyName(str);
            // Assert
            Assert.Equal(false, res);
        }
        [Fact]
        public void IsEmptyName_WithEmptyName_ReturnsTrue()
        {
            // Arrange 
            string str = string.Empty;
            // Act
            bool res = prct.Features.Validation.isEmptyName(str);
            // Assert
            Assert.Equal(true, res);
        }
    }
}
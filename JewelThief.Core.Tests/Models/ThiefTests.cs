using JewelThief.Core.Models;
using System;
using Xunit;

namespace JewelThief.Core.Tests.Models
{
    public class ThiefTests
    {
        [Fact]
        public void ConfirmIdentity_WhenUpperCaseXPassed_ShouldReturnTrue()
        {
            // Arrange            
            char input = 'X';

            // Act
            var actual = Thief.ConfirmIdentity(input);

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void ConfirmIdentity_WhenLowerCaseXPassed_ShouldReturnTrue()
        {
            // Arrange            
            char input = 'x';

            // Act
            var actual = Thief.ConfirmIdentity(input);

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void ConfirmIdentity_WhenDigitPassed_ShouldReturnFalse()
        {
            // Arrange            
            char input = '0';

            // Act
            var actual = Thief.ConfirmIdentity(input);

            // Assert
            Assert.False(actual);
        }
    }
}

using JewelThief.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JewelThief.Core.Tests.Models
{
    public class PoliceTests
    {
        [Fact]
        public void ConfirmIdentity_WhenDigitPassed_ShouldReturnTrue()
        {
            // Arrange            
            char input = '8';

            // Act
            var actual = Police.ConfirmIdentity(input);

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void ConfirmIdentity_WhenNonDigitXPassed_ShouldReturnFalse()
        {
            // Arrange            
            char input = 'X';

            // Act
            var actual = Police.ConfirmIdentity(input);

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void GetSearchPower_WhenDigitPassed_ShouldReturnNumericEquivalent()
        {
            // Arrange            
            char input = '4';
            int expected = 4;

            // Act
            var actual = Police.GetSearchPower(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSearchPower_WhenNonDigitPassed_ShouldThrowException()
        {
            // Arrange            
            char input = 'X';            

            // Act
            Action actual = delegate () { Police.GetSearchPower(input); };

            // Assert
            Assert.Throws<ArgumentException>(actual);
        }
    }
}

using JewelThief.Core.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace JewelThief.Services.Tests
{
    public class SecurityServiceTests
    {
        [Fact]
        public void CatchThieves_WhenNullQueuePassed_ShouldReturnZero()
        {
            // Arrange
            Queue queue = null;
            SecurityService securityService = new SecurityService(queue);
            int expected = 0;

            // Act
            int actual = securityService.CatchThieves();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CatchThieves_WhenEmptyQueuePassed_ShouldReturnZero()
        {
            // Arrange
            Queue queue = new Queue();
            SecurityService securityService = new SecurityService(queue);
            int expected = 0;

            // Act
            int actual = securityService.CatchThieves();

            // Assert
            Assert.True(queue.IsEmpty());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CatchThieves_WhenQueueContainsThievesOnly_ShouldReturnZero()
        {
            // Arrange
            List<Thief> thieves = new List<Thief>()
            {
                new Thief(1),
                new Thief(2),
                new Thief(5),
                new Thief(8),
            };

            List<Police> police = new List<Police>();

            Queue queue = new Queue(thieves, police);            
            SecurityService securityService = new SecurityService(queue);
            int expected = 0;

            // Act
            int actual = securityService.CatchThieves();

            // Assert
            Assert.False(queue.IsEmpty());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CatchThieves_WhenQueueContainsPoliceOnly_ShouldReturnZero()
        {
            // Arrange
            List<Thief> thieves = new List<Thief>();
            List<Police> police = new List<Police>()
            {
                new Police(1, 3),
                new Police(4, 2),
                new Police(8, 1),
                new Police(9, 5)
            };


            Queue queue = new Queue(thieves, police);
            SecurityService securityService = new SecurityService(queue);
            int expected = 0;

            // Act
            int actual = securityService.CatchThieves();

            // Assert
            Assert.False(queue.IsEmpty());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CatchThieves_WhenQueueThiefBehindPoliceButOutOfReach_ShouldReturnZero()
        {
            // Arrange
            List<Thief> thieves = new List<Thief>()
            {
                new Thief(1)
            };
            List<Police> police = new List<Police>()
            {
                new Police(4, 2)
            };


            Queue queue = new Queue(thieves, police);
            SecurityService securityService = new SecurityService(queue);
            int expected = 0;

            // Act
            int actual = securityService.CatchThieves();

            // Assert
            Assert.False(queue.IsEmpty());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CatchThieves_WhenQueueThiefAheadOfPoliceButOutOfReach_ShouldReturnZero()
        {
            // Arrange
            List<Thief> thieves = new List<Thief>()
            {
                new Thief(7)
            };
            List<Police> police = new List<Police>()
            {
                new Police(4, 2)
            };


            Queue queue = new Queue(thieves, police);
            SecurityService securityService = new SecurityService(queue);
            int expected = 0;

            // Act
            int actual = securityService.CatchThieves();

            // Assert
            Assert.False(queue.IsEmpty());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CatchThieves_WhenQueueThiefBehindPoliceButWithinReach_ShouldReturnOne()
        {
            // Arrange
            List<Thief> thieves = new List<Thief>()
            {
                new Thief(2)
            };
            List<Police> police = new List<Police>()
            {
                new Police(4, 2)
            };


            Queue queue = new Queue(thieves, police);
            SecurityService securityService = new SecurityService(queue);
            int expected = 1;

            // Act
            int actual = securityService.CatchThieves();

            // Assert
            Assert.False(queue.IsEmpty());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CatchThieves_WhenQueueThiefAheadOfPoliceButWithinReach_ShouldReturnOne()
        {
            // Arrange
            List<Thief> thieves = new List<Thief>()
            {
                new Thief(6)
            };
            List<Police> police = new List<Police>()
            {
                new Police(4, 2)
            };


            Queue queue = new Queue(thieves, police);
            SecurityService securityService = new SecurityService(queue);
            int expected = 1;

            // Act
            int actual = securityService.CatchThieves();

            // Assert
            Assert.False(queue.IsEmpty());
            Assert.Equal(expected, actual);
        }
    }
}

using JewelThief.Core.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JewelThief.Core.Tests.Factories
{
    public class QueueFactoryTests
    {
        [Fact]
        public void MakeQueue_WhenEmptyStringPassedAsQueuePattern_ShouldReturnEmptyQueue()
        {
            // Arrange            
            string input = "";

            // Act
            var factory = new QueueFactory(input);
            var queue = factory.MakeQueue();

            // Assert
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void MakeQueue_WhenNullStringPassedAsQueuePattern_ShouldReturnEmptyQueue()
        {
            // Arrange            
            string input = null;

            // Act
            var factory = new QueueFactory(input);
            var queue = factory.MakeQueue();

            // Assert
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void MakeQueue_WhenWhitespaceStringPassedAsQueuePattern_ShouldReturnEmptyQueue()
        {
            // Arrange            
            string input = " ";

            // Act
            var factory = new QueueFactory(input);
            var queue = factory.MakeQueue();

            // Assert
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void MakeQueue_WhenWhitespaceAddedToSixThievesStringPassedAsQueuePattern_ShouldReturnSixThieves()
        {
            // Arrange            
            string input = " XXXXXX      "; int thievesExpected = 6;
            int policeExpected = 0;

            // Act
            var factory = new QueueFactory(input);
            var queue = factory.MakeQueue();

            // Assert
            Assert.Equal(thievesExpected, queue.Thieves.Count);
            Assert.Equal(policeExpected, queue.Police.Count);
        }

        [Fact]
        public void MakeQueue_WhenSixThievesPassedAsQueuePattern_ShouldReturnSixThieves()
        {
            // Arrange            
            string input = "XXXXXX";
            int thievesExpected = 6;
            int policeExpected = 0;

            // Act
            var factory = new QueueFactory(input);
            var queue = factory.MakeQueue();

            // Assert
            Assert.Equal(thievesExpected, queue.Thieves.Count);
            Assert.Equal(policeExpected, queue.Police.Count);
        }

        [Fact]
        public void MakeQueue_WhenSixPolicePassedAsQueuePattern_ShouldReturnSixPolice()
        {
            // Arrange            
            string input = "333333";
            int thievesExpected = 0;
            int policeExpected = 6;

            // Act
            var factory = new QueueFactory(input);
            var queue = factory.MakeQueue();

            // Assert
            Assert.Equal(thievesExpected, queue.Thieves.Count);
            Assert.Equal(policeExpected, queue.Police.Count);
        }

        [Fact]
        public void MakeQueue_WhenSixPoliceFourThievesEightCustomersPassedAsQueuePattern_ShouldReturnFourPoliceSixThieves()
        {
            // Arrange            
            string input = "1#X#2#X#2#XX#13##5";
            int thievesExpected = 4;
            int policeExpected = 6;

            // Act
            var factory = new QueueFactory(input);
            var queue = factory.MakeQueue();

            // Assert
            Assert.Equal(thievesExpected, queue.Thieves.Count);
            Assert.Equal(policeExpected, queue.Police.Count);
        }
    }
}

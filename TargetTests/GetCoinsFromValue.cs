using static TargetTechTask.Functions;

namespace TargetTests
{
    public class GetCoinsFromValue
    {
        [Test]
        public void SumOfPennies_ReturnsCorrectValue()
        {
            // Arrange & Act
            Dictionary<string, int> result = GetCoinsFromValue(4);
            Dictionary<string, int> correctResult = new()
            {
                { "Quarters", 0 },
                { "Dimes", 0 },
                { "Nickels", 0 },
                { "Pennies", 4 }
            };

            // Assert
            Assert.That(result, Is.EqualTo(correctResult));
        }

        [Test]
        public void SumOfNickels_ReturnsCorrectValue()
        {
            // Arrange & Act
            Dictionary<string, int> result = GetCoinsFromValue(5);
            Dictionary<string, int> correctResult = new()
            {
                { "Quarters", 0 },
                { "Dimes", 0 },
                { "Nickels", 1 },
                { "Pennies", 0 }
            };

            // Assert
            Assert.That(result, Is.EqualTo(correctResult));
        }

        [Test]
        public void SumOfDimes_ReturnsCorrectValue()
        {
            // Arrange & Act
            Dictionary<string, int> result = GetCoinsFromValue(20);
            Dictionary<string, int> correctResult = new()
            {
                { "Quarters", 0 },
                { "Dimes", 2 },
                { "Nickels", 0 },
                { "Pennies", 0 }
            };

            // Assert
            Assert.That(result, Is.EqualTo(correctResult));
        }

        [Test]
        public void SumOfQuarters_ReturnsCorrectValue()
        {
            // Arrange & Act
            Dictionary<string, int> result = GetCoinsFromValue(75);
            Dictionary<string, int> correctResult = new()
            {
                { "Quarters", 3 },
                { "Dimes", 0 },
                { "Nickels", 0 },
                { "Pennies", 0 }
            };

            // Assert
            Assert.That(result, Is.EqualTo(correctResult));
        }

        [Test]
        public void IntegerSum_ReturnsCorrectValue()
        {
            // Arrange & Act
            Dictionary<string, int> result = GetCoinsFromValue(56);
            Dictionary<string, int> correctResult = new()
            {
                { "Quarters", 2 },
                { "Dimes", 0 },
                { "Nickels", 1 },
                { "Pennies", 1 }
            };

            // Assert
            Assert.That(result, Is.EqualTo(correctResult));
        }

        [Test]
        public void NegativeSum_ReturnsEmpty()
        {
            // Arrange & Act
            Dictionary<string, int> result = GetCoinsFromValue(-8);
            Dictionary<string, int> correctResult = new()
            {
                { "Quarters", 0 },
                { "Dimes", 0 },
                { "Nickels", 0 },
                { "Pennies", 0 }
            };

            // Assert
            Assert.That(result, Is.EqualTo(correctResult));
        }

        [Test]
        public void FloatSum_ReturnsEmpty()
        {
            // Arrange & Act
            Dictionary<string, int> result = GetCoinsFromValue(4.935);
            Dictionary<string, int> correctResult = new()
            {
                { "Quarters", 0 },
                { "Dimes", 0 },
                { "Nickels", 0 },
                { "Pennies", 4 }
            };

            // Assert
            Assert.That(result, Is.EqualTo(correctResult));
        }
    }
}
using static TargetTechTask.Functions;

namespace TargetTests
{
    public class GetDigitDigitsSum
    {
        [Test]
        public void NegativeSmallNumber_ReturnsCorrectValue()
        {
            // Act & Assert
            Assert.That(GetNumberDigitsSum(-16), Is.EqualTo(7));
        }

        [Test]
        public void NegativeBigNumber_ReturnsCorrectValue()
        {
            // Act & Assert
            Assert.That(GetNumberDigitsSum(-942), Is.EqualTo(6));
        }

        [Test]
        public void SmallNumber_ReturnsCorrectValue()
        {
            // Act & Assert
            Assert.That(GetNumberDigitsSum(16), Is.EqualTo(7));
        }

        [Test]
        public void BigNumber_ReturnsCorrectValue()
        {
            // Act & Assert
            Assert.That(GetNumberDigitsSum(942), Is.EqualTo(6));
        }
    }
}
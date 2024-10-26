using static TargetTechTask.Functions;

namespace TargetTests
{
    public class GetSortedByDigitsNumber
    {
        [Test]
        public void NegativeNumber_Throws()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => GetSortedByDigitsNumber(-16));
        }

        [Test]
        public void NormalNumber_ReturnsCorrectValue()
        {
            // Act & Assert
            Assert.That(GetSortedByDigitsNumber(42145), Is.EqualTo(54421));
        }
    }
}
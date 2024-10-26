using static TargetTechTask.Functions;

namespace TargetTests
{
    public class GetPyramidRowValuesSum
    {
        [Test]
        public void NegativeNumber_Throws()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => GetPyramidRowValuesSum(-16));
        }

        [Test]
        public void NormalNumber_ReturnsCorrectValue()
        {
            // Act & Assert
            Assert.That(GetPyramidRowValuesSum(2), Is.EqualTo(8));
        }
    }
}
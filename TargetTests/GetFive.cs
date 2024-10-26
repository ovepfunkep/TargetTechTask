using static TargetTechTask.Functions;

namespace TargetTests
{
    public class GetFive
    {
        [Test]
        public void GetFiveBySymbolPosition_ReturnsFive()
        {
            // Act & Assert
            Assert.That(GetFiveBySymbolPosition(), Is.EqualTo(5));
        }

        [Test]
        public void GetFiveByLength_ReturnsFive()
        {
            // Act & Assert
            Assert.That(GetFiveByLength(), Is.EqualTo(5));
        }

        [Test]
        public void GetFiveByFileRead_ReturnsFive()
        {
            // Act & Assert
            Assert.That(GetFiveByFileRead(), Is.EqualTo(5));
        }
    }
}
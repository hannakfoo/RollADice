using Newtonsoft.Json;
using RollADice;
using Xunit;

namespace RollaDice.Tests
{
    public class DiceNotationValidatorTests
    {
        [Theory]
        [InlineData("10D6", 10, 6)]
        [InlineData("3D10", 3, 10)]
        [InlineData("D6", 1, 6)]
        [InlineData("3D", 3, 6)]
        [InlineData("10D20", 10, 20)]
        public void TestValidators(string inputString, int times, int faces)
        {
            var validator = new DiceNotationValidator();
            var diceNotation = new DiceNotation(inputString);

            Assert.NotNull(diceNotation);
            Assert.Equal(times, diceNotation.Times);
            Assert.Equal(faces, diceNotation.Faces);
        }
    }
}
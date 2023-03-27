namespace RollADice
{
    public class DiceNotation
    {
        public int Times { get; set; } = 1;
        public int Faces { get; set; } = 6;

        private readonly string _inputString;

        public DiceNotation(string inputString)
        {
            _inputString = inputString ?? throw new ArgumentNullException(nameof(inputString));
            Times = inputString.IndexOf("D") > 0 ? Int32.Parse(inputString.Substring(0, inputString.IndexOf("D"))) : 1;
            Faces = inputString.IndexOf("D") + 1 < inputString.Length ? Int32.Parse(inputString.Substring(inputString.IndexOf("D") + 1)) : 6;
        }
    }
}
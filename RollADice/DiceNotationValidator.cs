using FluentValidation;

namespace RollADice
{
    public class DiceNotationValidator : AbstractValidator<DiceNotation>
    {
        // <summary>
        // Reference to Wiki where the validation rules are
        // format of inputstring: AdX
        // where A: A and X are variables, separated by the letter d, which stands for die or dice.
        // The letter d is most commonly lower-case, but some forms of notation use upper-case D[1]
        // (non-English texts can use the equivalent form of the first letter of the given language's word for "dice", but also often use the English "d").
        // A is the number of dice to be rolled(usually omitted if 1).
        // X is the number of faces of each dice.
        // For example, if a game calls for a roll of d4 or 1d4, it means "roll one 4-sided die."
        // If the final number is omitted, it is typically assumed to be a six, but in some contexts, other defaults are used.
        /// </summary>
        public DiceNotationValidator()
        {
            RuleFor(d => d.InputString).NotEmpty().NotNull();
        }
    }
}
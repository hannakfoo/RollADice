# Readme

Given a string in dice notation, return a random integer you can get by rolling those dice.

**Example**:
```
> rollDice('4d4') // Four 4-sided dice
> 13

> rollDice('3d20') // Three 20-sided dice
> 28

> rollDice('1d8+2d10') // One 8-sided dice, and two 10-sided dice
> 21
```

Dice notation, also known as dice notation or RPG notation, is a shorthand method used in tabletop gaming, particularly in role-playing games (RPGs), to describe a combination of dice rolls needed to determine a game outcome.

The notation consists of the letter "d" followed by a number representing the number of sides on the die being rolled. For example, "d6" represents a six-sided die, while "d20" represents a twenty-sided die. The number before the "d" represents the number of times the die is rolled. So, "2d6" means rolling two six-sided dice, and "3d8" means rolling three eight-sided dice.

Dice notation can also include modifiers to the rolls, such as adding or subtracting a certain number. For example, "2d6+3" means rolling two six-sided dice and adding 3 to the result.

Overall, dice notation provides a quick and standardized way to describe complex dice rolling mechanics in tabletop gaming, making it easier for players to understand and communicate game outcomes.

### Thoughts

* Validator for dice notation
* Validator for dice array notation
* Tests for dice notation
* Random seed result
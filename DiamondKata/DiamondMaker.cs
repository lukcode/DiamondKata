namespace DiamondKata;

public class DiamondMaker
{
    public string CreateDiamond(string[] inputArguments)
    {
        if (!IsValidInput(inputArguments))
        {
            throw new ArgumentException("Invalid input. Please provide one uppercase character from A to Z.");
        }

        var midpoint = inputArguments[0][0];
        var size = midpoint - 'A' + 1;
        var diamondLines = new List<string>();

        // upper half of the diamond
        for (var i = 0; i < size; i++)
        {
            var currentChar = (char) ('A' + i);
            var spaces = new string(' ', size - i - 1);
            if (i == 0)
            {
                diamondLines.Add(spaces + currentChar);
            }
            else
            {
                var middleSpaces = new string(' ', 2 * i - 1);
                diamondLines.Add(spaces + currentChar + middleSpaces + currentChar);
            }
        }

        // lower half of the diamond 
        for (var i = size - 2; i >= 0; i--)
        {
            var currentChar = (char) ('A' + i);
            var spaces = new string(' ', size - i - 1);
            if (i == 0)
            {
                diamondLines.Add(spaces + currentChar);
            }
            else
            {
                var middleSpaces = new string(' ', 2 * i - 1);
                diamondLines.Add(spaces + currentChar + middleSpaces + currentChar);
            }
        }

        return string.Join(Environment.NewLine, diamondLines);
    }

    public void PrintDiamond(string diamond)
    {
        Console.WriteLine(diamond);
    }

    private bool IsValidInput(string[] inputArguments)
    {
        return inputArguments.Length is 1 && inputArguments[0].Length is 1 &&
               char.IsLetter(inputArguments[0][0]) && char.IsUpper(inputArguments[0][0]);
    }
}
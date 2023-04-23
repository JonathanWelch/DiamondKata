using System.Text;

namespace DiamondKata
{
    public class Diamond
    {
        private readonly char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public string Create(char input)
        {
            var index = Array.FindIndex(_alphabet, l => l == char.ToUpper(input));

            if (index == -1)
                return "Invalid letter inputted.";

            return index == 0 ? _alphabet[index].ToString() : CreateDiamond(index);
        }

        private string CreateDiamond(int index)
        {
            var diamondBuilder = new StringBuilder();
            var height = index + index + 1;
            var spacing = 0;
            var indentation = index;

            for (var i = 0; i < height; i++)
            {
                if (IsStartOfDiamond(i))
                {
                    diamondBuilder.AppendLine(CreateTip(indentation));
                    spacing += 1;
                    indentation -= 1;
                    continue;
                }

                if (IsEndOfDiamond(i, height))
                {
                    diamondBuilder.AppendLine(CreateTip(indentation));
                    break;
                }

                if (IsTopSectionOfDiamond(i, index))
                {
                    diamondBuilder.AppendLine(CreateLine(_alphabet[i], indentation, spacing));
                    spacing += 2;
                    indentation -= 1;
                    continue;
                }

                var letter = IsMiddleOfDiamond(i, index) ? _alphabet[i] : _alphabet[height - i - 1];
                diamondBuilder.AppendLine(CreateLine(letter, indentation, spacing));
                spacing -= 2;
                indentation += 1;
            }

            return diamondBuilder.ToString();
        }

        private static bool IsStartOfDiamond(int lineIndex)
        {
            return lineIndex == 0;
        }

        private static bool IsEndOfDiamond(int lineIndex, int height)
        {
            var lastLineIndex = height - 1;
            return lineIndex == lastLineIndex;
        }

        private static bool IsTopSectionOfDiamond(int lineIndex, int middleLineIndex)
        {
            return lineIndex < middleLineIndex;
        }

        private static bool IsMiddleOfDiamond(int lineIndex, int middleLineIndex)
        {
            return lineIndex == middleLineIndex;
        }

        private string CreateTip(int indentation)
        {
            return $"{CreateWhiteSpace(indentation)}{_alphabet[0]}{CreateWhiteSpace(indentation)}";
        }

        private static string CreateWhiteSpace(int indentation)
        {
            return new string(' ', indentation);
        }

        private static string CreateLine(char letter, int indentation, int spacing)
        {
            return indentation == 0 ? $"{letter}{CreateWhiteSpace(spacing)}{letter}" 
                : $"{CreateWhiteSpace(indentation)}{letter}{CreateWhiteSpace(spacing)}{letter}{CreateWhiteSpace(indentation)}";
        }
    }
}
namespace VowelCounter.Domain.Commands
{
    public static class VowelCounterCommand
    {
        public static int CountVowelsCommand(string text)
        {
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú', 'â', 'ê', 'î', 'ô', 'û', 'ã', 'õ' };
            string lowerText = text.ToLower();

            foreach (var letter in lowerText)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }

    }
}
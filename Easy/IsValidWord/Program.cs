public class Solution
{
    /*
     A word is considered valid if:
     It contains a minimum of 3 characters.
     It contains only digits (0-9), and English letters (uppercase and lowercase).
     It includes at least one vowel.
     It includes at least one consonant.
     You are given a string word.
     
     Return true if word is valid, otherwise, return false.
     
     Notes:
     
     'a', 'e', 'i', 'o', 'u', and their uppercases are vowels.
     A consonant is an English letter that is not a vowel.
     */
    public static bool IsValidWord(string word)
    {
        // Check if the word has at least 3 characters
        if (word.Length < 3)
            return false;

        bool hasVowel = false;
        bool hasConsonant = false;
        string vowels = "aeiouAEIOU";

        foreach (char c in word)
        {
            // Check if the character is alphanumeric (digit or letter)
            if (!char.IsLetterOrDigit(c))
                return false;

            // Check if the character is a vowel
            if (vowels.Contains(c))
            {
                hasVowel = true;
            }
            // Check if the character is a consonant (a letter that's not a vowel)
            else if (char.IsLetter(c))
            {
                hasConsonant = true;
            }
        }

        // The word is valid if it contains at least one vowel and one consonant
        return hasVowel && hasConsonant;
    }

    public static void Main()
    {
        // Test cases
        Console.WriteLine(IsValidWord("234Adas")); // Output: True
        Console.WriteLine(IsValidWord("b3"));      // Output: False
        Console.WriteLine(IsValidWord("a3$e"));    // Output: False
    }
}

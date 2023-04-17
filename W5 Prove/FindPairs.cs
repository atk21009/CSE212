namespace prove_05;

/**
 * CSE212 
 * (c) BYU-Idaho
 * 05-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 */
public static class FindPairs {
    public static void Run() {
        DisplayPairs(new[] { "am", "at", "ma", "if", "fi" }); // ma & am, fi & if
        Console.WriteLine("=============");
        DisplayPairs(new[] { "ab", "bc", "cd", "de", "ba" }); // ba & ab
        Console.WriteLine("=============");
        DisplayPairs(new[] { "ab", "ba", "ac", "ad", "da", "ca" }); // ba & ab, da & ad, ca & ac
        Console.WriteLine("=============");
        DisplayPairs(new[] { "ab", "ac" }); // None
        Console.WriteLine("=============");
        DisplayPairs(new[] { "ab", "aa", "ba" }); // ba & ab
        Console.WriteLine("=============");
        DisplayPairs(new[] { "23", "84", "49", "13", "32", "46", "91", "99", "94", "31", "57", "14" });
        // 32 & 23, 94 & 49, 31 & 13
    }

    /// <summary>
    /// The words parameter contains a list of two character 
    /// words (lower case, no duplicates). Using sets, find an O(n) 
    /// solution for displaying all symmetric pairs of words.  
    ///
    /// For example, if words was: [am, at, ma, if, fi], we would display:
    /// am & ma
    /// if & fi
    /// The order of the display above does not matter.  'at' would not 
    /// be displayed because 'ta' is not in the list of words.
    ///
    /// As a special case, if the letters are the same (example: 'aa') then
    /// it would not match anything else (remember no the assumption above
    /// that there were no duplicates) and therefore should not be displayed.
    /// </summary>
    /// <param name="words">An array of 2-character words (lowercase, no duplicates)</param>
    private static void DisplayPairs(string[] words)
    {
        List<string> results = new List<string>(); // set an empty list 
        foreach (var element in words) // loop through each element in array
        {
            char[] charArray = element.ToCharArray(); // change to char array
            Array.Reverse(charArray); // reverse element
            var reverse = new string(charArray); // set element to variable
            
            if (words.Contains(reverse)) // if array contains reverse
            {
                if (reverse != element) // if reverse isn't the same as element
                {
                    string resString = $"{reverse} & {element}"; // create string and add to results 
                    results.Add(resString);
                    var index = Array.IndexOf(words, reverse); // find index of reversed word and set it to null
                    words[index] = "null";
                }
                
            }
        }

        Console.WriteLine(string.Join(", ", results));
    }
}
public class Solution {
    
    public string SortVowels(string s) {
        List<int> indices = new List<int>();
        List<char> vowels = new List<char>();

        // Collect vowels and their indices

        for (int i = 0; i < s.Length; i++) {
            if (IsVowel(s[i])) {
                indices.Add(i);
                vowels.Add(s[i]);
            }
        }

        // Sort vowels by ASCII

        vowels.Sort();

        // Replace vowels in their positions

        char[] result = s.ToCharArray();
        for (int i = 0; i < indices.Count; i++) {
            result[indices[i]] = vowels[i];
        }

        string finalResult = new string(result);
        return finalResult;
    }


    //Checks for potential Vowel slippage
    
    private static readonly HashSet<char> Vowels = new HashSet<char> {
        'a','e','i','o','u','A','E','I','O','U'
    };
    
    private bool IsVowel(char c) {
        return Vowels.Contains(c);
    }
}

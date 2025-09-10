public class Solution {
    public int LengthOfLastWord(string s) {
        

        //creates an array and removes any empty's
        string[] wordsArray = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        //Removes the last word in that array and stores it as a string
        string lastWord = wordsArray[wordsArray.Length - 1];

        //returns that last word back as our final result
        return lastWord.Length;

    }
}

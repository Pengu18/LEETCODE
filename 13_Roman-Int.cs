//Leetcode #13 roman to integer  

// runtime 3ms  memory 51.2mb  

//completed in 17m 52seconds

public class Solution {
    public int RomanToInt(string s) {
       Dictionary<char, int> values = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int rest = 0;

        for (int i = 0; i < s.Length - 1; i++) {
            if (values[s[i]] < values[s[i + 1]]) {
                rest -= values[s[i]];
            } else {
                rest += values[s[i]];
            }
        }

        rest += values[s[s.Length - 1]];
        return rest;
    }
}

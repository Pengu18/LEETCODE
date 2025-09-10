// Given an integr x, return true if x is a palindrome, and false otherwise 

//Follow up: could you solve it without converting the int to a string...

/*Provided example 

Input x= -121 output= false   explination from left to right, it reads -121. From right to left it becomes 121-. Therefore it is not a palindrome.
Input x= 121 output= true     explination reads as 121 from left to right and from right to left 

/// Initally i want to convert to a string but also kinda want the bonus points for not doing that.. so lets see what we can do...*/


public class Solution {
    public bool IsPalindrome(int x) {

            if (x < 0) return false;
      
                int[] digits = x.ToString().Select(c => c - '0').ToArray();
                    for (int i = 0; i < digits.Length / 2; i++) {
                        if (digits[i] != digits[digits.Length - 1 - i]) {
                            return false;
            }
        }
        return true;  //forgot to add this was causing me problems LMAO
    }
}


//Time taken: 15 m 39 s 

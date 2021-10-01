/*
 * @lc app=leetcode id=1328 lang=csharp
 *
 * [1328] Break a Palindrome
 */

// @lc code=start
public class Solution {
    public string BreakPalindrome(string palindrome) {
        if (palindrome.Length == 1)
            return string.Empty;
        
        var array = palindrome.ToCharArray();
        
        var m = palindrome.Length / 2;
        int i = 0;
        for (; i < m; i++)
            if (palindrome[i] != 'a')
            {
                array[i] = 'a';
                return new string(array);
            }
        
        array[palindrome.Length - 1] = 'b';
        return new string(array);
    }
}
// @lc code=end


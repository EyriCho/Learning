/*
 * @lc app=leetcode id=17 lang=csharp
 *
 * [17] Letter Combinations of a Phone Number
 */

// @lc code=start
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        var result = new List<string>();
        if (digits.Length == 0)
            return result;
        
        var temp = new char[digits.Length];
        var dict = new Dictionary<char, char[]> {
            {'2', new char[] { 'a', 'b', 'c' } },
            {'3', new char[] { 'd', 'e', 'f' } },
            {'4', new char[] { 'g', 'h', 'i' } },
            {'5', new char[] { 'j', 'k', 'l' } },
            {'6', new char[] { 'm', 'n', 'o' } },
            {'7', new char[] { 'p', 'q', 'r', 's' } },
            {'8', new char[] { 't', 'u', 'v' } },
            {'9', new char[] { 'w', 'x', 'y', 'z' } },
        };
        
        void Combine(int i)
        {
            if (i == digits.Length)
            {
                result.Add(new string(temp));
                return;
            }
            
            foreach (var c in dict[digits[i]])
            {
                temp[i] = c;
                Combine(i + 1);
            }
        }
        
        Combine(0);
        
        return result;
    }
}
// @lc code=end


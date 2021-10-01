/*
 * @lc app=leetcode id=848 lang=csharp
 *
 * [848] Shifting Letters
 */

// @lc code=start
public class Solution {
    public string ShiftingLetters(string s, int[] shifts) {
        var array = s.ToCharArray();
        
        var prev = 0;
        
        for (int i = s.Length - 1; i > -1; i--)
        {
            var shift = (shifts[i] + prev) % 26;
            
            array[i] = (char)(array[i] + shift);
            if (array[i] > 'z')
                array[i] = (char)(array[i] - 26);
            
            prev = shift;
        }
        
        return new string(array);
    }
}
// @lc code=end


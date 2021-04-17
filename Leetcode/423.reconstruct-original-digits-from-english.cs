/*
 * @lc app=leetcode id=423 lang=csharp
 *
 * [423] Reconstruct Original Digits from English
 */

// @lc code=start
public class Solution {
    public string OriginalDigits(string s) {
        int[] chars = new int[26];
        foreach (var c in s)
            chars[c - 'a']++;
        
        int[] digits = new int[10];
        int length = 0;
        digits[0] = chars[25]; // count 'z' for zero
        digits[2] = chars[22]; // count 'w' for two
        digits[4] = chars[20]; // count 'u' for four
        digits[6] = chars[23]; // count 'x' for six
        digits[8] = chars[6]; // count 'g' for eight
        digits[3] = chars[17] - digits[0] - digits[4]; // count 'r' for three
        digits[7] = chars[18] - digits[6]; // count 's' for seven
        digits[5] = chars[21] - digits[7]; // count 'v' for five
        digits[1] = chars[14] - digits[0] - digits[2] - digits[4]; // count 'o' for one
        digits[9] = chars[8] - digits[5] - digits[6] - digits[8]; // count 'i' for nine
        length += digits[0] + digits[1] + digits[2];
        length += digits[3] + digits[4] + digits[5];
        length += digits[6] + digits[7] + digits[8] + digits[9];
        
        var result = new char[length];
        for (int i = 9; i >= 0; i--)
            while (digits[i]-- > 0)
                result[--length] = (char)('0' + i);
        
        return new string(result);
    }
}
// @lc code=end


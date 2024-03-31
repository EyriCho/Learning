/*
 * @lc app=leetcode id=2864 lang=csharp
 *
 * [2864] Maximum Odd Binary Number
 */

// @lc code=start
public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int i = 0;
        char[] array = new char[s.Length];
        Array.Fill(array, '0');
        array[s.Length - 1] = '1';

        foreach (char c in s)
        {
            if (c == '1')
            {
                array[i++] = '1';
            }
        }
        
        if (i < s.Length)
        {
            array[--i] = '0';
        }
        return new string(array);
    }
}
// @lc code=end


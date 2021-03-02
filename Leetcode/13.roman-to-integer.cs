/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        char index = 'I';
        
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == 'I')
            {
                if (index == 'V' || index == 'X')
                    result--;
                else
                    result++;
            }
            else if (s[i] == 'V')
            {
                result += 5;
                index = 'V';
            }
            else if (s[i] == 'X')
            {
                if (index == 'L' || index == 'C')
                    result -= 10;
                else
                {
                    result += 10;
                    index = 'X';
                }
            }
            else if (s[i] == 'L')
            {
                result += 50;
                index = 'L';
            }
            else if (s[i] == 'C')
            {
                if (index == 'D' || index == 'M')
                {
                    result -= 100;
                }
                else
                {
                    result += 100;
                    index = 'C';
                }
            }
            else if (s[i] == 'D')
            {
                result += 500;
                index = 'D';
            }
            else if (s[i] == 'M')
            {
                result += 1000;
                index = 'M';
            }
        }
        
        return result;
    }
}
// @lc code=end


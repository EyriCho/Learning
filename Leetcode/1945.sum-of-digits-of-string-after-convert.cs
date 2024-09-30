/*
 * @lc app=leetcode id=1945 lang=csharp
 *
 * [1945] Sum of Digits of String After Convert
 */

// @lc code=start
public class Solution {
    public int GetLucky(string s, int k) {
        int[] map = new int[] {
            1, 2, 3, 4, 5,
            6, 7, 8, 9, 1,
            2, 3, 4, 5, 6,
            7, 8, 9, 10, 2,
            3, 4, 5, 6, 7,
            8,
        };

        int result = 0,
            num = 0;
        foreach (char c in s)
        {
            result += map[c - 'a'];
        }

        k--;
        while (k-- > 0)
        {
            num = result;
            result = 0;
            while (num > 0)
            {
                result += num % 10;
                num /= 10;
            }
        }

        return result;
    }
}
// @lc code=end


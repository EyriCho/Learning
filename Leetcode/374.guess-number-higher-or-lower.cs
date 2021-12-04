/*
 * @lc app=leetcode id=374 lang=csharp
 *
 * [374] Guess Number Higher or Lower
 */

// @lc code=start
/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int l = 1, r = n;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            var re = guess(m);
            if (re < 0)
                r = m - 1;
            else if (re > 0)
                l = m + 1;
            else
                return m;
        }
        
        return l;
    }
}
// @lc code=end


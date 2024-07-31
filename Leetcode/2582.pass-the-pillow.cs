/*
 * @lc app=leetcode id=2582 lang=csharp
 *
 * [2582] Pass the Pillow
 */

// @lc code=start
public class Solution {
    public int PassThePillow(int n, int time) {
        int round = time / (n - 1),
            remain = time % (n - 1);

        return round % 2 == 0 ?
            (remain + 1) :
            (n - remain);
    }
}
// @lc code=end


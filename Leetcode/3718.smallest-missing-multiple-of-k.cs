/*
 * @lc app=leetcode id=3718 lang=csharp
 *
 * [3718] Smallest Missing Multiple of K
 */

// @lc code=start
public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        bool[] bucket = new bool[101];
        foreach (int n in nums)
        {
            bucket[n] = true;
        }

        int num = k;
        for (; num < bucket.Length; num += k)
        {
            if (!bucket[num])
            {
                return num;
            }
        }

        return num;
    }
}
// @lc code=end


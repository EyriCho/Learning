/*
 * @lc app=leetcode id=274 lang=csharp
 *
 * [274] H-Index
 */

// @lc code=start
public class Solution {
    public int HIndex(int[] citations) {
        if (citations.Length < 1) return 0;
        var array = new int[citations.Length + 1];
        for (int i = 0; i < citations.Length; i++)
        {
            if (citations[i] > citations.Length)
                array[citations.Length]++;
            else
                array[citations[i]]++;
        }
        int sum = 0;
        for (int i = citations.Length; i >= 0; i--)
        {
            sum += array[i];
            if (sum >= i) return i;
        }
        return 0;
    }
}
// @lc code=end


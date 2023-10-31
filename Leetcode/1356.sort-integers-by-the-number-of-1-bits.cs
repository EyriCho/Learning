/*
 * @lc app=leetcode id=1356 lang=csharp
 *
 * [1356] Sort Integers by The Number of 1 Bits
 */

// @lc code=start
public class Solution {
    public int[] SortByBits(int[] arr) {
        Dictionary<int, int> dict = new();

        int GetBits(int num)
        {
            var c = 0;
            while (num > 0)
            {
                c++;
                num &= (num - 1);
            }
            return c;
        }
        
        Array.Sort(arr, (a, b) => {
            if (!dict.TryGetValue(a, out int ca))
            {
                ca = dict[a] = GetBits(a);
            }

            if (!dict.TryGetValue(b, out int cb))
            {
                cb = dict[b] = GetBits(b);
            }

            return ca == cb ? (a - b) : (ca - cb);
        });

        return arr;
    }
}
// @lc code=end


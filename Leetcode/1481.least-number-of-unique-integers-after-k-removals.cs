/*
 * @lc app=leetcode id=1481 lang=csharp
 *
 * [1481] Least Number of Unique Integers after K Removals
 */

// @lc code=start
public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
        Dictionary<int, int> dict = new();

        foreach (int num in arr)
        {
            dict.TryGetValue(num, out int c);
            dict[num] = c + 1;
        }

        int result = dict.Count();
        List<int> counts = dict.Values.ToList();
        counts.Sort();
        foreach (int count in counts)
        {
            if (k >= count)
            {
                k -= count;
                result--;
            }
            else
            {
                break;
            }
        }

        return result;
    }
}
// @lc code=end


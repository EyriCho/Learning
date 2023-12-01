/*
 * @lc app=leetcode id=1424 lang=csharp
 *
 * [1424] Diagonal Traverse II
 */

// @lc code=start
public class Solution {
    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
        int count = 0;
        SortedDictionary<int, IList<int>> dict = new();
        for (int i = 0; i < nums.Count; i++)
        {
            count += nums[i].Count;
            for (int j = 0; j < nums[i].Count; j++)
            {
                int k = i + j;
                if (!dict.TryGetValue(k, out IList<int> list))
                {
                    dict[k] = list = new List<int>();
                }

                list.Add(nums[i][j]);
            }
        }

        int[] result = new int[count];
        int x = 0;
        foreach (KeyValuePair<int, IList<int>> kv in dict)
        {
            for (int i = kv.Value.Count - 1; i >= 0; i--)
            {
                result[x++] = kv.Value[i];
            }
        }

        return result;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=1282 lang=csharp
 *
 * [1282] Group the People Given the Group Size They Belong To
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        var dict = new Dictionary<int, IList<int>>();

        var result = new List<IList<int>>();
        for (int i = 0; i < groupSizes.Length; i++)
        {
            if (!dict.TryGetValue(groupSizes[i], out IList<int> list))
            {
                dict[groupSizes[i]] = list = new List<int>();
            }

            list.Add(i);

            if (list.Count == groupSizes[i])
            {
                result.Add(list);
                dict.Remove(groupSizes[i]);
            }
        }

        return result;
    }
}
// @lc code=end


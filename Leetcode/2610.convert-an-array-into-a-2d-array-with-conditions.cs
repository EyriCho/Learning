/*
 * @lc app=leetcode id=2610 lang=csharp
 *
 * [2610] Convert an Array Into a 2D Array With Conditions
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums) {
        List<IList<int>> result = new ();
        Dictionary<int, int> dict = new ();

        foreach (int num in nums)
        {
            if (!dict.TryGetValue(num, out int count))
            {
                count = 0;
            }
            dict[num] = count + 1;
        }

        foreach (KeyValuePair<int, int> kv in dict)
        {
            int i = 0;
            while (i < kv.Value)
            {
                if (result.Count - 1 < i)
                {
                    result.Add(new List<int>());
                }

                result[i++].Add(kv.Key);
            }
        }

        return result;
    }
}
// @lc code=end


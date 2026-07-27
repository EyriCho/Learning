/*
 * @lc app=leetcode id=3020 lang=csharp
 *
 * [3020] Find the Maximum Number of Elements in Subset
 */

// @lc code=start
public class Solution {
    public int MaximumLength(int[] nums) {
        Dictionary<int, int> dict = new ();
        int count = 0;
        foreach (int num in nums)
        {
            dict.TryGetValue(num, out count);
            dict[num] = count + 1;
        }

        int result = 0,
            len = 0;
        if (dict.ContainsKey(1))
        {
            result = dict[1] - ((dict[1] % 2 == 1) ? 0 : 1);
        }

        long sqrt = 0L;

        foreach (KeyValuePair<int, int> kv in dict)
        {
            if (kv.Key == 1 || kv.Value == 1)
            {
                result = Math.Max(result, 1);
                continue;
            }

            len = 1;
            sqrt = 1L * kv.Key * kv.Key;
            while (sqrt <= 1_000_000_000 &&
                dict.ContainsKey((int)sqrt))
            {
                len++;
                if (dict[(int)sqrt] == 1)
                {
                    break;
                }

                sqrt = sqrt * sqrt;
            }

            result = Math.Max(result, (len << 1) - 1);
        }

        return result;
    }
}
// @lc code=end


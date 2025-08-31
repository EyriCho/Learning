/*
 * @lc app=leetcode id=2561 lang=csharp
 *
 * [2561] Rearranging Fruits
 */

// @lc code=start
public class Solution {
    public long MinCost(int[] basket1, int[] basket2) {
        Dictionary<int, int> dict = new ();
        int count = 0,
            min = int.MaxValue;
        foreach (int num in basket1)
        {
            dict.TryGetValue(num, out count);
            dict[num] = count + 1;
            min = Math.Min(min, num);
        }
        foreach (int num in basket2)
        {
            dict.TryGetValue(num, out count);
            dict[num] = count - 1;
            min = Math.Min(min, num);
        }

        List<int> list = new ();
        foreach (KeyValuePair<int, int> kv in dict)
        {
            count = kv.Value > 0 ? kv.Value : -kv.Value;
            if ((count & 1) > 0)
            {
                return -1L;
            }
            count >>= 1;
            while (count-- > 0)
            {
                list.Add(kv.Key);
            }
        }
        list.Sort();

        min <<= 1;
        long result = 0L;
            count = list.Count / 2;
        for (int i = 0; i < count; i++)
        {
            result += Math.Min(list[i], min);
        }
        return result;
    }
}
// @lc code=end


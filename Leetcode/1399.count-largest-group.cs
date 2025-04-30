/*
 * @lc app=leetcode id=1399 lang=csharp
 *
 * [1399] Count Largest Group
 */

// @lc code=start
public class Solution {
    public int CountLargestGroup(int n) {
        Dictionary<int, int> dict = new ();
        int num = 0,
            sum = 0,
            count = 0;
        for (int i = 0; i < n; i++)
        {
            num = i + 1;
            sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            dict.TryGetValue(sum, out count);
            dict[sum] = count + 1;
        }

        int result = 0,
            max = 0;
        foreach (KeyValuePair<int, int> kv in dict)
        {
            if (kv.Value == max)
            {
                result++;
            }
            else if (kv.Value > max)
            {
                max = kv.Value;
                result = 1;
            }
        }

        return result;
    }
}
// @lc code=end


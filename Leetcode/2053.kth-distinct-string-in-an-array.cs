/*
 * @lc app=leetcode id=2053 lang=csharp
 *
 * [2053] Kth Distinct String in an Array
 */

// @lc code=start
public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string, int> dict = new ();
        int count = 0;
        foreach (string s in arr)
        {
            dict.TryGetValue(s, out count);
            dict[s] = count + 1;
        }

        count = 0;
        foreach (string s in arr)
        {
            if (dict[s] == 1)
            {
                count++;
                if (count == k)
                {
                    return s;
                }
            }
        }

        return string.Empty;
    }
}
// @lc code=end


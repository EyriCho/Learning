/*
 * @lc app=leetcode id=2264 lang=csharp
 *
 * [2264] Largest 3-Same-Digit Number in String
 */

// @lc code=start
public class Solution {
    public string LargestGoodInteger(string num) {
        int count = 0;
        string result = string.Empty;

        for (int i = 1; i < num.Length; i++)
        {
            if (result != string.Empty &&
                result[0] >= num[i])
            {
                continue;
            }

            if (num[i] == num[i - 1])
            {
                if (count == 0)
                {
                    count = 2;
                }
                else
                {
                    result = num[(i - 2)..(i + 1)];
                }
            }
            else
            {
                count = 0;
            }
        }

        return result;
    }
}
// @lc code=end


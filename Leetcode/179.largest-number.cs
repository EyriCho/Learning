/*
 * @lc app=leetcode id=179 lang=csharp
 *
 * [179] Largest Number
 */

// @lc code=start
public class Solution {
    public string LargestNumber(int[] nums) {
        string[] array = new string[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            array[i] = nums[i].ToString();
        }

        Array.Sort(array, (a, b) => string.Concat(b, a).CompareTo(string.Concat(a, b)));
        string result = string.Join("", array);

        return result[0] == '0' ? "0" : result;
    }
}
// @lc code=end


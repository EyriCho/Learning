/*
 * @lc app=leetcode id=179 lang=csharp
 *
 * [179] Largest Number
 */

// @lc code=start
public class Solution {
    public string LargestNumber(int[] nums) {
        string[] str = new string[nums.Length];
        
        bool isZero = true;
        for (int i = 0; i < nums.Length; i++)
        {
            str[i] = nums[i].ToString();
            if (nums[i] > 0)
                isZero = false;
        }
        if (isZero)
            return "0";
        
        Array.Sort(
            str,
            Comparer<string>.Create((x, y) => {
                return string.Compare(y + x, x + y);
            }));        
        return string.Concat(str);
    }
}
// @lc code=end


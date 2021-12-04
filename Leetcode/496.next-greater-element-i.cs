/*
 * @lc app=leetcode id=496 lang=csharp
 *
 * [496] Next Greater Element I
 */

// @lc code=start
public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var stack = new Stack<int>();
        var dict = new Dictionary<int, int>();
        
        foreach (var num in nums2)
        {
            while (stack.Count > 0 && stack.Peek() < num)
            {
                dict[stack.Pop()] = num;
            }
            stack.Push(num);
        }
        
        var result = new int[nums1.Length];
        
        for (int i = 0; i < nums1.Length; i++)
        {
            result[i] = dict.ContainsKey(nums1[i]) ? dict[nums1[i]] : -1;
        }
        
        return result;
    }
}
// @lc code=end


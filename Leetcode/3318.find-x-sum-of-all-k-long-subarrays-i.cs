/*
 * @lc app=leetcode id=3318 lang=csharp
 *
 * [3318] Find X-Sum of All K-Long Subarrays I
 */

// @lc code=start
public class Solution {
    public int[] FindXSum(int[] nums, int k, int x) {
        int Sum(int[] array)
        {
            Dictionary<int, int> dict = new ();
            int count = 0;
            foreach (int num in array)
            {
                dict.TryGetValue(num, out count);
                dict[num] = count + 1;
            }

            int[] keys = dict.Keys.ToArray();
            Array.Sort(keys, (a, b) => dict[a] == dict[b] ? b.CompareTo(a) :
                dict[b].CompareTo(dict[a]));
            
            int rst = 0;
            for (int i = 0; i < x && i < keys.Length; i++)
            {
                rst += dict[keys[i]] * keys[i];
            }
            return rst;
        }

        int[] result = new int[nums.Length - k + 1];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = Sum(nums[i..(i + k)]);
        }
        return result;
    }
}
// @lc code=end


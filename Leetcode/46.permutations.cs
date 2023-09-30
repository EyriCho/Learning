/*
 * @lc app=leetcode id=46 lang=csharp
 *
 * [46] Permutations
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();

        void Recursive(int i)
        {
            if (i == nums.Length)
            {
                result.Add(nums.ToList());
                return;
            }

            Recursive(i + 1);
            var num = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                nums[i] = nums[j];
                nums[j] = num;
                Recursive(i + 1);
                nums[j] = nums[i];
            }
            nums[i] = num;
        }

        Recursive(0);
        return result;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=698 lang=csharp
 *
 * [698] Partition to K Equal Sum Subsets
 */

// @lc code=start
public class Solution {
    public bool CanPartitionKSubsets(int[] nums, int k) {
        int sum = 0;
        foreach (var num in nums)
            sum += num;
        if (sum % k > 0)
            return false;
        
        
        Array.Sort(nums, (a, b) => b - a);
        var average = sum / k;
        if (nums[0] > average)
            return false;
        
        var partitions = new int[k];
        Array.Fill(partitions, average);
        bool Dfs(int index)
        {
            if (index == nums.Length)
                return true;
            
            for (int i = 0; i < partitions.Length; i++)
            {
                if (partitions[i] > 0 && partitions[i] >= nums[index])
                {
                    partitions[i] -= nums[index];
                    
                    if (Dfs(index + 1))
                        return true;
                    
                    partitions[i] += nums[index];
                }
            }
            return false;
        }
        
        return Dfs(0);
    }
}
// @lc code=end


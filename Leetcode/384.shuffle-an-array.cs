/*
 * @lc app=leetcode id=384 lang=csharp
 *
 * [384] Shuffle an Array
 */

// @lc code=start
public class Solution {

    public Solution(int[] nums) {
        origin = nums;
        shuffled = new int[nums.Length];
        rand = new Random();
    }
    
    int[] origin;
    int[] shuffled;
    Random rand;
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        for (int i = 0; i < origin.Length; i++)
            shuffled[i] = origin[i];
        return shuffled;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        for (int i = 0; i < origin.Length; i++)
            shuffled[i] = origin[i];
        
        for (int i = 0; i < origin.Length; i++)
        {
            var swtc = rand.Next(origin.Length);
            if (swtc != i)
            {
                shuffled[i] ^= shuffled[swtc];
                shuffled[swtc] ^= shuffled[i];
                shuffled[i] ^= shuffled[swtc];                
            }
        }
        
        return shuffled;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
// @lc code=end


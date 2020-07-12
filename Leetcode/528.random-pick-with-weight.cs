/*
 * @lc app=leetcode id=528 lang=csharp
 *
 * [528] Random Pick with Weight
 */

// @lc code=start
public class Solution {
    private Random random;
    private int[] array;

    public Solution(int[] w) {
        random = new Random();
        for (int i = 1; i < w.Length; i++)
        {
            w[i] += w[i-1];
        }
        array = w;
    }
    
    public int PickIndex() {
        var val = random.Next(array[array.Length - 1]);
        int l = 0, r = array.Length - 1;
        while (l < r)
        {
            int mid = (l + r) / 2;
            if (array[mid] <= val)
                l = mid + 1;
            else
                r = mid;
        }
        return l;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */
// @lc code=end


/*
 * @lc app=leetcode id=497 lang=csharp
 *
 * [497] Random Point in Non-overlapping Rectangles
 */

// @lc code=start
public class Solution {
    int index;
    int[][] rects;
    int x;
    int y;

    public Solution(int[][] rects) {
        index = 0;
        this.rects = rects;
        x = rects[index][0];
        y = rects[index][1];
    }
    
    public int[] Pick() {
        var result = new int[2] { x, y };
        
        x++;
        if (x > rects[index][2])
        {
            x = rects[index][0];
            y++;
            
            if (y > rects[index][3])
            {
                index = (index + 1) % rects.Length;
                x = rects[index][0];
                y = rects[index][1];
            }
        }
        
        return result;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(rects);
 * int[] param_1 = obj.Pick();
 */
// @lc code=end


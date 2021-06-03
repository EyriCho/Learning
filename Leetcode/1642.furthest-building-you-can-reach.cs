/*
 * @lc app=leetcode id=1642 lang=csharp
 *
 * [1642] Furthest Building You Can Reach
 */

// @lc code=start
public class Solution {
    public int FurthestBuilding(int[] heights, int bricks, int ladders) {
        if (ladders > heights.Length - 2)
            return heights.Length - 1;
        
        int i = 0, last = heights.Length - 1;
        var array = new int[ladders + 1];
        int length = 0;
        
        void Add(int value)
        {
            array[length++] = value;
            var i = length - 1;
            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if (array[i] >= array[parent])
                    return;
                
                int temp = array[parent];
                array[parent] = array[i];
                array[i] = temp;
                i = parent;
            }
        }
        
        int Pop()
        {
            var result = array[0];
            
            array[0] = array[--length];
            int i = 0;
            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;
                
                if (l >= length)
                    break;
                
                if (array[i] > array[l] ||
                    (r < length && array[i] > array[r]))
                {
                    if (r >= length || array[l] <= array[r])
                    {
                        int temp = array[i];
                        array[i] = array[l];
                        array[l] = temp;
                        i = l;
                    }
                    else
                    {
                        int temp = array[i];
                        array[i] = array[r];
                        array[r] = temp;
                        i = r;                    
                    }
                }
                else
                    break;
            }
            
            return result;
        }
        
        for (;i < last; i++)
        {
            if (heights[i + 1] > heights[i])
            {
                Add(heights[i + 1] - heights[i]);

                if (length > ladders)
                {
                    bricks -= Pop();
                    if (bricks < 0)
                        return i;
                }
            }
        }
        
        return heights.Length - 1;
    }
}
// @lc code=end


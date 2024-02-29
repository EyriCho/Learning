/*
 * @lc app=leetcode id=1642 lang=csharp
 *
 * [1642] Furthest Building You Can Reach
 */

// @lc code=start
public class Solution {
    public int FurthestBuilding(int[] heights, int bricks, int ladders) {
        if (ladders > heights.Length - 2)
        {
            return heights.Length - 1;
        }

        int[] array = new int[ladders + 1];
        int length = 0;

        void Add(int bricks)
        {
            int i = length++,
                p = 0;
            array[i] = bricks;
            while (i > 0)
            {
                p = (i - 1) >> 1;
                if (array[i] >= array[p])
                {
                    return;
                }

                array[i] ^= array[p];
                array[p] ^= array[i];
                array[i] ^= array[p];
                i = p;
            }
        }

        int Pop()
        {
            int rst = array[0];
            array[0] = array[--length];
            int i = 0,
                l = 0,
                r = 0;
            while (true)
            {
                l = i * 2 + 1;
                r = i * 2 + 2;

                if (l >= length)
                {
                    break;
                }

                if (array[i] > array[l] ||
                    (r < length && array[i] > array[r]))
                {
                    if (r >= length || array[l] <= array[r])
                    {
                        array[i] ^= array[l];
                        array[l] ^= array[i];
                        array[i] ^= array[l];
                        i = l;
                    }
                    else
                    {
                        array[i] ^= array[r];
                        array[r] ^= array[i];
                        array[i] ^= array[r];
                        i = r;
                    }
                }
                else 
                {
                    break;
                }
            }

            return rst;
        }

        int diff = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            diff = heights[i] - heights[i - 1];
            if (diff > 0)
            {
                Add(diff);
                if (length > ladders)
                {
                    bricks -= Pop();
                    if (bricks < 0)
                    {
                        return i - 1;
                    }
                }
            }
        }

        return heights.Length - 1;
   }
}
// @lc code=end


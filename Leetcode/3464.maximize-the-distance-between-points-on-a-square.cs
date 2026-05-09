/*
 * @lc app=leetcode id=3464 lang=csharp
 *
 * [3464] Maximize the Distance Between Points on a Square
 */

// @lc code=start
public class Solution {
    public int MaxDistance(int side, int[][] points, int k) {
        long[] array = new long[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            if (points[i][0] == 0)
            {
                array[i] = points[i][1];
            }
            else if (points[i][1] == side)
            {
                array[i] = 0L + side + points[i][0];
            }
            else if (points[i][0] == side)
            {
                array[i] = 3L * side - points[i][1];
            }
            else
            {
                array[i] = 4L * side - points[i][0];
            }
        }
        Array.Sort(array);

        bool Check(long limit)
        {
            long end = 0L,
                target = 0L,
                cur = 0L;
            int left = 0, mid = 0, right = 0;
            foreach (long start in array)
            {
                end = start + 4L * side - limit;
                cur = start;
                
                for (int i = 0; i < k - 1; i++)
                {
                    target = cur + limit;
                    left = 0;
                    right = array.Length;
                    while (left < right)
                    {
                        mid = left + ((right - left) >> 1);
                        if (array[mid] < target)
                        {
                            left = mid + 1;
                        }
                        else
                        {
                            right = mid;
                        }
                    }

                    if (left == array.Length ||
                        array[left] > end)
                    {
                        cur = -1L;
                        break;
                    }
                    cur = array[left];
                }
                
                if (cur >= 0)
                {
                    return true;
                }
            }

            return false;
        }
 
        long l = 1L, r = side, m = 0L,
            result = 0L;
        while (l <= r)
        {
            m = (l + r) >> 1;
            if (Check(m))
            {
                l = m + 1;
                result = m;
            }
            else
            {
                r = m - 1;
            }
        }
        
        return (int)result;
    }
}
// @lc code=end


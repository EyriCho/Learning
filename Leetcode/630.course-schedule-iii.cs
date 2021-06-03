/*
 * @lc app=leetcode id=630 lang=csharp
 *
 * [630] Course Schedule III
 */

// @lc code=start
public class Solution {
    public int ScheduleCourse(int[][] courses) {
        Array.Sort(courses, (a, b) => a[1] - b[1]);
        
        var array = new int[courses.Length + 1];
        var length = 0;
        
        void Add(int val)
        {
            array[length++] = val;
            var i = length - 1;
            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if (array[i] >= array[parent])
                {
                    var temp = array[i];
                    array[i] = array[parent];
                    array[parent] = temp;
                }
                i = parent;
            }
        }
        
        int Pop()
        {
            var result = array[0];
            array[0] = array[--length];
            var i = 0;
            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;
                
                if (l >= length)
                    break;
                
                if (array[l] > array[i] ||
                   (r < length && array[r] > array[i]))
                {
                    if (r >= length || array[l] > array[r])
                    {
                        var temp = array[i];
                        array[i] = array[l];
                        array[l] = temp;
                        i = l;
                    }
                    else
                    {
                        var temp = array[i];
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
        
        int total = 0;
        foreach (var course in courses)
        {
            total += course[0];
            Add(course[0]);
            if (total > course[1])
                total -= Pop();
        }
        return length;
    }
}
// @lc code=end


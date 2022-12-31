/*
 * @lc app=leetcode id=1834 lang=csharp
 *
 * [1834] Single-Threaded CPU
 */

// @lc code=start
public class Solution {
    public int[] GetOrder(int[][] tasks) {
        var taskArray = new int[tasks.Length][];
        for (int i = 0; i < tasks.Length; i++)
        {
            taskArray[i] = new int[3] {
                tasks[i][0],
                tasks[i][1],
                i
            };
        }

        Array.Sort(taskArray, (a, b) => a[0] - b[0]);
        
        var array = new int[tasks.Length][];
        int length = 0;

        int Compare (int[] a, int[] b)
        {
            if (a[0] < b[0])
            {
                return 1;
            }
            else if (a[0] == b[0])
            {
                if (a[1] < b[1])
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        void Add(int[] duration)
        {
            int i = length++;
            array[i] = duration;
            while (i > 0)
            {
                int p = (i - 1) >> 1;
                if (Compare(array[i], array[p]) < 0)
                {
                    break;
                }

                var temp = array[i];
                array[i] = array[p];
                array[p] = temp;
                i = p;
            }
        }

        int[] Pop()
        {
            var rst = array[0];
            array[0] = array[--length];
            int i = 0;
            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;

                if (l >= length)
                {
                    break;
                }

                if (Compare(array[i], array[l]) < 0 ||
                    (r < length && Compare(array[i], array[r]) < 0))
                {
                    if (r >= length || Compare(array[l], array[r]) > 0)
                    {
                        var temp = array[l];
                        array[l] = array[i];
                        array[i] = temp;
                        i = l;
                    }
                    else
                    {

                        var temp = array[r];
                        array[r] = array[i];
                        array[i] = temp;
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

        int index = 0;
        int time = 0;
        var result = new int[tasks.Length];
        int j = 0;
        while (j < tasks.Length)
        {
            if (length == 0)
            {
                time = Math.Max(time, taskArray[index][0]);
            }
            while (index < tasks.Length && taskArray[index][0] <= time)
            {
                Add(new int[] { taskArray[index][1], taskArray[index][2] });
                index++;
            }

            var task = Pop();
            result[j++] = task[1];
            time += task[0];
        }

        return result;
    }
}
// @lc code=end


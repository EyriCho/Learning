/*
 * @lc app=leetcode id=838 lang=csharp
 *
 * [838] Push Dominoes
 */

// @lc code=start
public class Solution {
    public string PushDominoes(string dominoes) {
        char[] array = dominoes.ToCharArray();
        Queue<int> queue = new ();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != '.')
            {
                queue.Enqueue(i);
            }
        }

        int c = 0,
            last = -1,
            l = -1,
            r = 0;

        while (queue.Count > 0)
        {
            c = queue.Dequeue();
            if (array[c] == 'L')
            {
                l = c;
                while (l > last)
                {
                    array[l--] = 'L';
                }
                last = c;
            }
            else
            {
                r = array.Length;
                if (queue.Count > 0)
                {
                    r = queue.Peek();
                }

                if (r == array.Length || array[r] == 'R')
                {
                    while (c < r)
                    {
                        array[c++] = 'R';
                    }
                    last = r;
                }
                else
                {
                    queue.Dequeue();
                    last = r;
                    while (++c < --r)
                    {
                        array[r] = 'L';
                        array[c] = 'R';
                    }
                }
            }
        }

        return new string(array);
    }
}
// @lc code=end


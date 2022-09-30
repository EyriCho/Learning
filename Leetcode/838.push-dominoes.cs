/*
 * @lc app=leetcode id=838 lang=csharp
 *
 * [838] Push Dominoes
 */

// @lc code=start
public class Solution {
    public string PushDominoes(string dominoes) {
        var array = dominoes.ToCharArray();
        
        var queue = new Queue<int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != '.')
            {
                queue.Enqueue(i);
            }
        }
        
        int last = -1;
        while (queue.Count > 0)
        {
            var i = queue.Dequeue();
            
            if (dominoes[i] == 'L')
            {
                var l = i;
                while (l > last)
                {
                    array[l--] = 'L';
                }
                last = i;
            }
            else
            {
                int r = dominoes.Length;
                if (queue.Count > 0)
                {
                    r = queue.Peek();
                }
                
                if (r == dominoes.Length || dominoes[r] == 'R')
                {
                    while (i < r)
                    {
                        array[i++] = 'R'; 
                    }
                    last = r;
                }
                else
                {
                    queue.Dequeue();
                    last = r;
                    while (++i < --r)
                    {
                        array[r] = 'L';
                        array[i] = 'R';
                    }
                }
            }
        }
        
        return new string(array);
    }
}
// @lc code=end


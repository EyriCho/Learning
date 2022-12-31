/*
 * @lc app=leetcode id=1962 lang=csharp
 *
 * [1962] Remove Stones to Minimize the Total
 */

// @lc code=start
public class Solution {
    public int MinStoneSum(int[] piles, int k) {
        var array = new int[piles.Length + 1];
        var length = 0;

        void Add(int num)
        {
            int i = length++;
            array[i] = num;
            while (i > 0)
            {
                int p = (i - 1) >> 1;
                if (array[p] >= array[i])
                {
                    break;
                }

                array[p] ^= array[i];
                array[i] ^= array[p];
                array[p] ^= array[i];
                
                i = p;
            }
        }

        int Pop()
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

                if (array[i] < array[l] ||
                    (r < length && array[i] < array[r]))
                {
                    if (r >= length || array[l] >= array[r])
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

        foreach (var pile in piles)
        {
            Add(pile);
        }

        while (k-- > 0)
        {
            var pile = Pop();
            Add(pile - pile / 2);
        }

        var result = 0;
        for (int i = 0; i < length; i++)
        {
            result += array[i];
        }
        return result;
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=1718 lang=csharp
 *
 * [1718] Construct the Lexicographically Largest Valid Sequence
 */

// @lc code=start
public class Solution {
    public int[] ConstructDistancedSequence(int n) {
        int[] result = new int[2 * n - 1];
        bool[] used = new bool[n + 1];
        
        bool Construct(int index)
        {
            if (index == result.Length)
            {
                return true;
            }

            if (result[index] > 0)
            {
                return Construct(index + 1);
            }

            for (int place = n; place > 0; place--)
            {
                if (used[place])
                {
                    continue;
                }

                result[index] = place;
                used[place] = true;
                if (place == 1)
                {
                    if (Construct(index + 1))
                    {
                        return true;
                    }
                }
                else if (index + place < result.Length &&
                    result[index + place] == 0)
                {
                    result[index + place] = place;

                    if (Construct(index + 1))
                    {
                        return true;
                    }
                    result[index + place] = 0;
                }
                
                result[index] = 0;
                used[place] = false;
            }

            return false;
        }
        
        Construct(0);
        return result;
    }
}
// @lc code=end


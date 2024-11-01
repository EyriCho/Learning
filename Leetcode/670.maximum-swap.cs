/*
 * @lc app=leetcode id=670 lang=csharp
 *
 * [670] Maximum Swap
 */

// @lc code=start
public class Solution {
    public int MaximumSwap(int num) {
        char[] array = num.ToString().ToCharArray();
        int[] lastIndex = new int[10];
        Array.Fill(lastIndex, -1);
        for (int i = 0; i < array.Length; i++)
        {
            lastIndex[array[i] - '0'] = i;
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 9; j > array[i] - '0'; j--)
            {
                if (lastIndex[j] > i)
                {
                    array[lastIndex[j]] = array[i];
                    array[i] = (char)('0' + j);
                    return int.Parse(new string(array));
                }
            }
        }
        
        return num;
    }
}
// @lc code=end


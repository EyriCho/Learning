/*
 * @lc app=leetcode id=451 lang=csharp
 *
 * [451] Sort Characters By Frequency
 */

// @lc code=start
public class Solution {
    public string FrequencySort(string s) {
        var array = new (char, int)[128];
        foreach (var c in s)
        {
            array[c - '1'].Item1 = c;
            array[c - '1'].Item2++;
        }
        
        Array.Sort(array, (a, b) => b.Item2 - a.Item2);
        
        var chars = new char[s.Length];
        int j = 0;
        for (int i = 0; i < 128; i++)
        {
            if (array[i].Item2 > 0)
            {
                Array.Fill(chars, array[i].Item1, j, array[i].Item2);
                j += array[i].Item2;
            }
            else
                break;
        }
        
        return new string(chars);
    }
}
// @lc code=end


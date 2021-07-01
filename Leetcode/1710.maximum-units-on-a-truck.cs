/*
 * @lc app=leetcode id=1710 lang=csharp
 *
 * [1710] Maximum Units on a Truck
 */

// @lc code=start
public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        Array.Sort(boxTypes, (a, b) => b[1] - a[1]);
        
        int i = 0, result = 0;
        while (i < boxTypes.Length && truckSize > 0)
        {
            if (truckSize > boxTypes[i][0])
            {
                result += boxTypes[i][0] * boxTypes[i][1];
                truckSize -= boxTypes[i][0];
            }
            else
            {
                result += truckSize * boxTypes[i][1];
                break;
            }
            i++;
        }
        
        return result;
    }
}
// @lc code=end


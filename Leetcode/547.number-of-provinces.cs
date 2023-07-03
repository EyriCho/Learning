/*
 * @lc app=leetcode id=547 lang=csharp
 *
 * [547] Number of Provinces
 */

// @lc code=start
public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        var provinces = new int[isConnected.Length];
        for (int i = 0; i < isConnected.Length; i++)
        {
            provinces[i] = i;
        }

        int FindProvince(int index)
        {
            if (provinces[index] != index)
            {
                return provinces[index] = FindProvince(provinces[index]);
            }
            else
            {
                return index;
            }
        }

        for (int i = 0; i < isConnected.Length; i++)
        {
            for (int j = i + 1; j < isConnected.Length; j++)
            {
                if (isConnected[i][j] == 1)
                {
                    int province1 = FindProvince(i),
                        province2 = FindProvince(j);

                    if (province1 != province2)
                    {
                        provinces[province2] = province1;
                    }
                }
            }
        }

        var result = 0;
        for (int i = 0; i < isConnected.Length; i++)
        {
            if (provinces[i] == i)
            {
                result++;
            }
        }

        return result;
    }
}
// @lc code=end


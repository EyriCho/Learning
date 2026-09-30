/*
 * @lc app=leetcode id=3568 lang=csharp
 *
 * [3568] Minimum Moves to Clean the Classroom
 */

// @lc code=start
public class Solution {
    public int MinMoves(string[] classroom, int energy) {
        (int x, int y) start = (0, 0);
        Dictionary<(int, int), int> dict = new ();
        int idx = 0;
        for (int i = 0; i < classroom.Length; i++)
        {
            for (int j = 0; j < classroom[0].Length; j++)
            {
                if (classroom[i][j] == 'S')
                {
                    start = (i, j);
                }
                else if(classroom[i][j] == 'L')
                {
                    dict[(i, j)] = idx++;
                }
            }
        }

        if (idx == 0)
        {
            return 0;
        }

        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        int final = (1 << idx) - 1;
        int[,,] bestEnergy = new int[classroom.Length, classroom[0].Length, 1 << idx];
        for (int i = 0; i < classroom.Length; i++)
        {
            for (int j = 0; j < classroom[0].Length; j++)
            {
                for (int k = 1; k <= final; k++)
                {
                    bestEnergy[i, j, k] = -1;
                }
            }
        }
        bestEnergy[start.x, start.y, 0] = energy;
        Queue<(int, int, int, int, int)> queue = new ();
        queue.Enqueue((start.x, start.y, 0, energy, 0));

        int x = 0, y = 0, mask = 0, e = 0, steps = 0,
            nx = 0, ny = 0, nextMask = 0, nextEnergy = 0;
        
        while (queue.Count > 0)
        {
            (x, y, mask, e, steps) = queue.Dequeue();

            for (int d = 0; d < 4; d++)
            {
                nx = x + ds[d, 0];
                ny = y + ds[d, 1];

                if (nx < 0 || nx >= classroom.Length ||
                    ny < 0 || ny >= classroom[0].Length ||
                    classroom[nx][ny] == 'X')
                {
                    continue;
                }

                nextMask = mask;
                nextEnergy = e - 1;
                if (classroom[nx][ny] == 'L')
                {
                    nextMask |= 1 << dict[(nx, ny)];
                }
                else if(classroom[nx][ny] == 'R')
                {
                    nextEnergy = energy;
                }

                if (bestEnergy[nx, ny, nextMask] >= nextEnergy)
                {
                    continue;
                }
                if (nextMask == final)
                {
                    return steps + 1;
                }
                if (nextEnergy == 0)
                {
                    continue;
                }
                queue.Enqueue((nx, ny, nextMask, nextEnergy, steps + 1));
                bestEnergy[nx, ny, nextMask] = nextEnergy;
            }
        }
        
        return -1;
    }
}
// @lc code=end


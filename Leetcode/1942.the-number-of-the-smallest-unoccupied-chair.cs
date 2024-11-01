/*
 * @lc app=leetcode id=1942 lang=csharp
 *
 * [1942] The Number of the Smallest Unoccupied Chair
 */

// @lc code=start
public class Solution {
    public int SmallestChair(int[][] times, int targetFriend) {
        int[] seats = new int[times.Length];
        int sLength = 0;

        void AddSeat(int num)
        {
            int i = sLength++,
                p = 0;
            seats[i] = num;
            while (i > 0)
            {
                p = (i - 1) >> 1;
                if (seats[p] <= seats[i])
                {
                    return;
                }

                seats[p] ^= seats[i];
                seats[i] ^= seats[p];
                seats[p] ^= seats[i];
                i = p;
            }
        }

        int PopSeat()
        {
            int rst = seats[0];
            seats[0] = seats[--sLength];
            int i = 0,
                l = 0,
                r = 0;
            
            while (true)
            {
                l = i * 2 + 1;
                r = i * 2 + 2;

                if (l >= sLength)
                {
                    break;
                }

                if (seats[l] < seats[i] ||
                    (r < sLength && seats[r] < seats[i]))
                {
                    if (r >= sLength ||
                        seats[l] <= seats[r])
                    {
                        seats[l] ^= seats[i];
                        seats[i] ^= seats[l];
                        seats[l] ^= seats[i];
                        i = l;
                    }
                    else
                    {
                        seats[r] ^= seats[i];
                        seats[i] ^= seats[r];
                        seats[r] ^= seats[i];
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

        int[] arrivals = new int[times.Length];
        int aLength = 0;
        void AddArrival(int index)
        {
            int i = aLength++,
                p = 0;
            arrivals[i] = index;
            while (i > 0)
            {
                p = (i - 1) >> 1;
                if (times[arrivals[p]][0] <= times[arrivals[i]][0])
                {
                    return;
                }

                arrivals[p] ^= arrivals[i];
                arrivals[i] ^= arrivals[p];
                arrivals[p] ^= arrivals[i];
                i = p;
            }
        }

        int PopArrival()
        {
            int rst = arrivals[0];
            arrivals[0] = arrivals[--aLength];
            int i = 0,
                l = 0,
                r = 0;
            
            while (true)
            {
                l = i * 2 + 1;
                r = i * 2 + 2;

                if (l >= aLength)
                {
                    break;
                }

                if (times[arrivals[l]][0] < times[arrivals[i]][0] ||
                    (r < aLength && times[arrivals[r]][0] < times[arrivals[i]][0]))
                {
                    if (r >= aLength ||
                        times[arrivals[l]][0] <= times[arrivals[r]][0])
                    {
                        arrivals[l] ^= arrivals[i];
                        arrivals[i] ^= arrivals[l];
                        arrivals[l] ^= arrivals[i];
                        i = l;
                    }
                    else
                    {
                        arrivals[r] ^= arrivals[i];
                        arrivals[i] ^= arrivals[r];
                        arrivals[r] ^= arrivals[i];
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

        int[] leaves = new int[times.Length];
        int lLength = 0;
        void AddLeave(int index)
        {
            int i = lLength++,
                p = 0;
            leaves[i] = index;
            while (i > 0)
            {
                p = (i - 1) >> 1;
                if (times[leaves[p]][1] <= times[leaves[i]][1])
                {
                    return;
                }

                leaves[p] ^= leaves[i];
                leaves[i] ^= leaves[p];
                leaves[p] ^= leaves[i];
                i = p;
            }
        }

        int PopLeave()
        {
            int rst = leaves[0];
            leaves[0] = leaves[--lLength];
            int i = 0,
                l = 0,
                r = 0;
            
            while (true)
            {
                l = i * 2 + 1;
                r = i * 2 + 2;

                if (l >= lLength)
                {
                    break;
                }

                if (times[leaves[l]][1] < times[leaves[i]][1] ||
                    (r < lLength && times[leaves[r]][1] < times[leaves[i]][1]))
                {
                    if (r >= lLength ||
                        times[leaves[l]][1] <= times[leaves[r]][1])
                    {
                        leaves[l] ^= leaves[i];
                        leaves[i] ^= leaves[l];
                        leaves[l] ^= leaves[i];
                        i = l;
                    }
                    else
                    {
                        leaves[r] ^= leaves[i];
                        leaves[i] ^= leaves[r];
                        leaves[r] ^= leaves[i];
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

        for (int i = 0; i < times.Length; i++)
        {
            AddSeat(i);
            AddArrival(i);
        }

        int a = 0,
            s = 0,
            l = 0;
        int[] occupies = new int[times.Length];
        while (aLength > 0)
        {

            a = PopArrival();
            while (lLength > 0 && times[a][0] >= times[leaves[0]][1])
            {
                l = PopLeave();
                AddSeat(occupies[l]);
            }

            s = PopSeat();
            if (a == targetFriend)
            {
                return s;
            }
            occupies[a] = s;

            AddLeave(a);
        }

        return 0;
    }
}
// @lc code=end


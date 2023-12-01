/*
 * @lc app=leetcode id=1845 lang=csharp
 *
 * [1845] Seat Reservation Manager
 */

// @lc code=start
public class SeatManager {

    public SeatManager(int n) {
        stack = new int[n];
        length = 0;
        curr = 1;
    }

    int[] stack;
    int length;
    int curr;
    
    public int Reserve() {
        if (length == 0)
        {
            return curr++;
        }

        int result = stack[0];
        stack[0] = stack[--length];
        int i = 0;
        while (true)
        {
            int l = i * 2 + 1,
                r = i * 2 + 2;

            if (l >= length)
            {
                break;
            }

            if (stack[l] < stack[i] ||
                (r < length && stack[r] < stack[i]))
            {
                if (r >= length || stack[l] <= stack[r])
                {
                    stack[i] ^= stack[l];
                    stack[l] ^= stack[i];
                    stack[i] ^= stack[l];
                    i = l;
                }
                else
                {
                    stack[i] ^= stack[r];
                    stack[r] ^= stack[i];
                    stack[i] ^= stack[r];
                    i = r;
                }
            }
            else
            {
                break;
            }
        }
        return result;
    }
    
    public void Unreserve(int seatNumber) {
        int i = length++;
        stack[i] = seatNumber;

        while (i > 0)
        {
            int p = (i - 1) >> 1;

            if (stack[p] < stack[i])
            {
                break;
            }

            stack[p] ^= stack[i];
            stack[i] ^= stack[p];
            stack[p] ^= stack[i];
            i = p;
        }
    }
}

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */
// @lc code=end


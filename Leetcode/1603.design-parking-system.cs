/*
 * @lc app=leetcode id=1603 lang=csharp
 *
 * [1603] Design Parking System
 */

// @lc code=start
public class ParkingSystem {

    public ParkingSystem(int big, int medium, int small) {
        slots = new int[] {
            0,
            big,
            medium,
            small,
        };
    }

    private int[] slots;

    public bool AddCar(int carType) {
        if (slots[carType] == 0)
        {
            return false;
        }
        else
        {
            slots[carType]--;
            return true;
        }
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
// @lc code=end


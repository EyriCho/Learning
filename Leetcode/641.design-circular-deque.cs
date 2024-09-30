/*
 * @lc app=leetcode id=641 lang=csharp
 *
 * [641] Design Circular Deque
 */

// @lc code=start
public class MyCircularDeque {

    int total;
    int count;
    internal class Node {
        internal int Value;
        internal Node Prev;
        internal Node Next;
    }

    Node head;
    Node tail;

    public MyCircularDeque(int k) {
        total = k;
        count = 0;
        head = null;
        tail = null;
    }
    
    public bool InsertFront(int value) {
        if (total == count)
        {
            return false;
        }

        if (head == null)
        {
            head = tail = new Node();
        }
        else
        {
            Node node = new ();
            node.Next = head;
            head.Prev = node;
            head = node;
        }
        head.Value = value;
        count++;
        return true;
    }
    
    public bool InsertLast(int value) {
        if (total == count)
        {
            return false;
        }

        if (tail == null)
        {
            head = tail = new Node();
        }
        else
        {
            Node node = new ();
            node.Prev = tail;
            tail.Next = node;
            tail = node;
        }
        tail.Value = value;
        count++;
        return true;
    }
    
    public bool DeleteFront() {
        if (count == 0)
        {
            return false;
        }

        if (count == 1)
        {
            head = tail = null;
        }
        else
        {
            head.Next.Prev = null;
            head = head.Next;;
        }

        count--;
        return true;
    }
    
    public bool DeleteLast() {
        if (count == 0)
        {
            return false;
        }

        if (count == 1)
        {
            head = tail = null;
        }
        else
        {
            tail.Prev.Next = null;
            tail = tail.Prev;
        }

        count--;
        return true;
    }
    
    public int GetFront() {
        if (count == 0)
        {
            return -1;
        }
        else
        {
            return head.Value;
        }
    }
    
    public int GetRear() {
        if (count == 0)
        {
            return -1;
        }
        else
        {
            return tail.Value;
        }
    }
    
    public bool IsEmpty() {
        return count == 0;
    }
    
    public bool IsFull() {
        return count == total;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */
// @lc code=end


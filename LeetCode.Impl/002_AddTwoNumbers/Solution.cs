namespace LeetCode.Impl.AddTwoNumbers;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode? AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return AddTwoNumbers(l1, l2, false);
    }

    ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2, bool parentOverflows)
    {
        if (l1 == null && l2 == null)
        {
            if (parentOverflows)
            {
                return new ListNode(1, null);
            }
            else
                return null;
        }
        var sum = l1 == null ? l2?.val ?? 0 :
                  l2 == null ? l1.val : l1.val + l2.val;
        if (parentOverflows) sum += 1;
        bool overflows = sum > 9;
        if (overflows) sum %= 10;
        return new ListNode(sum, AddTwoNumbers(l1?.next, l2?.next, overflows));
    }
}

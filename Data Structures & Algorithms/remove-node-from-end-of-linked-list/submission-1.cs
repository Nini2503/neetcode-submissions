/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int m=GetLength(head);
        if(n>m)
            throw new ArgumentException();
        int k=m-n;
        int i=0;
        ListNode prev=null;
        ListNode curr=head;
        while(curr!=null && i<k)
        {
            i++;
            prev=curr;
            curr=curr.next;
        }
        if(prev!=null && curr!=null)
            prev.next=curr.next;
        else if(prev==null && curr!=null)
            return curr.next;
        return head;
    }
    int GetLength(ListNode head)
    {
        ListNode p=head;
        int m=0;
        while(p!=null)
        {
            m++;
            p=p.next;
        }
        return m;
    }
}

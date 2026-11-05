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
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode currHead=head;
        ListNode prevGroupEnd=null;
        while(currHead!=null)
        {

            ListNode kth=GetKth(currHead,k);
            
            if(kth==null)
                break;

            ListNode nextHead=kth.next;
            ListNode tmp=Reverse(currHead,nextHead);

            if(currHead==head)
                head=tmp;
            else
                prevGroupEnd.next=tmp;

            currHead.next=nextHead;
            prevGroupEnd=currHead;
            currHead=nextHead;

        }
        return head;  
    }
    ListNode GetKth(ListNode node,int k)
    {
        while(node!=null && k>1)
        {
            node=node.next;
            k--;
        }
        return k == 1 ? node : null;
    }
    ListNode Reverse(ListNode node,ListNode nextHead)
    {
        ListNode prev=null;
        ListNode curr=node;
        while(curr!=nextHead)
        {
            ListNode next=curr.next;
            curr.next=prev;
            prev=curr;
            curr=next;
        }
        return prev;
    }

}

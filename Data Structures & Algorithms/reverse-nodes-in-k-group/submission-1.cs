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
         ListNode prevTail=null;
        while(currHead!=null)
        {
            ListNode kth=GetKth(currHead,k);
            if (kth == null)
                break;
            ListNode nextHead=kth.next;
            ListNode newHead=Reverse(currHead,nextHead);
           

            if(currHead==head)
                head=newHead;
            else
                prevTail.next=newHead;
                
            currHead.next=nextHead;
            prevTail=currHead;
            currHead=nextHead;
            
        }
        return head;
    }
    ListNode GetKth(ListNode node,int k)
    {
        while(node!=null && k>1)
        {
            k--;
            node=node.next;
        }
        return (k==1)? node:null;
    }
    ListNode Reverse(ListNode head, ListNode end)
    {
        ListNode prev=null;
        ListNode curr=head;
        while(curr!=end)
        {
            ListNode next=curr.next;
            curr.next=prev;
            prev=curr;
            curr=next;
        }
        return prev;
    }
}

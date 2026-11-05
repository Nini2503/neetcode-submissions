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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
      
      int carry=0;
      ListNode dummy=new ListNode();
      ListNode curr=dummy;
      while(l1!=null || l2!=null || carry!=0)
      {
        int sum=((l1!=null)?l1.val:0 )+((l2!=null)?l2.val:0)+carry;
       
        carry=sum/10;
        curr.next=new ListNode(sum%10);
        curr=curr.next;
        l1=(l1!=null)?l1.next:null;
        l2=(l2!=null)?l2.next:null;
        
      }
   
      return dummy.next;
    }
  
}

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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists==null||lists.Length==0)
            return null;
        ListNode node=null;
        int index=0;
        while(lists.Length>1)
        {
            List<ListNode> mergelist= new List<ListNode>();
            for(int i=0;i<lists.Length;i+=2)
            {
                ListNode l1=lists[i];
                ListNode l2 = (i+1<lists.Length)? lists[i+1]: null;
                mergelist.Add(MergeLists(l1,l2));
            }
            lists=mergelist.ToArray();
        }
        return lists[0];
    }
    public ListNode MergeLists(ListNode l1, ListNode l2) {
        if(l1==null)
            return l2;
        if(l2==null)
            return l1;
        ListNode node;
        if(l1.val<l2.val)
        { 
            node=l1;
            l1=l1.next;
            node.next=MergeLists(l1,l2);
        }
        else
        {
            node=l2;
            l2=l2.next;
            node.next=MergeLists(l2,l1);
        }
        return node;
    }
}
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        
        if(head == null)
            return null;

        Node old=head;
        while(old!=null)
        {
            Node newN=new Node(old.val);
            newN.next=old.random;
            old.random=newN;
            old=old.next;
        }
        Node newHead=head.random;

        //fixing random of new ones
        old=head;
        while(old!=null)
        {
            Node newN=old.random;
            newN.random=(newN.next!=null) ? newN.next.random : null;
            old=old.next;
        }

        //fixing old's random and linking news next
        old=head;
        while(old!=null)
        {
            Node newN=old.random;
            old.random=newN.next;
            newN.next=(old.next!=null) ? old.next.random : null;
            old=old.next;
        }

        return newHead;
    }
}

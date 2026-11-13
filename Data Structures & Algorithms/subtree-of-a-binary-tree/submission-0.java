/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {  
    public boolean isSubtree(TreeNode root, TreeNode subRoot) {
        if(root==null)
            return (subRoot==null);
        if(!isSame(root,subRoot))
            return isSubtree(root.left,subRoot)||isSubtree(root.right,subRoot);
        return true;
    }
    boolean isSame(TreeNode node1,TreeNode node2)
    {
        if(node1==null&& node2==null)
            return true;
        if(node1!=null && node2!=null && node1.val==node2.val)
            return isSame(node1.left,node2.left) && isSame(node1.right,node2.right);
        return false;
    }
}

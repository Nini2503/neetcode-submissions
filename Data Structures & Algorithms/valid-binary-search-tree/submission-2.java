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
    public boolean isValidBST(TreeNode root) {
        return isValidBSTUtil(root,null,null);
    }
    boolean isValidBSTUtil(TreeNode node, Integer low, Integer high)
    {
        if(node==null)
            return true;

        if((low!=null&& low>=node.val)||(high!=null&& high<=node.val))
            return false;

        return isValidBSTUtil(node.left,low,node.val)&&isValidBSTUtil(node.right,node.val,high);
    }
}

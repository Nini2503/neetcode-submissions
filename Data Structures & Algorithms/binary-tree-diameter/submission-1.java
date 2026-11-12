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
    int maxDiameter=0;
    public int diameterOfBinaryTree(TreeNode root) {
        getLongestPath(root);
        return maxDiameter;
    }
    int getLongestPath(TreeNode node)
    {
        if(node==null)
            return 0;
        int ld= getLongestPath(node.left);
        int rd=getLongestPath(node.right);
        maxDiameter=Math.max(maxDiameter,ld+rd);
        return 1+Math.max(ld,rd);
    }
}

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
    public List<List<Integer>> levelOrder(TreeNode root) {
        if(root==null)
            return new ArrayList<>();
        Queue<TreeNode> q=new LinkedList<TreeNode>();
        List<List<Integer>> res=new ArrayList<>();
        q.add(root);
        q.add(null);
        List<Integer> list=new ArrayList<>();
        while(!q.isEmpty())
        {
            TreeNode node=q.poll();
            if(node==null)
            {
                res.add(list);
                list=new ArrayList<>();
                if(!q.isEmpty())
                    q.add(null);
            }
            else
            {
                list.add(node.val);
                if(node.left!=null)
                    q.add(node.left);
                if(node.right!=null)
                    q.add(node.right);
            }
        }
        return res;
    }
}

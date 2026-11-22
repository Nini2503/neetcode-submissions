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
    public TreeNode buildTree(int[] preorder, int[] inorder) {
        if(preorder.length==0)
            return null;
        int rootVal=preorder[0];
        int rootIndex=findInInorder(inorder,rootVal);

        int leftTreeSize=rootIndex;
        int rightTreeSize=inorder.length-rootIndex-1;


        TreeNode root=new TreeNode(rootVal);

        int[] leftInorder=new int[leftTreeSize];
        int[] leftPreorder=new int[leftTreeSize];
        for(int i=0;i<leftTreeSize;i++)
        {
            leftInorder[i]=inorder[i];
            leftPreorder[i]=preorder[i+1];
        
        }
        int j=0;
        int[] rightInorder=new int[rightTreeSize];
        int[] rightPreorder=new int[rightTreeSize];
        for(int i=rootIndex+1;i<inorder.length;i++)
        {
            rightInorder[j]=inorder[i];
        
            rightPreorder[j]=preorder[leftTreeSize+1+j];
            j++;
        }
        
        root.left=buildTree(leftPreorder,leftInorder);
        root.right=buildTree(rightPreorder,rightInorder);

        return root;
    }
    int findInInorder(int[] inorder,int rootVal)
    {
        for(int i=0;i<inorder.length;i++)
        {
            if(inorder[i]==rootVal)
                return i;
        }
        return -1;
    }
}

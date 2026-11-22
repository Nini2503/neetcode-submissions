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

public class Codec {

    // Encodes a tree to a single string.
    public String serialize(TreeNode root) {
        return serialize(root,"");
        
    }

    String serialize(TreeNode root,String str)
    {
        if(root==null)
            str+="null,";
        else
        {
            str+=root.val+",";
            str=serialize(root.left,str);
            str=serialize(root.right,str);
        } 
        return str;
    }
    // Decodes your encoded data to tree.
    public TreeNode deserialize(String data) {
        String[] vals=data.split(",");
        return deserialize(new ArrayList<>(Arrays.asList(vals)));
    }
    TreeNode deserialize(List<String> vals)
    {
        if (vals.isEmpty()) 
        {
            return null;
        }
        String val=vals.get(0);
        if(val.equals("null"))
        {
            vals.remove(0);
            return null;
        }
        else
        {
            TreeNode node=new TreeNode(Integer.parseInt(val));
            vals.remove(0);
            node.left=deserialize(vals);
            node.right=deserialize(vals);
            return node;
        }
    }
}

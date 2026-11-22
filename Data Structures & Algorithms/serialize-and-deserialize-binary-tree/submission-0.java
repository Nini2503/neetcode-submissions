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
        return rSerialize(root,"");
    }
    String rSerialize(TreeNode node,String str)
    {
        if(node==null)
            str+="null,";
        else
        {
            str+=node.val+",";
            str=rSerialize(node.left,str);
            str=rSerialize(node.right,str);
        }
        return str;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(String data) {
       String[] nodes=data.split(",");
        List<String> nodes_list=new LinkedList<>(Arrays.asList(nodes));
        return rdeseralize(nodes_list);
    }
    TreeNode rdeseralize(List<String> nodes)
    {
        if(nodes.get(0).equals("null"))
        {
            nodes.remove(0);
            return null;
        }
        else
        {
            TreeNode node=new TreeNode(Integer.parseInt(nodes.get(0)));
            nodes.remove(0);
            node.left=rdeseralize(nodes);
            node.right=rdeseralize(nodes);
            return node;
        }
    }
}

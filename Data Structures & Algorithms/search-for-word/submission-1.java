class Solution {
    
    public boolean exist(char[][] board, String word) {
        for(int i=0;i<board.length;i++)
            for(int j=0;j<board[i].length;j++)
            {
                if(backtrack(board,i,j,word,0))
                    return true;
            }
        return false;
    }
    boolean backtrack(char[][] board,int i,int j,String word,int index)
    {
        if(index==word.length())
            return true;
        
        if(i<0||j<0||i>=board.length||j>=board[i].length||board[i][j]!=word.charAt(index))
            return false;
        
        
        board[i][j]='#';

        int[][] dir=new int[][]{{1,0},{0,1},{-1,0},{0,-1}};
        boolean found=false;
        for(int k=0;k<4;k++)
        {
           found=found|| backtrack(board,i+dir[k][0],j+dir[k][1],word,index+1);
        }
        board[i][j]=word.charAt(index);
        return found;


    }
}

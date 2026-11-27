class Solution {
    public List<List<String>> solveNQueens(int n) {
    char[][] board=new char[n][n];
    for(int i=0;i<n;i++)
        for(int j=0;j<n;j++)
            board[i][j]='.';

    List<List<String>> res=new ArrayList<List<String>>();
    backtrack(0,new HashSet<Integer>(),new HashSet<Integer>(),new HashSet<Integer>(),res,board);
    return res;
    }
    void backtrack(int row,Set<Integer> cols,Set<Integer> diagonals,Set<Integer> antidiagonals,List<List<String>> res,char[][] board)
    {
        if(row==board.length)
        {
            res.add(addBoard(board));
            return;
        }
        for(int col=0;col<board.length;col++)
        {
            int diagonal=row-col;
            int antidiagonal=row+col;
            if(cols.contains(col)||diagonals.contains(diagonal)||antidiagonals.contains(antidiagonal))
                continue;
            board[row][col]='Q';
            diagonals.add(diagonal);
            cols.add(col);
            antidiagonals.add(antidiagonal);
            backtrack(row+1,cols,diagonals,antidiagonals,res,board);
            board[row][col]='.';
            diagonals.remove(diagonal);
            cols.remove(col);
            antidiagonals.remove(antidiagonal);
        }
    }
    List<String> addBoard(char[][] board)
    {
        List<String> res=new ArrayList<String>();
        for(int i=0;i<board.length;i++)
        {
            res.add(new String(board[i]));
        }
        return res;
    }
}

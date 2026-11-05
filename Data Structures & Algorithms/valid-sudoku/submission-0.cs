public class Solution {
    public bool IsValidSudoku(char[][] board) {
      var row=new HashSet<char>[9];  
      var col=new HashSet<char>[9];  
      var box=new HashSet<char>[9]; 
      for(int i=0;i<9;i++)
        {
            row[i]=new HashSet<char>();
            col[i]=new HashSet<char>();
            box[i]=new HashSet<char>();
        } 
      for(int i=0;i<9;i++)
      {
        for(int j=0;j<9;j++)
        {
            char val=board[i][j];
            if(val=='.')
                continue;
            if(row[i].Contains(val))
                return false;
            else
                row[i].Add(val);
            if(col[j].Contains(val))
                return false;
            else
                col[j].Add(val);
            
            int index=(i/3)*3+(j/3);

            if(box[index].Contains(val))
                return false;
            else
                box[index].Add(val);
        }
      }
      return true;
    }
}

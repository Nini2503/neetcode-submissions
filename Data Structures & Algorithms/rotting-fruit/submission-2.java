class Solution {
    public int orangesRotting(int[][] grid) {
        int m=grid.length;
        int n=grid[0].length;
        Queue<int[]> q=new LinkedList<>();
        int count=0;
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]==2)
                    q.add(new int[]{i,j});
                else if(grid[i][j]==1)
                count++;
            }
        }
        int min=bfs(q,grid,count);
       
        return min;
    }
    int bfs(Queue<int[]> q,int[][] grid,int count)
    {
        int[][] DIR=new int[][]{{0,1},{1,0},{-1,0},{0,-1}};
        int min=-1;
        while(!q.isEmpty())
        {
            min++;
            int size=q.size();
            for(int t=0;t<size;t++)
            {
                int[] val=q.remove();
                for(int k=0;k<4;k++)
                {
                    int X=val[0]+DIR[k][0];
                    int Y=val[1]+DIR[k][1];
                    if(X>=0 && Y>=0 && X<grid.length && Y<grid[X].length && grid[X][Y]==1)
                    {
                        grid[X][Y]=2;
                        count--;
                        q.add(new int[]{X,Y});
                    }
                }
            }

        }
        return (count==0)? ((min>0)?min:0) :-1;
    }
}

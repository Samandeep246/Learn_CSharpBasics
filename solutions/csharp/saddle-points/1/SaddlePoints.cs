public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
       var result =new List<(int,int)>();
        for (int r=0; r<matrix.GetLength(0); r++)
        {
            for (int c=0; c<matrix.GetLength(1);c++)
            {
                int value=matrix[r,c];
                int rowMax=Enumerable.Range(0,matrix.GetLength(1))
                    .Max(col=>matrix[r,col]);
                int colMin= Enumerable.Range(0,matrix.GetLength(0))
                    .Min(row=>matrix[row,c]);
                if(value==rowMax && value==colMin)
                    result.Add((r+1,c+1));
            }
        }
        return result;
    }
}

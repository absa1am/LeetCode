public class RotateImageSolution
{
    public void Rotate(int[][] matrix)
    {
        int[][] mat = new int[matrix.Length][];

        for(int i = 0; i < matrix.Length; i++)
            mat[i] = new int[matrix.Length];
        
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = matrix.Length - 1; j >= 0; j--)
            {
                mat[i][matrix.Length - j - 1] = matrix[j][i];
            }
        }

        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix.Length; j++)
                matrix[i][j] = mat[i][j];
        }
    }
}
public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
            int[,] mat = new int[size, size];
            int counter = 1;

            int left = 0;
            int right = mat.GetLength(1) - 1;
            int top = 0;
            int bottom = mat.GetLength(0) - 1;

            while (left <= right && top <= bottom)
            {
                for (int i = left; i <= right; i++)
                {
                    mat[top, i] = counter++;
                }

                top++;

                if (top > bottom)
                    break;

                for (int i = top; i <= bottom; i++)
                {
                    mat[i, right] = counter++;
                }

                right--;

                if (left > right)
                    break;

                for (int i = right; i >= left; i--)
                {
                    mat[bottom, i] = counter++;
                }

                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    mat[i, left] = counter++;
                }

                left++;
            }

            return mat;
    }
}

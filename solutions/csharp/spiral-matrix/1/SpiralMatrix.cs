public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];

        int num = 1;
        int top = 0; int bottom = size - 1;
        int left = 0; int right = size - 1;

        while (top <= bottom && left <= right)
        {
            //left to right
            for (int i = left; i <= right; i++)
                matrix[top, i] = num++;
            top++;

            //top to bottom
            for (int i = top; i <= bottom; i++)
                matrix[i, right] = num++;
            right--;

            //right to left
            for (int i = right; i >= left; i--)
                matrix[bottom, i] = num++;
            bottom--;

            //bottom to top
            for (int i = bottom; i >= top; i--)
                matrix[i, left] = num++;
            left++;
        }

        return matrix;
    }
}

int[,] matrix = {
    {1, 2, 3, 4, 5},
    {2, 3, 4, 5, 6},
    {3, 4, 5, 6, 7}
};

int sum = 0;

for (int i = 0; i < matrix.GetLength(0)-1; i++) {
    for (int j = 0; j < matrix.GetLength(1)-1; j++) {
        int miniSum = matrix[i,j] + matrix[i,j+1] + matrix[i+1,j] + matrix[i+1,j+1];
        Console.WriteLine(miniSum);
        if (miniSum > sum) {
            sum = miniSum;
        }
    }
}
Console.WriteLine(sum);

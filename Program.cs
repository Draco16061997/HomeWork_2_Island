int a = 20;

int[,] arr = new int[a,a];


Random random = new Random();

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        arr[i, j] = random.Next(0, 2);

    }
}



for (int i = 0; i < a; i++)
{
    for(int j = 0;j < a; j++)
    {
        Console.Write(arr[i, j]);
    }
    Console.WriteLine();
}



static void Island(int[,] arr, int row, int col)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);

    if (row < 0 || row >= rows || col < 0 ||col>=cols || arr[row,col] ==0)
    {
        return;
    }
    arr[row,col] = 0;   

    Island(arr, row - 1, col);
    Island(arr, row + 1, col);
    Island(arr,row,col - 1);
    Island(arr,row,col+1);
}


static int CountIslands(int[,] arr)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    int islandCount = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (arr[i, j] == 1)
            {
                islandCount++;
                Island(arr, i, j);
            }
        }
    }

    return islandCount;
}


int IslandCount = CountIslands(arr);

Console.WriteLine(IslandCount);
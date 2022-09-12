// Multidimension array
//Decalre a 2D array with 2 rows and 4 columns

int[,] lop = new int[2, 5]
{
    { 12, 43, 54, 23, 4},
    { 13, 22, 3234, 123, 98 }
};

// Access and display each value of 2D array from left to right, from on down under

for (int row = 0; row < lop.GetLength(0); row++)
{
    for (int col = 0; col < lop.GetLength(1); col++)
    {
        Console.Write(lop[row, col]);
    }
    Console.WriteLine();
}
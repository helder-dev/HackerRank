namespace The_Bomberman_Game;

class Program
{
    private static char[][] PlantAllBombs(char[][] grid) {
        for (int i = 0; i < grid.Length; i++) {
            grid[i] = new string('O', grid[0].Length).ToCharArray();    
        }

        return grid;
    }

    private static char[][] DetonateBombs(int rows, int cols, char[][] grid) {
        char[][] gridWithDetonatedBombs = PlantAllBombs((char[][])grid.Clone());

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 'O') {
                    gridWithDetonatedBombs[i][j] = '.';

                    if (i-1 >= 0) gridWithDetonatedBombs[i - 1][j] = '.';
                    if (i+1 < rows) gridWithDetonatedBombs[i + 1][j] = '.';
                    if (j-1 >= 0) gridWithDetonatedBombs[i][j - 1] = '.';
                    if (j+1 < cols) gridWithDetonatedBombs[i][j + 1] = '.';
                }
            }
        }

        return gridWithDetonatedBombs;
    }

    private static char[][] BomberMan(int r, int c, int n, char[][] grid) {
        if (n == 1) {
            return grid;
        }

        if ((n % 2) == 0) {
            return PlantAllBombs(grid);
        } else if (n == 3) {
            return DetonateBombs(r, c, grid);    
        } else {
            char[][] gridAtFirstDetonation = DetonateBombs(r, c, grid);
            char[][] gridAtSecondDetonation = DetonateBombs(r, c, gridAtFirstDetonation);
            char[][] gridAtThirdDetonation = DetonateBombs(r, c, gridAtSecondDetonation);

            return n % 4 == 1 ? gridAtSecondDetonation : gridAtThirdDetonation;
        }
    }

    static void Main(string[] args) {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int r = Convert.ToInt32(firstMultipleInput[0]);
        int c = Convert.ToInt32(firstMultipleInput[1]);
        int n = Convert.ToInt32(firstMultipleInput[2]);

        char[][] grid = new char[r][];

        for (int i = 0; i < r; i++)
        {
            grid[i] = Console.ReadLine().ToCharArray();
        }

        char[][] result = BomberMan(r, c, n, grid);

        Console.WriteLine(String.Join("\n", result.Select(row => new string(row))));
    }
}

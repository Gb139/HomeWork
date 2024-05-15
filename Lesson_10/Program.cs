namespace Lesson_10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,,] threeArr =
            { 
                {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
                }
            };
            
            for (int i = 0; i < threeArr.GetLength(0); i++)
            {
                for (int j = 0; j < threeArr.GetLength(1); j++)
                {
                    for (int k = 0; k < threeArr.GetLength(2); k++)
                    {
                        System.Console.WriteLine(threeArr[i, j, k]);
                    }
                }
            }
        }
    }
}
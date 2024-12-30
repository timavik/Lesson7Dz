namespace Lesson7DzTwo
{
  internal class Program
  {
    static void Main(string[] args)
    {

      int[,] matrix = {
            { 5, 8, 3 },
            { 10, 2, 7 },
            { 4, 6, 9 }
        };


      Console.WriteLine("Максимальные элементы каждого ряда:");
      for (int i = 0; i < 3; i++)
      {
        int maxElement = matrix[i, 0]; 
        for (int j = 1; j < 3; j++)
        {
          if (matrix[i, j] > maxElement)
          {
            maxElement = matrix[i, j];
          }
        }
        Console.WriteLine($"Ряд {i + 1}: {maxElement}");
      }
    }
  }
}

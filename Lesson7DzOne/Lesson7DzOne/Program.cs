namespace Lesson7DzOne
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = new int[6];

      Console.WriteLine("Введите 6 целых чисел:");
      for (int i = 0; i < numbers.Length; i++)
      {
        numbers[i] = int.Parse(Console.ReadLine());
      }

      Array.Sort(numbers);
      Array.Reverse(numbers);

      Console.WriteLine("Отсортированные по убыванию элементы массива:");
      foreach (int num in numbers)
      {
        Console.WriteLine(num);
      }
    }
  }
}

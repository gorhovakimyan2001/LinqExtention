namespace LinqExtention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 4, 45, 3, 21, 34, -2, 6 };
            List<int> list2 = new List<int>() { 7, 455, 3, -41, 24, 5, -2 };


            Console.WriteLine(list2.Single(x => x == 100));

            Console.WriteLine(list1.All(x => x > -10));
            Console.WriteLine(list1.Any(x => x < -10));

            Console.WriteLine();
            foreach (int x in list1.Except(list2))
            {
                Console.WriteLine(x);
            }
        }
    }
}
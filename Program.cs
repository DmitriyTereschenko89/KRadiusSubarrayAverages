namespace KRadiusSubarrayAverages
{
	internal class Program
	{
		static void Main(string[] args)
		{
			KRadiusSubarrayAverages averages = new();
            Console.WriteLine(string.Join(", ", averages.GetAverages(new int[] { 7, 4, 3, 9, 1, 8, 5, 2, 6 }, 3)));
			Console.WriteLine(string.Join(", ", averages.GetAverages(new int[] { 100000 }, 0)));
            Console.WriteLine(string.Join(", ", averages.GetAverages(new int[] { 8 }, 100000)));
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMax
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] myArray = { 6, 8, 22, 3, 9, 15 };
			Console.WriteLine();
			Console.WriteLine("Skirtumas tarp didziausio ir maziausio masyvo elemeto {0}", FindDifferece(myArray));
			Console.WriteLine();
		}
		/// <summary>
		/// Metodas, kuris suranda maziausia masyvo elementa (method that finds smallest number of int array)
		/// </summary>
		/// <param name="arr">array/masyvas</param>
		/// <returns></returns>
		static int FindMin(int[] arr)
		{
			int min = 10000000;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
				}
			}
			return min;
		}
		/// <summary>
		/// metodas, kuris suranda didziausia masyvo elementa (method that finds largest number of int array )
		/// </summary>
		/// <param name="arr">array/masyvas</param>
		/// <returns></returns>
		static int FindMax(int[] arr)
		{
			int max = -100000;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
			}
			return max;
		}
		/// <summary>
		/// Metodas, kuris suskaiciuoja skirtuma tarp maziausio ir didziausio masyvo elemento.
		/// Method that calculates difference between biggest and smalles number of array
		/// </summary>
		/// <param name="arr">masyvas/array</param>
		/// <returns></returns>
		static int FindDifferece(int[] arr)
		{
			return FindMax(arr) - FindMin(arr);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//Create a function that takes two numbers as arguments and returns their sum.
//sukurti funkcija/metoda, kuri paima du skaicius argumentais ir
//grazina tu skaiciu suma

namespace Tasks
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 5;
			int b = 5;
			int c = Sum(a, b);
			Console.WriteLine("Dvieju skaiciu {0} ir {1} lygi {2}", a, b, c);
			int minutes = 6;
			int seconds = ConvertMinutesToSeconds(minutes);
			Console.WriteLine("{0} minutes turi {1} sekundes", minutes, seconds);
			int numTo_increment = 9;
			int incremented_number = IncrementNumber(numTo_increment);
			Console.WriteLine("{0} padidinus vienetu yra {1}", numTo_increment, incremented_number);
			double bs_og_triangle = 6;
			double triangleHeight = 9;
			double triangleArea = CalcArea(bs_og_triangle, triangleHeight);
			Console.WriteLine("Trikampio plotas, kai jo aukstis {0} " +
				"ir pagrindas {1} gaunasi {2}", triangleHeight,bs_og_triangle, triangleArea);
			int ageYears = 45;
			int ageDays = ConvertAge(ageYears);
			Console.WriteLine("Amzius metais {0} ir amzius dienoms {1}", ageYears, ageDays);
			int[] array = { 2, 6, 9, 88, 14 };
			int firstElement = GetFirst(array);
			Console.WriteLine("Pirmas masyvo elementas yra {0}", firstElement);
			int first = 105;
			int second = 5;
			int remainder = GetRemaider(first, second);
			Console.WriteLine("Liekana {0}", remainder);
			int numTo_check = 5;
			bool lessOrEqualToZero = LessThanZero(numTo_check);
			Console.WriteLine("Ar {0} maziau arba lygu nuliui? ---> {1}", numTo_check, lessOrEqualToZero);
			bool lessThan100 = IsSumLessThan100(a,first);
			Console.WriteLine("Ar skaiciu {0} ir {1} suma mazesne uz 100? ---> " +
				"{2}", a, first, lessThan100);
			bool theSame = IsEquals(numTo_check,second);
			Console.WriteLine("Ar {0} = {1} --> {2}", numTo_check, second, theSame);
			string myStr = "delicious";
			string combined = Something(myStr);
			Console.WriteLine(combined);
			Console.Write("pradine reiksme {0}", theSame);
			Console.Write(", apversta reiksme {0}", Reverse(theSame));

			int[] myArray = { 6, 8, 22, 3, 9, 15 };
			Console.WriteLine();
			Console.WriteLine("Didziausias masyvo elementas yra {0}, maziausias masyvo elementas yra {1} ", myArray.Max(),
				myArray.Min());
			Console.WriteLine("Skirtumas tarp diziausio ir maziausio masyvo elemento yra {0}", Difference(myArray));
			Console.WriteLine();
			Console.WriteLine("Skirtumas tarp didziausio ir maziausio masyvo elemeto {0}", FindDifferece(myArray));
			Console.WriteLine();
			Console.WriteLine("Orginalus masyvas: ");
			foreach (int number in myArray)
			{
				Console.Write(number + " ");
			}
			Console.WriteLine();
			Console.WriteLine("Apverstas masyvas: ");
			ReverseArray(myArray);
			foreach (var number in myArray)
			{
				Console.Write(number + " ");
			}
			Console.WriteLine();
			string labas = "Labas";
			int times = 4;
			string repeated = Repeat(labas, times);
			Console.WriteLine($"Orginalus zodis {labas}, kurio kiekviena raide yra kartojama" +
				$" {times} kartu, o jos rezultatas gaunasi {repeated}");
			string jsIsCool = HackerSpeak("javascript is cool");
			Console.WriteLine(jsIsCool);
			string programmingIsFun = HackerSpeak("programming is fun");
			Console.WriteLine(programmingIsFun);
			string becomeCoder = HackerSpeak("become a coder");
			Console.WriteLine(becomeCoder);
			int[,] multi = { { 4, 2, 7, 1 }, { 20, 70, 40, 90 }, { 1, 2, 0, 1} };
			int[,] multi2 = { { -34, -54, -74 }, { -32, -2, -65 }, { -54, 7, -43 } };
			double[,] multi3 = { { 0.4321, 0.7634, 0.652 }, { 1.324, 9.32, 2.5423 }, { 9, 3, 6 } };
			var max1 = FindLargest(multi);
			var max2 = FindLargest(multi2);
			var max3 = FindLargest(multi3);
			Console.WriteLine("Didziausi elementai masyvuose:");
			foreach (var item in max1)
			{
				Console.WriteLine(item + " ");
			}
			foreach (var item in max2)
			{
				Console.WriteLine(item + " ");
			}
			foreach (var item in max3)
			{
				Console.WriteLine(item + " ");
			}
			Console.ReadKey();
		}
		//Create a function that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.
		//Watch out for negative numbers.
		public static int[] FindLargest(int[,] arr1)
		{
			int[] largestOfEeach = new int[3];
			int max = -10000;
			int big = 0;
			for (int i = 0; i < arr1.GetLength(0); i++)
			{
				for (int j = 0; j < arr1.GetLength(1); j++)
				{
					if (arr1[i, j] > max)
					{
						max = arr1[i, j];
					}
					
				}

				largestOfEeach[big] = max;
				big++;
				max = -10000;
			}
			return largestOfEeach;
		}
		public static double[] FindLargest(double[,] arr1)
		{
			double[] largestOfEeach = new double[3];
			double max = -10000;
			int big = 0;
			for (int i = 0; i < arr1.GetLength(0); i++)
			{
				for (int j = 0; j < arr1.GetLength(1); j++)
				{
					if (arr1[i, j] > max)
					{
						max = arr1[i, j];
					}
					
				}
				largestOfEeach[i] = max;
				max = -10000;
				big++;
			}
			return largestOfEeach;
		}

		//Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.
		//In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.
		//HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"
		//HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"
		//HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
		//Create a function that repeats each character in a string n times.
		public static string HackerSpeak(string myString)
		{
			string newStr = "";
			for (int i = 0; i < myString.Length; i++)
			{
				if (myString[i] == 'a')
				{
					newStr += '4';
				}
				else if (myString[i] == 'e')
				{
					newStr += '3';
				}
				else if (myString[i] == 'i')
				{
					newStr += '1';
				}
				else if (myString[i] == 'o')
				{
					newStr += '0';
				}
				else if (myString[i] == 's')
				{
					newStr += '5';
				}
				else
				{
					newStr += myString[i];
				}
			}
			return newStr;
		}
		public static string Repeat(string word, int times)
		{
			string newWord = "";
			int j = 0;
			for (int i = 0; i < word.Length; i++)
			{
				while(j != times)
				{
					newWord += word[i];
					j++;
				}
				j = 0;
			}
			return newWord;
		}
		//Write a function to reverse an array.
		public static void ReverseArray(int[] arr)
		{
			int[] newArray = new int[arr.Length];
			int j = 0;
			for (int i = arr.Length-1; i >= 0; i--)
			{
				newArray[j] = arr[i];
				j++;
			}
			j = 0;
			for (int i = 0; i < newArray.Length; i++)
			{
				arr[j] = newArray[i];
				j++;
			}
		}
		//Create a function that reverses a boolean value.
		public static bool Reverse(bool a)
		{
			return !a;
		}
			
		//Write a function that
		//returns the string "something" joined with a space " " and some kind of other value
		/// <summary>
		/// method that combines "something " with the argument string
		/// </summary>
		/// <param name="mystring"></param>
		/// <returns>something + argument string</returns>
		public static string Something(string mystring)
		{
			return "Something " + mystring;
		}
		//sukurti funkcija/metoda, kuri paima du skaicius argumentais ir
		//grazina tu skaiciu suma
		/// <summary>
		/// method that calculates the sum of two whole numbers
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>sum of 2 numbers</returns>
		public static int Sum(int a, int b)
		{
			return a + b;
		}
		//Write a method that takes an integer minutes and converts it
		//to seconds.
		/// <summary>
		/// method that converts minutes to seconds
		/// </summary>
		/// <param name="minutes">amount of minutes (whole number)</param>
		/// <returns>seconds</returns>
		public static int ConvertMinutesToSeconds(int minutes)
		{
			return minutes * 60;
		}
		//Create a method that takes a number as an
		//argument, increments the number by +1 and
		//returns the result.
		/// <summary>
		/// method that increments a passed number by one
		/// </summary>
		/// <param name="number"></param>
		/// <returns>incremented number</returns>
		public static int IncrementNumber(int number)
		{
			number++;
			return number;
		}
		//Write a function that takes the base and height
		//of a triangle and return its area.
		//The area of a triangle is: (base * height) / 2
		/// <summary>
		/// method that calculates an area of the triangle
		/// </summary>
		/// <param name="bas">base</param>
		/// <param name="height">height</param>
		/// <returns>area of triangle</returns>
		public static double CalcArea(double bas, double height)
		{
			return bas * height / 2;
		}
		//Create a method that takes the age in years
		//and returns the age in days.
		//Use 365 days as the length of a year for this challenge.
		//Ignore leap years and days between last birthday and now.
		//Expect only positive integer inputs.
		/// <summary>
		/// method that converts years to days (default amount of days is
		/// 365)
		/// </summary>
		/// <param name="age_in_years"></param>
		/// <returns>age in days</returns>
		public static int ConvertAge(int age_in_years)
		{
			if (age_in_years > -1)
			{
				return age_in_years * 365;
			}
			return -1;
		}
		//Create a method that takes an array
		//containing only numbers and return the first element.
		/// <summary>
		/// method that gets first element of array
		/// </summary>
		/// <param name="array"></param>
		/// <returns>first element of array</returns>
		public static int GetFirst(int[] array)
		{
			//you can use also 
			//array.First();
			return array[0];
		}
		//There is a single operator in C#,
		//capable of providing the remainder
		//of a division operation. Two numbers
		//are passed as parameters. The first parameter
		//divided by the second parameter will have a remainder,
		//possibly zero. Return that value.
		/// <summary>
		/// method that get remainder f two numbers division
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>Remainder</returns>
		public static int GetRemaider(int a, int b)
		{
			return a % b;
		}
		//Create a function that takes a number as its only
		//argument and returns true if it's less than
		//or equal to zero, otherwise return false.
		/// <summary>
		/// method that checks if the number is less or equal zero
		/// </summary>
		/// <param name="num"></param>
		/// <returns>true if less and false if more</returns>
		public static bool LessThanZero(int num)
		{
			return num <= 0;
		}
		//Given two numbers, return true if the sum of both
		//numbers is less than 100. Otherwise return false.
		/// <summary>
		/// Calculates the sum of two numbers and checks if the sum is less than 100
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>return true if the sum of both
		//numbers is less than 100.</returns>
		public static bool IsSumLessThan100(int a, int b)
		{
			if (a + b < 100)
			{
				return true;
			}
			return false;
		}
		//Create a function that takes two
		//integers and checks if they are equal.
		/// <summary>
		/// takes two
		//integers and checks if they are equal.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>true or false</returns>
		public static bool IsEquals(int a, int b)
		{
			return a == b;
		}
		//Given an array of integers, return the difference
		//between the largest and smallest integers in the array.
		static int Difference(int[] array)
		{
			return array.Max() - array.Min();
		}
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
		static int FindMin(int[] arr)
		{
			int min = 10000000; 
			for(int i = 0; i < arr.Length;i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
				}
			}
			return min;
		}
		static int FindDifferece(int[] arr)
		{
			return FindMax(arr) - FindMin(arr);
		}
	}
}

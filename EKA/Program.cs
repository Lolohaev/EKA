using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKA
{
	class Program
	{
		const int M = 4;
		static Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
		static int[] numbers = { 0, 1, 2, 3, 4, 5 };

		static void Main(string[] args)
		{
			keyValuePairs[0] = "no";
			CheckArrayForZeroValue(numbers, M);
			Console.Write(keyValuePairs[0]);
			Console.ReadKey();
		}

		static void CheckArrayForZeroValue(int[] arr, int n)
		{
			for (int i = 0; i < n; i++)
			{
				keyValuePairs[arr[i]] = "yes";
			}
		}
	}
}

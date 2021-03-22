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
		static int[] numbers = { 10, 1, 2, 3, 4, 5 };
		static Action<int[], int>[] delegateHelper = new Action<int[], int>[] { CheckArrayForZeroValue, DoNothing };

		static void Main(string[] args)
		{
			keyValuePairs[0] = "No";
			int n = 0;
			CheckArrayForZeroValue(numbers, n);
			Console.Write(keyValuePairs[0]);
			Console.ReadKey();
		}

		static void DoNothing(int[] arr, int n)
		{

		}

		static void CheckArrayForZeroValue(int[] arr, int n)
		{
			keyValuePairs[arr[n++]] = "Yes";

			delegateHelper[n/M](arr, n);
		}
	}
}

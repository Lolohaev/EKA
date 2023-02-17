using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKA
{
	public static class Evaluation
	{
		static Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
		static Action<int[], int, int>[] delegateHelper = new Action<int[], int, int>[] { CheckArrayForZeroValue, DoNothing };

		public static string CheckForZero(int[] arr, int M)
		{
			int n = 0;
			keyValuePairs[0] = "No";
			CheckArrayForZeroValue(arr, n, M);
			return keyValuePairs[0];
		}

		static void DoNothing(int[] arr, int n, int M)
		{
		}

		static void CheckArrayForZeroValue(int[] arr, int n, int M)
		{
			//Если в какой-то момент мы получим значение массива == 0, то поменяем значение в словаре на "Yes"
			keyValuePairs[arr[n++]] = "Yes";

			// По условию M <= длина массива, пока мы идем от 0 до M у нас будет вызываться delegateHelper[0]
			// и рекурсивно будем вызывать CheckArrayForZeroValue, как только мы дойдем до значения 
			// n == M мы перейдем к коду delegateHelper[1], который ничего не делает и выполнения дальше не будет.
			delegateHelper[n / M](arr, n, M);
		}
	}
}

using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace EKA.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var values = GenerateRandomValues();

			string evResult = Evaluation.CheckForZero(values.Item1, values.Item2);
			string clResult = CheckForZeroCycle(values.Item1, values.Item2);

			Assert.Equal(evResult, clResult);
		}
		[Fact]
		public void Test2()
		{
			var values = GenerateRandomValues();
			values.Item1[values.Item2 - 1] = 0;

			string evResult = Evaluation.CheckForZero(values.Item1, values.Item2);

			Assert.Equal(evResult, "Yes");
		}

		static (int[], int) GenerateRandomValues()
		{
			var random = new Random();
			var arrLength = random.Next(1, 100);
			int M = random.Next(1, arrLength);
			var arr = new int[arrLength];
			for (int i = 0; i < arrLength; i++)
			{
				arr[i] = random.Next(-100, 100);
			}

			return (arr, M);
		}

		//—тандартна€ проверка старым добрым перебором
		static string CheckForZeroCycle(int[] arr, int m)
		{
			for (int i = 0; i < m; i++)
			{
				if(arr[i] == 0)
					return "Yes";
			}

			return "No";
		}
	}
}
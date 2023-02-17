using System;
using System.Collections.Generic;

namespace EKA
{
	class Program
	{
		const int M = 8;
		static int[] numbers = { 10, 1, 2, 11, 3, 4, 11, 5 }; //по условию нам не надо дополнять программу вводом, нужен лишь сам код. 

		static void Main(string[] args)
		{
			Console.WriteLine(Evaluation.CheckForZero(numbers, M));
			Console.ReadKey();
		}
	}
}

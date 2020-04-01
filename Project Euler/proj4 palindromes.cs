//using System;

//namespace Project_Euler
//{
//	static class StringHelper
//	{
//		public static string ReverseString(string myStr)
//		{
//			char[] myArr = myStr.ToCharArray();
//			Array.Reverse(myArr);
//			return new string(myArr);
//		}
//	}
//	class Project4
//	{
//		static void Main(string[] args)
//		{
//			int currentNumber1 = 31;
//			int currentNumber2 = 51;
//			int highestNumber = 999;
//			int initAnswer;
//			int currentHighest = 0;
//			int testHighest;

//			while (currentNumber2 <= highestNumber)
//			{
//				initAnswer = currentNumber1 * currentNumber2;
//				string initAnswerTest = initAnswer.ToString();
//				if (initAnswerTest == StringHelper.ReverseString(initAnswer.ToString()))
//				{
//					testHighest = initAnswer;
//					if (testHighest > currentHighest)
//					{
//						currentHighest = testHighest;
//					}
//				}
//				if (currentNumber1 == highestNumber)
//				{
//					currentNumber1 = 0;
//					currentNumber2 += 1;
//				}
//				currentNumber1 += 1;
//			}
//			Console.WriteLine(currentHighest);
//		}
//	}
//}
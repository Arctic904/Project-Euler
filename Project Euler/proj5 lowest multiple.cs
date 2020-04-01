//using System;

//namespace Project_Euler
//{
//	class Proj5
//	{
//		static void Main(string[] args)
//		{
//			int limit = 20;
//			int testNumber;
//			int currentNumber = 21;
//			bool isTrue = false;
//			while (isTrue != true)
//			{
//				currentNumber += 1;
//				testNumber = 1;
//				while (testNumber <= limit)
//				{
//					if (currentNumber % testNumber != 0)
//					{
//						break;
//					}
//					else testNumber += 1;
//					if (testNumber == limit)
//					{
//						isTrue = true;
//					}
//				}
//			}
//			Console.WriteLine(currentNumber);
//			Console.ReadLine();
//		}
//	}
//}
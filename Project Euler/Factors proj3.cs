//using System;

//namespace Project_Euler
//{
//	class Factors
//	{
//		static void Main(string[] args)
//		{
//			long currentNumber = 1;
//			long finalNumber = 600851475143;
//			bool isDivisible = false;
//			long primeTestNumber = 2;
//			long currentLargest = 0;
//			long newLargest = 0;

//			while (currentNumber <= finalNumber)
//			{
//				if (finalNumber % currentNumber == 0)
//				{
//					isDivisible = true;
//				}
//				else isDivisible = false;
//				if (isDivisible == true)
//				{
//					while (primeTestNumber < currentNumber)
//					{
//						if (currentNumber % primeTestNumber == 0)
//						{
//							break;
//						}
//						primeTestNumber += 1;
//					}
//					if (primeTestNumber == currentNumber)
//					{
//						newLargest = currentNumber;
//					}
//					if (newLargest > currentLargest)
//					{
//						currentLargest = newLargest;
//						Console.WriteLine(currentNumber);

//					}
//					primeTestNumber = 2;
//				}
//				currentNumber += 1;
//				//Console.WriteLine(currentNumber);
//			}
//			Console.WriteLine(currentLargest);
//			Console.ReadLine();
//		}
//	}
//}
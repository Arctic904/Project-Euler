//using System;

//namespace Project_Euler
//{
//    class Multiples
//    {
//        static void Main(string[] args)
//        {
//            int limit = 1000;
//            int total = 0;
//            int multiple1 = 3;
//            int multiple2 = 5;
//            int currentNumber = 0;
//            bool isMultiple = false;
//            while (currentNumber != limit)
//            {
//                if (currentNumber % multiple1 == 0)
//                {
//                    isMultiple = true;
//                }
//                if (currentNumber % multiple2 == 0)
//                {
//                    isMultiple = true;
//                }
//                if (isMultiple == true)
//                {
//                    total += currentNumber;
//                }
//                currentNumber += 1;
//                isMultiple = false;
//            }
//            Console.WriteLine(total);
//            Console.ReadLine();
//        }
//    }
//}
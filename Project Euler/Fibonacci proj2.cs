//using System;

//namespace Project_Euler
//{
//    class Project2
//    {
//        static void Main(string[] args)
//        {
//            int term1 = 1;
//            int term2 = 2;
//            int term3 = 0;
//            int total = 3;
//            int limit = 4000000;

//            while (term3 <= limit)
//            {
//                term3 = term1 + term2;
//                if (term3 % 2 == 0)
//                {
//                    total += term3;
//                }
//                Console.WriteLine(total);
//                term1 = term2;
//                term2 = term3;

//            }
//            Console.WriteLine(total);
//            Console.ReadLine();
//        }
//    }
//}
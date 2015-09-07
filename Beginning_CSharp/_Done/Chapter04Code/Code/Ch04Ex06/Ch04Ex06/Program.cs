using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch04Ex06
{
   class Program
   {
      static void Main(string[] args)
      {

            double realCoord, imagCoord;
            double realMax = 1.77;
            double realMin = -0.6;
            double imagMax = -1.2;
            double imagMin = 1.2;
            double realStep;
            double imagStep;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            while (true)
            {
               realStep = (realMax - realMin) / 79;
               imagStep = (imagMax - imagMin) / 48;
               for (imagCoord = imagMin; imagCoord >= imagMax;
                  imagCoord += imagStep)
               {
                  for (realCoord = realMin; realCoord <= realMax;
                     realCoord += realStep)
                  {
                     iterations = 0;
                     realTemp = realCoord;
                     imagTemp = imagCoord;
                     arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                     while ((arg < 4) && (iterations < 40))
                     {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                        - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                     }
                     switch (iterations % 4)
                     {
                        case 0:
                        Console.Write(".");
                        break;
                        case 1:
                        Console.Write("o");
                        break;
                        case 2:
                        Console.Write("O");
                        break;
                        case 3:
                        Console.Write("@");
                        break;
                     }
                  }
                  Console.Write("\n");
               }
               Console.WriteLine("Current limits:");
               Console.WriteLine("realCoord: from {0} to {1}", realMin, realMax);
               Console.WriteLine("imagCoord: from {0} to {1}", imagMin, imagMax);
               Console.WriteLine("Enter new limits:");
               Console.WriteLine("realCoord: from:");
               realMin = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("realCoord: to:");
               realMax = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("imagCoord: from:");
               imagMin = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("imagCoord: to:");
               imagMax = Convert.ToDouble(Console.ReadLine());
            
         }

         // bool res = false;
         // // do
         // // {
         // //    Console.WriteLine("Please input your first number:");
         // //    int var1 = Convert.ToInt32(Console.ReadLine());
         // //    Console.WriteLine("Please input your sencond number:");
         // //    int var2 = Convert.ToInt32(Console.ReadLine());

         // //    res = (var1 < 10) ^ (var2 < 10);

         // // }while (res != true);
         // while (res == false) 
         // {
         //    Console.WriteLine("Please input your first number:");
         //    double var1 = Convert.ToDouble(Console.ReadLine());
         //    Console.WriteLine("Please input your sencond number:");
         //    double var2 = Convert.ToDouble(Console.ReadLine());
         //    res = (var1 < 10) ^ (var2 < 10);
         // }

         // Console.WriteLine("Congratulation!");
         // Console.ReadKey();


         // int var1 = 5;
         // int var2 = 10;
         // bool res = (var1 < 10) ^ (var2 < 10);
         // Console.WriteLine((var1 < 10) ^ (var2 < 10));
         // Console.ReadKey();

      //    double realMax = 1.77;
      //    double realMin = -0.6;
      //    double imagMax = -1.2;
      //    double imagMin = 1.2;

      //    double realCoord, imagCoord;
      //    double realTemp, imagTemp, realTemp2, arg;
      //    int iterations;
      //    while (true) 
      //    {


      //    for (imagCoord = 1.2; imagCoord >= -1.2; imagCoord -= 0.05)
      //    {
      //       for (realCoord = -0.6; realCoord <= 1.77; realCoord += 0.03)
      //       {
      //          iterations = 0;
      //          realTemp = realCoord;
      //          imagTemp = imagCoord;
      //          arg = (realCoord * realCoord) + (imagCoord * imagCoord);
      //          while ((arg < 4) && (iterations < 40))
      //          {
      //             realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
      //             - realCoord;
      //             imagTemp = (2 * realTemp * imagTemp) - imagCoord;
      //             realTemp = realTemp2;
      //             arg = (realTemp * realTemp) + (imagTemp * imagTemp);
      //             iterations += 1;
      //          }
      //          switch (iterations % 4)
      //          {
      //             case 0:
      //             Console.Write(".");
      //             break;
      //             case 1:
      //             Console.Write("o");
      //             break;
      //             case 2:
      //             Console.Write("O");
      //             break;
      //             case 3:
      //             Console.Write("@");
      //             break;
      //          }
      //       }
      //       Console.Write("\n");
      //    }
      //    Console.WriteLine("Current limits:");
      //    Console.WriteLine("realCoord: from {0} to {1}", realMin, realMax);
      //    Console.WriteLine("imagCoord: from {0} to {1}", imagMin, imagMax);
      //    Console.WriteLine("Enter new limits:");
      //    Console.WriteLine("realCoord: from:");
      //    realMin = Convert.ToDouble(Console.ReadLine());
      //    Console.WriteLine("realCoord: to:");
      //    realMax = Convert.ToDouble(Console.ReadLine());
      //    Console.WriteLine("imagCoord: from:");
      //    imagMin = Convert.ToDouble(Console.ReadLine());
      //    Console.WriteLine("imagCoord: to:");
      //    imagMax = Convert.ToDouble(Console.ReadLine());

      //    Console.ReadKey();
      // }
   }
}
}
// namespace NamespaceName 
// {
//    public class ClassName 
//    {
//          public static void Main(string[] args)
//    {


//       double realCoord, imagCoord;
//       double realMax = 1.77;
//       double realMin = -0.6;
//       double imagMax = -1.2;
//       double imagMin = 1.2;
//       double realStep;
//       double imagStep;
//       double realTemp, imagTemp, realTemp2, arg;
//       int iterations;
//       while (true)
//       {
//          realStep = (realMax - realMin) / 79;
//          imagStep = (imagMax - imagMin) / 48;
//          for (imagCoord = imagMin; imagCoord >= imagMax;
//             imagCoord += imagStep)
//          {
//             for (realCoord = realMin; realCoord <= realMax;
//                realCoord += realStep)
//             {
//                iterations = 0;
//                realTemp = realCoord;
//                imagTemp = imagCoord;
//                arg = (realCoord * realCoord) + (imagCoord *
//                   imagCoord);
//                while ((arg < 4) && (iterations < 40))
//                {
//                   realTemp2 = (realTemp * realTemp) - (imagTemp *
//                      imagTemp)
//                   - realCoord;
//                   imagTemp = (2 * realTemp * imagTemp) - imagCoord;
//                   realTemp = realTemp2;
//                   arg = (realTemp * realTemp) + (imagTemp *
//                      imagTemp);
//                   iterations += 1;
//                }
//                switch (iterations % 4)
//                {
//                   case 0:
//                   Console.Write("."); break;
//                   case 1:
//                   Console.Write("o");
//                   break;
//                   case 2:
//                   Console.Write("O");
//                   break;
//                   case 3:
//                   Console.Write("@");
//                   break;
//                }
//             }
//             Console.Write("\n");
//          }
//          Console.WriteLine("Current limits:");
//          Console.WriteLine("realCoord: from {0} to {1}", realMin,
//             realMax);
//          Console.WriteLine("imagCoord: from {0} to {1}", imagMin,
//             imagMax);
//          Console.WriteLine("Enter new limits:");
//          Console.WriteLine("realCoord: from:");
//          realMin = Convert.ToDouble(Console.ReadLine());
//          Console.WriteLine("realCoord: to:");
//          realMax = Convert.ToDouble(Console.ReadLine());
//          Console.WriteLine("imagCoord: from:");
//          imagMin = Convert.ToDouble(Console.ReadLine());
//          Console.WriteLine("imagCoord: to:");
//          imagMax = Convert.ToDouble(Console.ReadLine());
//       }

//    }


//    }

// }

// namespace myTest 
// {
//    public class myClass 
//    {
//      public static void Main(string[] args)
//      {
//         Console.Write('s');
//         Console.Write('\n');
//         Console.WriteLine("Hello.");
//         Console.ReadKey();
//      }
//    }
// }
// using System;

// namespace UsingParams
// {
//     class MainApp
//     {
//         static int Sum(params int[] args)
//         {
//             int result=0;
//             for(int i=0;i<args.Length;i++)
//             {
//                 result+=args[i];
//             }

//             return result;
//         }
//         static void Main(string []args)
//         {
//             int sum= Sum(3,4,5,6,7,8,9,10);

//             Console.WriteLine(sum);
//         }
//     }
// }
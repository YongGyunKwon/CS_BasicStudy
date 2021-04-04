// using System;

// namespace Example54
// {
//     class Example54
//     {
//         static void Main(string[] args)
//         {
//             int a;
//             Console.Write("반복 횟수를 입력하세요.");
//             a = int.Parse(Console.ReadLine());


//             if(a <= 0)
//             {
//                 Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
//                 return ;
//             }
//             else
//             {
//                 for(int i=1;i<=a;i++)
//                 {

//                     for(int j=1;j<=i;j++)
//                     {
//                         Console.Write("*");
//                     }
//                     Console.WriteLine("");
//                 }
//             }
//         }
//     }
// }
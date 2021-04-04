// using System;

// namespace Example52
// {
//     class Star
//     {
//         public static void while_star()
//         {
//             var i = 1;
//             //while
//             while(i<=5)
//             {
//                 var j=0;
//                 while(j<i)
//                 {
//                     Console.Write("*");
//                     j++;
//                 }
//                 Console.WriteLine("");
//                 i++;
//             }
//         }

//         public static void do_while_star()
//         {
//             var i = 1;
            
//             do
//             {
//                 var j=0;
//                 while(j<i)
//                 {
//                     Console.Write("*");
//                     j++;
//                 }
//                 Console.WriteLine("");
//                 i++;
//             }while(i<=5);
//         }

//         public static void while_star_minus()
//         {
//             var i = 5;
            
//             while(1<=i)
//             {
//                 var j=1;
//                 while(j<=i)
//                 {
//                     Console.Write("*");
//                     j++;
//                 }
//                 Console.WriteLine("");
//                 i--;
//             }
//         }

//         public static void do_while_star_minus()
//         {
//             var i = 5;
            
//             do
//             {
//                 var j=1;
//                 while(j<=i)
//                 {
//                     Console.Write("*");
//                     j++;
//                 }
//                 Console.WriteLine("");
//                 i--;
//             }while(1<=i);
//         }


//         static void Main(string[] args)
//         {

//             while_star();
//             do_while_star();
//             while_star_minus();
//             do_while_star_minus();
//         }
//     }
// }
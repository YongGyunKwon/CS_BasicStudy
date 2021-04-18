// using System;

// namespace EX6_2
// {
//     class MainApp
//     {
//         public static void Main()
//         {
//             double mean = 0;
//             //mean 매개변수 자리에 ref를 넣어준다.
//             Mean(1,2,3,4,5,ref mean);

//             Console.WriteLine("평균: {0}",mean);
//         }

//         //mean 매개변수 자리에 ref를 넣어준다.
//         public static void Mean(double a,double b,double c,double d,double e,ref double mean)
//         {
//             mean=(a+b+c+d+e)/5;
//         }
//     }
// }

/*
2. 다음 코드에서 Mean() 메소드를 실행하고 난 후의 mean은 얼마의 값을 가질까요? 
3이라고요? 아닙니다. 0입니다. 
자, 문제 나갑니다. 
mean이 0을 갖게 되는 원인과 이를 바로잡으려면 다음 코드에서 어떤 부분을 고쳐야 할까요?

*/
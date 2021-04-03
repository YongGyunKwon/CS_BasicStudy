using System;

namespace Chapter3
{
    class Object
    {
        enum DigitalResult {YES, NO, CONFIRM, OK}
        /*
        static void Main(string[] args)
        {
            object a=1;
            object b=3.1415926;
            object c=true;
            object d="안녕";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            
            

            Console.WriteLine(DigitalResult.YES );
            Console.WriteLine(DigitalResult.NO );
            Console.WriteLine(DigitalResult.CONFIRM );
            Console.WriteLine(DigitalResult.OK );

            Console.WriteLine((int)DigitalResult.YES );
            Console.WriteLine((int)DigitalResult.NO );
            Console.WriteLine((int)DigitalResult.CONFIRM );
            Console.WriteLine((int)DigitalResult.OK );

            var x=1; //이렇게 초기화 시켜야 한다!! 
            Console.WriteLine(x);
        }
        */
    }


}

/*
Object 안에는 int long char bool stirng ... 등 모든 형식을 담을수 있다.


Enum은 열거형 이다. 
enum 열거 형식명 : 기반가료형{상수1 ,상수2 ,상수3 ..... }


var를 사용해서 변수를 선언하면 컴파일러가 자동으로 해당 변수의 형식을 지정해준다.
단 ,var 키워드를 이용해서 변수를 선언하려면 반드시 선언과 동시에 초기화를 해줘야 한다.
var 는 지역변수만 사용할 수 있다!!!!!!


*/
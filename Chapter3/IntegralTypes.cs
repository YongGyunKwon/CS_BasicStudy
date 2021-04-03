using System;

namespace Chapter3
{
    class IntegralTypes
    {
        
        static void Main(string[] args)
        {
            sbyte a=-10;
            byte b=40;

            Console.WriteLine("a={0}, b={1}",a,b);

            short c = -3000;
            ushort d =6000;

            Console.WriteLine("c={0}, d={1}",c,d);

            int e=-10000000; //0이 7개
            uint f=300000000; //0이 8개 

            Console.WriteLine("e={0}, f={1}",e,f);

            long g = -500000000000; //0 11개
            ulong h =2000000000000000000; //0이 18개

            Console.WriteLine("g={0} h={1}",g,h);
        }
        
    }
}


/*

데이터 형식     설명             크기    담을수 있는 값의 범위
byte        부호 없는 정수       1       0~255  
sbyte       signed byte         1       -125~127
short       정수                2       -32768~32767
unshort     unsigned short      2       0~65535
            부호없는 정수               
int         정수                4       -2147483648~2147483647
uint        unsigned int        4       0~4294967295
            부호없는 정수
long        정수                8       -922337203685447508~922337203685477507
ulong       unsigned long       8       0~18446744073709551625
            부호없는 정수
char        유니코드 문자        2




*/
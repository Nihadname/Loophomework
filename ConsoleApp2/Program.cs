// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
#region 1citask
//1.Verilmiş n və m (n<m) ədədləri arasında neçə tək ədəd olduğunu tapın.
int num1 = 7;
int num2 = 36;
int icreasment = 0;
for (int i = num1; i < num2; i++)
{
    if (num1 < num2)
    {
        if (i % 2 == 1)
        {
            icreasment++;
            //Console.WriteLine(i);
        }
    }
}
Console.WriteLine(icreasment);
#endregion 
#region 2citask
//2.Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın.
int num3 = 13;
if (num3 == 1)
{
    Console.WriteLine($"{num3} bu seda ve murekkebdir");
}
else if (num3 == 2 || num3 == 3)
{
    Console.WriteLine($"{num3} seda ededir");
}
else if (num3 % 2 == 0 || num3 % 3 == 0)
{
    Console.WriteLine($"{num3} murekkeb ededdir");
}
else
{
    Console.WriteLine($"{num3} sade ededdir");
}
#endregion 
#region 3cutask
//3.Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın.
int num5 = 32;
bool isPowerOf2 = true; // bunu 2 nin quvveti kimi goturek

if (num5 <= 0)
{
    Console.WriteLine($"{num5} 2nin quvveti deyil"); //  0 ve menfi ededler 2nin quvveti ola bilmes
}
else
{
    while (num5 > 1)
    {
        if (num5 % 2 != 0)
        {
            isPowerOf2 = false;
            num5 = 1;

        }
        num5 /= 2;

    }

    if (isPowerOf2)
    {
        Console.WriteLine($"{num5} 2nin quvvetidir ");
    }
    else
    {
        Console.WriteLine($"{num5} 2nin quvveti deyil");
    }
}
#endregion
#region 4cu task
//Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
int num = 1468;
int result = 0;
while (num > 0)//burda while dongu sali 0-dan böyük olana kimi
{
    result++;//burda biz ededi ona bolduyumuz qeder artacaq ve burda 3defe 10 bolunub ona gore cavab 3 olur
    num /= 10;
}
Console.WriteLine(result);
#endregion

// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
#region 1ci sual
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
#endregion 
#region 2ci gun
//2.Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın.
Console.WriteLine(icreasment);

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
#region 3ci sual
//3.Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın.
int num5 = 16;
if(num5 <=0)
{
      Console.WriteLine($"{num5}2nin quvveti deyil ");//cunki menfi ve sifri ededler ola bilmez
    
} 
while(num5 > 1)
{
    if(num5 % 2 != 0)
    {
        Console.WriteLine($"{num5}2nin quvveti deyil");
    }
    num5 /= 2;
}
#endregion
#region 4cu sual
//Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
int num = 145;
int result = 0;
while (num > 0)//burda while dongu sali 0-dan böyük olana kimi
{
   result++;//burda biz ededi ona bolduyumuz qeder artacaq ve burda 3defe 10 bolunub ona gore cavab 3 olur
    num /= 10;
}
Console.WriteLine(result);
#endregion
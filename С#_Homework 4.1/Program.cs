using С__Homework_4._1;
using System;
using System.Runtime.ConstrainedExecution;

Magazine obj = new("Вокруг света", 1861, "Научно-популярный географический журнал", 2685214, "vokrugsveta@sholding.ru", 100);
Console.WriteLine(obj.Name);
Console.WriteLine(obj.Year);
Console.WriteLine(obj.Descript);
Console.WriteLine(obj.Number);
Console.WriteLine(obj.Email);
Console.WriteLine(obj.Employees);

Console.WriteLine();

Magazine obj2 = new("Наука и жизнь", 1934, "Журнал о научных открытиях и новых технологиях", 390585803, "nkj.ru", 99);

//obj.Name = "Наука и жизнь";
//obj.Year = 1934;
//obj.Descript = "Журнал о научных открытиях и новых технологиях";
//obj.Number = 390585803;
//obj.Email = "nkj.ru";
//obj.Employees = 11;

Console.WriteLine(obj2.Name);
Console.WriteLine(obj2.Year);
Console.WriteLine(obj2.Descript);
Console.WriteLine(obj2.Number);
Console.WriteLine(obj2.Email);
Console.WriteLine(obj2.Employees);

Console.WriteLine();

obj = obj + 10;
Console.WriteLine(obj.Employees);

Console.WriteLine();

obj = obj - 1;
Console.WriteLine(obj.Employees);

Console.WriteLine();

if (obj == obj2)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}


Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine();

Shop obj3 = new("АТБ", "Ген. Бочарова, 57", "Продуктовый магазин", 0933371435, "www.atbmarket.com", 980);
Console.WriteLine(obj3.Name);
Console.WriteLine(obj3.Address);
Console.WriteLine(obj3.Descript);
Console.WriteLine(obj3.Number);
Console.WriteLine(obj3.Email);
Console.WriteLine(obj3.Area);

Console.WriteLine();

Shop obj4 = new("Лавка Художника", "Ланжероновская, 17", "Товары для художников и дизайнеров", 0638571768, "paint.dn.ua", 1245);

Console.WriteLine(obj4.Name);
Console.WriteLine(obj4.Address);
Console.WriteLine(obj4.Descript);
Console.WriteLine(obj4.Number);
Console.WriteLine(obj4.Email);
Console.WriteLine(obj4.Area);

Console.WriteLine();

obj3 = obj3 - 10;
Console.WriteLine(obj3.Area);

Console.WriteLine();

obj4 = obj4 + 15;
Console.WriteLine(obj4.Area);

Console.WriteLine();

if (obj3 == obj4)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}





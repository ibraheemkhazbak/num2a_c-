using num2a_C_;
using System;

INum2a svc = new Num2a();

List<(string, long)> output = new List<(string, long)>();
Random r = new Random();
long num;
for (int i = 0; i <= 100; i++)
{
    num = r.NextInt64(0, 1000000);
    output.Add((svc.ProcessNumW(i, "دولار", "دولارا", "دولارين", "دولارات", false, false), i));
}

Console.WriteLine("done");
Console.ReadLine();

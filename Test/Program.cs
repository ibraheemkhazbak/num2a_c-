using num2a_C_;

INum2a svc = new Num2a();

List<string> output = new List<string>();
for (int i = 0; i <= 100; i++)
{
    output.Add(svc.ProcessNumW(i, "دولار", "دولارا", "دولارين", "دولارات", false, false));
}
Console.WriteLine("done");
Console.ReadLine();

// eded ikinin quvvetidir ya yox
Console.WriteLine("eded daxil et");
int n = Convert.ToInt32(Console.ReadLine());
bool quvvet = false;
if (n > 0)
{
    while (n % 2 == 0)

    {
        n = n / 2;
    }
    if (n == 1)
    {
        quvvet = true;
    }
    if (quvvet)
        Console.WriteLine("Eded ikinin quvvetidir");
    else
        Console.WriteLine("Eded ikinin quvvet deyil");
}
else
    Console.WriteLine("musbet eded daxil edin");

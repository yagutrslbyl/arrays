// ededin mertebelerinin en boyuyu
Console.WriteLine("Enter a number:");
int n = Convert.ToInt32(Console.ReadLine());
int max = 0;
while (n > 0)
{
    n = n % 10;
    if (max < n)
    {
        max = n;
    }
    n = n / 10;
}
Console.WriteLine(max);
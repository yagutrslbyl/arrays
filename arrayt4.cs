// hem cut hem 3e bol sayi
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 33 };
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0 && numbers[i]%3==0)
    {
        count = count + 1;
    }
}
Console.WriteLine(count);

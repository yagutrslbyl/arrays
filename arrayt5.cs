// murekkeb sayi
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 33 };
int count = 0;
for(int i=0;i<numbers.Length;i++)
{
    for (int j = 2; j < numbers[i]; j++)
    {
        if (numbers[i]>3 && numbers[i] % j == 0)
            count += 1;
            break;

    }
    
}
Console.WriteLine(count);
//en kicik ve en b cemi
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 7 };
int max = numbers[0];
int min = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (max < numbers[i])
        max = numbers[i];
    if (min > numbers[i])
        min = numbers[i];
}
int sum = max + min;
Console.WriteLine(sum);
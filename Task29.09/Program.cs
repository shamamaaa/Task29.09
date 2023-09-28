/* TASK1
int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 12, 34 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers[i];

}
Console.WriteLine(sum);
*/

/* TASK2
string[] words = { "salam", "beli", "ev", "universitet" };

for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length>4)
    {

        Console.WriteLine(words[i]);

    }
}
*/

/* TASK3
int[] numbers = new int[] { 1, 9, 6, 7, 5, 30, 12, 3, 21, 45 };
int temp;

for (int i = 0; i < numbers.Length - 1 ; i++)
{
    for (int j = 1+i; j < numbers.Length; j++)
    {
        if (numbers[i] < numbers[j])
        {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }

    }
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
*/
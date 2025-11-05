// See https://aka.ms/new-console-template for more information
/*//Assignment_2_A
Console.WriteLine("Enter number of array items: ");
int Number = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Number];
int sum = 0;
int count = 0;
for (int x = 0; x < Number; x++)
{
    Console.WriteLine($"Enter number {x + 1}");
    numbers[x] = Convert.ToInt32(Console.ReadLine());
    sum += numbers[x];
    count++;
}
int average = sum / count;
for (int i = 0; i < Number; i++)
{
    if (numbers[i] > average)
    {
        Console.WriteLine($"{numbers[i]} is above average");
    }
}*/


// Assignment_2B
/*Console.WriteLine("Enter number of numbers: ");
int Number = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[Number];
for (int j = 0; j < Number; j++)
{
    Console.WriteLine($"Enter number {j + 1}: ");
    int input = Convert.ToInt32(Console.ReadLine());
    Array[j] = input;
}
for (int i = Number - 1; i >= 0; i--)
{
    Console.Write($"{Array[i]} ");
}*/


// Assignment_2_C
/*string str = Console.ReadLine();
Dictionary<char, int> dic = new Dictionary<char, int>();
for (int i = 0; i < str.Length; i++)
{
    if (dic.ContainsKey(str[i]))
    {
        dic[str[i]]++;
    }
    else
    {
        dic.Add(str[i], 1);
    }
}

foreach (var item in dic)
{
    if (item.Value == 1)
    {
        Console.WriteLine(item.Key);
        break;
    }
}*/
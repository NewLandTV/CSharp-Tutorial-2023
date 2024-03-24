int[] array = new int[10]
{
    1, 6, 9, 4, 6, 9, 7, 4, 1, 5
};

array[2] = 10;
array[6] *= 2;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
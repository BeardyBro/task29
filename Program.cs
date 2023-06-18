int [] array = new int [8];
void Random(int [] array)
{
    for ( int a = 0; a < array.Length; a++)
    {
        array[a] = new Random().Next(9);
        Console.Write(array[a]+" ");
    }
}
Random(array);
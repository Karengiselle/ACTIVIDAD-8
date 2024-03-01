using System;

class Program
{
    static void Main()
    {
        int[] array = { 8, 43, 17, 6, 40, 16, 18, 97, 11, 7 };

        Console.WriteLine("Array original: " + string.Join(", ", array));
        ShellSort(array);
        Console.WriteLine("Array ordenado: " + string.Join(", ", array));
    }

    static void ShellSort(int[] array)
    {
        int n = array.Length;
        int pasadas = 0, intercambios = 0;

        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i += 1)
            {
                int temp = array[i];
                int j;

                for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                {
                    array[j] = array[j - gap];
                    intercambios++;
                }

                array[j] = temp;
                pasadas++;
            }
        }

        Console.WriteLine("Pasadas: " + pasadas);
        Console.WriteLine("Intercambios: " + intercambios);
    }
}

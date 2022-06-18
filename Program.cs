using System;
class Program
{   //Задан массив из k сиволов.Определить количество различных элементов в массиве.
    static void Main(string[] args)
    {
        String s;
        int k, n = 0,l=0;
        System.Console.WriteLine("Razmer massiva");
        s = Console.ReadLine();
        k = System.Convert.ToInt32(s);
        int[] array = new int[k];
        System.Console.WriteLine("Vvod massiva: ");
        for (int i = 0; i < array.Length; i++)
        {
            s = Console.ReadLine();
            array[i] = System.Convert.ToInt32(s);
        }
        for (int j = 0; j < array.Length; j++)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[j] == array[i])   n++;
            }
            if (n > 1) l++;
            n = 0;
        }
        System.Console.WriteLine("kolvo raz el: " + (array.Length-l));

    }
}

using System;
 
class Mass
{
    int[] mass;
    public Mass(int n)
    {
        mass = new int[n];
    }
    public void Fill()
    {
        Random r = new Random();
        for (int i = 0; i < mass.Length; i++)
            mass[i] = r.Next(0,100);
    }
    public int[] search(int n)
    {
        int max = int.MinValue;
        int k;
        int z = 0;
        if (n <= mass.Length)
            for (int i = 0; i < mass.Length - n; i++)
            {
                k = 0;
                for (int j = 0; j < n; j++)
                    k += mass[i + j];
                if (k > max)
                {
                    max = k;
                    z = i;
                }
            }
        int[] mas = new int[n];
        for (int i = 0; i < n; i++)
            mas[i] = mass[z + i];
        return mas;
    }
    public void Display()
    {
        Console.Write("Масив: ");
        for (int i = 0; i < mass.Length; i++)
            Console.Write(mass[i] + " ");
        Console.WriteLine("\n");
    }
    public static void Main()
    {
        Mass x = new Mass(100);
        x.Fill();
        x.Display();
        int[] z = x.search(10);
        Console.WriteLine("Неперервна ділянка із 10 чисел, сума яких найбільша: ");
        for (int i = 0; i < z.Length; i++)
            Console.WriteLine("[{0}] = {1}", i, z[i]);
    }
}

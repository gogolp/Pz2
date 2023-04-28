using System;
class HelloWorld 
{
    static void Main() 
    {
        int[] Arr = new int[20];

            Random rand = new Random();
            
            Console.Write("Масив: ");

            for (int x = 0; x < Arr.Length; x++)
            {
                Arr[x] = rand.Next(0, 3);
                Console.Write(Arr[x] + " ");

            }

            Array.Sort(Arr);
            Console.WriteLine();
            
            Console.Write("Сортований масив: ");

            for (int x = 0; x < Arr.Length; x++)
            {
                Console.Write(Arr[x] + " ");
            }
            
            Console.WriteLine();
            Console.Read();
    }
}


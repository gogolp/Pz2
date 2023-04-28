using System;

class HelloWorld 
{
    //метод обміну елементів
    static void Swap(ref int e1, ref int e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }

    //сортування вставками
    static int[] InsertionSort(int[] myArray)
    {
        for (var i = 1; i < myArray.Length; i++)
        {
            var key = myArray[i];
            var j = i;
            while ((j > 1) && (myArray[j - 1] > key))
            {
                Swap(ref myArray[j - 1], ref myArray[j]);
                j--;
            }

            myArray[j] = key;
        }

        return myArray;
    }
    public static void Main(string[] args)
    {
        // створення масиву
        int[] myArray = new int[30];
        Random rand = new Random();
        
        Console.WriteLine("Масив: ");
        for (int x = 0; x < myArray.Length; x++)
        {
          myArray[x] = rand.Next(20);
          Console.Write(myArray[x] + " ");
        }
        
        //сортування методом з презентації (бульбашка)
        int srt = myArray[0];
            for (int i=1; i<30; i++)
            {
                for (var j = 0; j < 29; j++)
                {
                    if (myArray[j]>myArray[j+1])
                    {
                        srt = myArray[j];
                        myArray[j]=myArray[j+1];
                        myArray[j+1]=srt;
                    }
                }
            }
            
        // сортування масиву вставками
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = Convert.ToInt32(myArray[i]);
        }
            
            //вивід сортованого масиву №1
            Console.WriteLine("\n" + "\n" + "Масив пiсля сортування методом з презентації: ");
            foreach (int m in myArray) Console.Write(m + " ");
            Console.WriteLine("\n");
            //вивід сортованого масиву №2
            Console.WriteLine("Масив пiсля сортування власним методом: ");
            Console.WriteLine(string.Join(" ", InsertionSort(myArray)));
            System.Console.ReadLine();
    }
}

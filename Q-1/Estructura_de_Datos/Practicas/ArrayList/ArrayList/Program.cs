using System;
using System.Linq.Expressions;

namespace ArrayList
{
    class ArrayList
    {
        public int[] ArrayInterno;
        public int Count = 0;
        public int TasaDeCrecimiento = 10;

        public ArrayList()
        {
            this.ArrayInterno = new int[this.TasaDeCrecimiento];
        }

        public ArrayList(int capacidadInicial)
        {
            this.ArrayInterno = new int[capacidadInicial];
        }
    }

    class Program
    {

        static void ArrayList_Add(ArrayList unaLista, int nuevoElemento)
        {
            if (unaLista.Count == unaLista.ArrayInterno.Length)
            {
                int[] nuevoArrayInterno = new int[unaLista.Count + unaLista.TasaDeCrecimiento];
                for (int i = 0; i < unaLista.ArrayInterno.Length; i++)
                {
                    nuevoArrayInterno[i] = unaLista.ArrayInterno[i];
                }

                unaLista.ArrayInterno = nuevoArrayInterno;
            }

            unaLista.ArrayInterno[unaLista.Count] = nuevoElemento;
            unaLista.Count++;

        }

        static int ArrayList_ElementAt(ArrayList unaLista, int index)
        {
            if (index >= unaLista.Count || index < 0)
                throw new IndexOutOfRangeException();
            return unaLista.ArrayInterno[index];
        }

        static void ArrayList_Enumerar(ArrayList arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList.ArrayInterno[i]);
            }
        }

        static void ArrayList_Insert(ArrayList aList, int element, int index)
        {
            if (index > aList.Count || index < 0)
                throw new IndexOutOfRangeException();

            int[] newArr = new int[aList.Count + aList.TasaDeCrecimiento];
            int arrInternoLen = aList.ArrayInterno.Length;

            for (int i = 0; i < arrInternoLen; i++)
            {
                if (i < index)
                    newArr[i] = aList.ArrayInterno[i];
                else if (i == index)
                {
                    newArr[i] = element;
                    newArr[i + 1] = aList.ArrayInterno[i];
                }
                else
                    newArr[i + 1] = aList.ArrayInterno[i];
            }
            aList.ArrayInterno = newArr;

            aList.Count++;
        }

        static void ArrayList_RemoveAt(ArrayList aList, int index)
        {
            if (index > aList.Count || index < 0)
                throw new IndexOutOfRangeException();

            int[] newArr = new int[aList.ArrayInterno.Length - 1];
            int arrInternoLen = aList.ArrayInterno.Length - 1;

            for (int i = 0; i < arrInternoLen; i++)
            {
                if (i < index)
                    newArr[i] = aList.ArrayInterno[i];
                else
                    newArr[i] = aList.ArrayInterno[i + 1];
            }
            aList.ArrayInterno = newArr;
            aList.Count--;
        }

        static int ArrayList_IndexOf(ArrayList aList, int element)
        {
            int arrInternoLen = aList.ArrayInterno.Length;
            for (int i = 0; i < arrInternoLen; i++)
            {
                if (aList.ArrayInterno[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                ArrayList_Add(list, i);
            }

            Console.WriteLine("Before: ");
            ArrayList_Enumerar(list);

            Console.WriteLine($"\n{list.Count} elements");

            Console.WriteLine("\nElement at index 4:");
            Console.WriteLine(ArrayList_ElementAt(list, 4));


            ArrayList_Insert(list, 10, 2);

            Console.WriteLine("\nAfter insert: ");
            ArrayList_Enumerar(list);

            Console.WriteLine($"\n{list.Count} elements");

            Console.WriteLine("\nElement at index 4:");
            Console.WriteLine(ArrayList_ElementAt(list, 4));

            int number = 5;
            Console.WriteLine($"\n{number} at index: {ArrayList_IndexOf(list, number)}");

            ArrayList_RemoveAt(list, 2);

            Console.WriteLine("\nAfter remove:");
            ArrayList_Enumerar(list);

            Console.WriteLine($"\n{list.Count} elements");

            Console.WriteLine($"\n{number} at index: {ArrayList_IndexOf(list, number)}");

            Console.ReadLine();


        }
    }
}
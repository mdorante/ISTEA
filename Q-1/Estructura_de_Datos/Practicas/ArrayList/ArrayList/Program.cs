using System;

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


        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();


            for (int i = 0; i < 100; i++)
            {
                ArrayList_Add(list, i);
            }

            ArrayList_Enumerar(list);

            Console.ReadLine();
        }
    }
}
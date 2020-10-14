using System;
using Exercise_1;

namespace Exercise_1
{
    class Program
    {
        static int GetNumNames()
        {
            int cantNombres = 0;
            bool isNumberNames = false;

            while (!isNumberNames || cantNombres == 0)
            {
                Console.Write("Indique la cantidad de nombres a ingresar: ");
                isNumberNames = int.TryParse(Console.ReadLine(), out cantNombres);
            }

            return cantNombres;
        }

        static int numNames = GetNumNames();

        static Persona[] InitPersonasArray()
        {
            Persona[] personas = new Persona[numNames];

            for (int i = 0; i < personas.Length; i++)
            {
                personas[i] = new Persona();
            }
            return personas;
        }

        static void GetNames(ref Persona[] personasArr)
        {
            for (int i = 0; i < numNames; i++)
            {
                Console.Write($"Indique el nombre numero {i + 1}: ");
                personasArr[i].nombre = Console.ReadLine();
            }

            return;
        }

        static void GetAges(ref Persona[] personasArr)
        {
            bool isNumberAges = false;

            for (int i = 0; i < numNames; i++)
            {
                while (!isNumberAges)
                {
                    Console.Write($"Indique una edad para el nombre numero {i + 1}: ");
                    isNumberAges = int.TryParse(Console.ReadLine(), out personasArr[i].edad);
                }
                isNumberAges = false; // reseteamos el valor de isNumberAges para que en el siguiente nombre vuelva a pedir edad
            }
            return;
        }

        static void GetWeights(ref Persona[] personasArr)
        {
            bool isNumberPesos = false;

            for (int i = 0; i < numNames; i++)
            {
                while (!isNumberPesos)
                {
                    Console.Write($"Indique el peso en kilos para el nombre numero {i + 1}: ");
                    isNumberPesos = float.TryParse(Console.ReadLine(), out personasArr[i].peso);
                }
                isNumberPesos = false;
            }

            return;
        }

        static void GetStatures(ref Persona[] personasArr)
        {
            bool isNumberAlturas = false;

            for (int i = 0; i < numNames; i++)
            {
                while (!isNumberAlturas)
                {
                    Console.Write($"Indique la altura en metros para el nombre numero {i + 1}: ");
                    isNumberAlturas = float.TryParse(Console.ReadLine(), out personasArr[i].altura);
                }
                isNumberAlturas = false;
            }

            return;
        }

        static void GetImc(ref Persona[] personasArr)
        {
            for (int i = 0; i < numNames; i++)
            {
                personasArr[i].imc = personasArr[i].peso / (float)Math.Pow(personasArr[i].altura, 2);
            }

            return;
        }

        static string[] GetImcMessages(Persona[] personasArr)
        {
            string[] messages = new string[numNames];

            for (int x = numNames - 1; x >= 0; x--)
            {
                if (personasArr[x].imc <= 15f)
                {
                    messages[x] = "Delgadez muy severa";
                }
                else if (personasArr[x].imc <= 15.9f)
                {
                    messages[x] = "Delgadez severa";
                }
                else if (personasArr[x].imc <= 18.4f)
                {
                    messages[x] = "Delgadez";
                }
                else if (personasArr[x].imc <= 24.9f)
                {
                    messages[x] = "Saludable";
                }
                else if (personasArr[x].imc <= 29.9f)
                {
                    messages[x] = "Sobrepeso";
                }
                else if (personasArr[x].imc <= 34.9f)
                {
                    messages[x] = "Obesidad moderada";
                }
                else if (personasArr[x].imc <= 39.9f)
                {
                    messages[x] = "Obesidad Severa";
                }
                else if (personasArr[x].imc >= 40f)
                {
                    messages[x] = "Obesidad Mórbida";
                }
            }

            return messages;
        }

        static void PrintPersonIMCDetails(Persona[] personasArr, string[] imcMessages)
        {
            for (int x = numNames - 1; x >= 0; x--)
            {
                Console.WriteLine($"Elemento [{x + 1}] Nombre:{personasArr[x].nombre} Edad:{personasArr[x].edad} IMC:{personasArr[x].imc} Categoria:{imcMessages[x]}");
            }
        }

        static void Main(string[] args)
        {
            Persona[] personas = InitPersonasArray();

            GetNames(ref personas);
            Console.WriteLine();

            GetAges(ref personas);
            Console.WriteLine();

            GetWeights(ref personas);
            Console.WriteLine();

            GetStatures(ref personas);
            Console.WriteLine();

            GetImc(ref personas);

            string[] imcMessages = GetImcMessages(personas);
            PrintPersonIMCDetails(personas, imcMessages);
        }
    }
}
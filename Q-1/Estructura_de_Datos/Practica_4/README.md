# Estructura de Datos y Tecnología Computacional

## Ejercitación parte 4

1. Observe el siguiente fragmento de código, indique cual es el valor de varA y de varB al finalizar la ejecución.

   ```cs
    int varA = 50;
    int varB = 99;
    int buffer;

    buffer = varA;
    varA = varB;
    varB = buffer;

   ```

2. Observe el siguiente fragmento de código, indique que es lo que sucederá al ejecutarlo.

   ```cs
   static void Main(string[] args)
   {
       int cantNombres = 0;
       string[] nombres;

       Console.Write("Indique la cantidad de nombres a ingresar: ");
       cantNombres = int.Parse(Console.ReadLine());

       nombres = new string[cantNombres];

       for (int i = 0; i < nombres.Length; i++)
       {
           Console.Write($"Indique el nombre numero {i+1}: ");
           nombres[i] = Console.ReadLine();
       }

       Console.WriteLine("Usted escribio: ");


       for (int x = nombres.Length - 1; x >= 0; x--)
       {
           Console.WriteLine(nombres[x]);
       }

       Console.ReadLine();
   }
   ```

3. Tome como base el ejercicio anterior.
   - Hemos notado que cuando indicamos 0 o un número menor en la cantidad de nombres a ingresar se produce un comportamiento no deseado, se necesita que mientras se indique números inválidos se nos vuelva a pedir ingresar la cantidad.
   - Se pide que el programa además de nombres pida una edad para cada nombre ingresado y cuando se muestra en pantalla la información recibido por el usuario debe mostrarse el número de elemento de la misma manera que cuando fue ingresado (es decir index del array + 1 ) a su lado el nombre y la edad correspondiente.
     Ejemplo de output esperado:
     ```console
     Indique la cantidad de nombres a ingresar: 3
     Indique el nombre numero 1: Leia
     Indique una edad para el nombre numero 1: 25
     Indique el nombre numero 2: Han
     Indique una edad para el nombre numero 2: 28
     Indique el nombre numero 3: R2D2
     Indique una edad para el nombre numero 3: 55
     Usted escribio:
     Elemento [3] Nombre:R2D2  Edad:55
     Elemento [2] Nombre:Han  Edad:28
     Elemento [1] Nombre:Leia  Edad:25
     ```
4. - El usuario tiene una nueva necesidad, además de la edad ahora pide que el programa pregunte la altura en metros y peso en kg, finalmente el proceso al momento de mostrar la información de cada uno tendrá que decirnos cual es su índice de masa corporal y en qué categoría se encuentra.
   - El cálculo de IMC en C# se escribiria asi: peso / Math.Pow(altura,2)
   - (La función Math.Pow recibe dos parámetros, el primero es el número que queremos elevar y el segundo es la potencia a la cual lo queremos elevar.)
     La tabla de rangos que usaremos es la siguiente:
     |IMC|Categoria|
     |---|---|
     |15 o menos|Delgadez muy severa|
     |15 a 15.9|Delgadez severa|
     |16 a 18.4|Delgadez|
     |18.5 a 24.9|Saludable|
     |25 a 29.9|Sobrepeso|
     |30 a 34.9|Obesidad moderada|
     |35 a 39.9|Obesidad Severa|
     |40 o más|Obesidad Mórbida|
5. Escribir un programa que nos pida ingresar una cantidad deseada de registros a ingresar, y luego nos pida ingresar tantos números como se haya elegido.
   Una vez cargados todos los registros deberá mostrarlos en fila por ejemplo, si ingresamos 5 números deberá mostrarlos así:

   ```console
   [40][88][65][74][33]
   ```

   Luego deberá intercambiar el primer número elegido con todos los otros hasta llegar a ser el último y mostraremos nuevamente como quedó nuestra lista:

   ```console
   [88][65][74][33][40]
   ```

   No olvidar incluir todas las validaciones que considere necesarias.
   (Pista: la clave de como resolverlo está en aplicar correctamente lo visto ejercicio 1)

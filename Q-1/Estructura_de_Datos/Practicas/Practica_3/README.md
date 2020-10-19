# Estructura de Datos y Tecnología Computacional

## Ejercitación parte 3

1. Analizar el programa, resaltar el cuerpo del loop e indicar cómo salir de él

```cs
public static void Main(String[] args)
{
int numero;

    int max = -100000;

    //Recibimos el numero por primera vez.
    numero = int.Parse(Console.ReadLine());

    //Si numero es diferente de -1, continuamos
    while(numero != -1)
    {
    	// es numero mayor a max?
    	if(numero > max)
    	{
    		//actualizamos max
    		max = numero;
    	}

    	/* obtenemos el proximo numero */
    	numero = int.Parse(Console.ReadLine());

    }

    /* escribimos el numero mas grande */
    Console.WriteLine("El numero mas grande es " + max);

}
```

2- Analizar el programa, resaltar el cuerpo del loop e indicar cómo salir de él.

```cs
public static void Main(String[] args)
{

    // Aqui contaremos los pares e impares
    int pares = 0;
    int impares = 0;

    // Aqui guardaremos los numeros
    int numero;

    // obtenemos el primer numero
    numero = int.Parse(Console.ReadLine());


    // 0 termina la ejecucion
    while(numero != 0)
    {
    	// check if the number is odd
    	if(numero % 2 != 0)
    	{
    		// incrementa el contador de impares
    		impares++;
    	}
    	else
    	{
    		// incrementa el contador de pares
    		pares++;
    	}

    	// obtenemos el proximo numero
    	numero = int.Parse(Console.ReadLine());
    }
    // mostramos el resultado.
    Console.WriteLine("Numeros Pares: " + pares);
    Console.WriteLine("Numeros impares: " + impares);

}
```

3- Completar el siguiente fragmento de código (Las partes subrayadas) para que se imprima el valor de mientras este sea menor que 6.

```cs
int i = 1;
while(i 6)
{
    Console.WriteLine(i);
    i++;
}
```

4. Escribir un programa que le pida al usuario ingresar dos números enteros, el programa debe validar:

- Que los números ingresados no sean iguales. Si lo son se debe mostrar un mensaje mediante consola indicando que los números ingresados no deben ser iguales y finalizar la ejecución del programa mediante el uso de la función `Environment.Exit(-1)`.
- Que el primer número elegido sea menor que el segundo. Si no es se debe mostrar un mensaje mediante consola indicando que el primer número debe ser menor al segundo y finalizar la ejecución del programa mediante el uso de la función `Environment.Exit(-1)`.
- El programa luego procederá a mostrar en consola cuales son todos los números pares que se encuentren dentro del rango, incluyendo las cotas.

5. Escribir un programa que pida al usuario ingresar un número que deberá ser mayor o igual a 9 y menor o igual a 40, esto debe ser validado por el programa y en caso de no cumplirse informar mediante consola y finalizar la ejecución usando la función `Environment.Exit(-1)`
   Luego:

- Se deberá hallar el máximo divisor para el número que no sea él mismo.
- Luego se deberán imprimir en pantalla de mayor a menor todos los números entre el elegido y 1 inclusive teniendo en cuenta que la cantidad máxima de números a mostrar por línea tiene que ser el máximo divisor.
- Cada número deberá estar encerrado entre corchetes, por ej: [1]

  Ejemplos de ejecución:

  Nro. elegido: 9

  Output esperado:

  ```console
  [9][8][7]
  [6][5][4]
  [3][2][1]
  ```

  Nro. elegido: 20

  Output esperado:

  ```console
  [20][19][18][17][16][15][14][13][12][11]
  [10][9][8][7][6][5][4][3][2][1]
  ```

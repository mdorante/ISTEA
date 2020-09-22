using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Programg
    {
        /*******************************
         
         ¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡IMPORTANTE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
         - Esta terminantemente PROHIBIDO la utilizacion de las strings
           y todo relacionado a ellas excepto por la unica función aqui provista.
         - Esta PROHIBIDO utilizar cualquier atributo o metodo o funcion de los arrays (tampoco se puede usar .Length).
         - Esta PROHIBIDO utilizar cualquier funcion o clase del framework excepto las asociadas a Console y Math,
           esto significa que no se pueden usar ninguna de las funciones Parse o Convert por ejemplo.
         - Los unicos tipos que se pueden utilizar son los tipos basicos (int, char, double, float y bool).
         - Todas las funciones deben validar sus argumentos a menos que se diga lo contario.
         - Cada funcion debe tener una funcion cuya firma sea void Test_<NombreDeFuncion>() e implemente al menos un caso de uso para la funcion en cuestion.

        ¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡IMPORTANTE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        PISTA: Los numeros enteros decimales tambien son llamados numeros en base 10.

        Objetivo: Vamos a crear una serie de funciones analogas a las de las strings pero basadas en arrays de chars.
         ¡¡¡¡¡a partir de este momento nuestros arrays de chars pasaran a llamarse CStrings!!!!!.
        
        Especificacion funcional de las CStrings:
        - Estan representadas por arrays de char con una particularidad, haremos uso del char '\0' como fin de string o EOS
        - El EOS marca el final de la CString, por ejemplo [hola como estas?\0chau hasta luego] tendra un largo de 16 ya que EOS (\0) indica el final.
        - Para Crear CString a partir de una string comun y corriente usamos la funcion que viene provista CrearCString(string arg).


        Finalmente: Cada funcion tiene un puntaje pre-asignado que no será mostrado sino hasta la fecha de entrega, el total es de 10
        Las funciones seran evaluadas de manera independiente, 
        esto significa que si una funcion hace uso de otra que no anda bien pero la logica es correcta, estará correcta.
        
        
        Lea atentamente la descripcion de cada una de las funciones y definala debajo de su explicacion.
        *********************************/

        const char EOS = '\0';



        /* funcion CStringLength(arg)
           Retorna el largo de la CString.

            El largo de una CString es determinado por el EOS final: 
             - Una CString es tan larga como el numero de caracteres entre el inicio de la CString y el EOS finalizador 
             (SIN incluir el EOS finalizador).
           Esto no debe ser confundido con el tamaño del array que contiene la CString

            Parametro:
            *arg: una CString.
            
            Retorno:
            *El largo de arg.
         */
        static int CStringLength(char[] arg)
        {
            int indx = 0;

            while (arg[indx] != EOS)
            {
                indx++;
            }

            return indx;

        }


        static void MostrarCStrEnConsola(char[] cStr)
        {
            int largo = CStringLength(cStr);

            for (int i = 0; i < largo; i++)
            {
                Console.Write(cStr[i]);
            }

            Console.WriteLine();
        }


        /**
         Copia el contenido de arg a cStr, cStr debe tener el tamaño suficiente para alojar arg
        
        */
        static void StringToCString(string arg, char[] cStr)
        {

            for (int i = 0; i < arg.Length; i++)
            {
                cStr[i] = arg[i];
            }

            cStr[arg.Length] = EOS;
        }

        /*
         Prueba de StringToCString 
        */
        static void Test_StringToCString()
        {
            string unaString = "Hola como estas";//Tenemos una String de C#
            char[] unaCStr = new char[34];//un array de chars con tamaño suficiente

            //Utilizamos la funcion
            StringToCString(unaString, unaCStr);

            //Mostramos en pantalla el resultado
            MostrarCStrEnConsola(unaCStr);

        }



        /**
           Crea una String de C# a partir de una CString 
        */
        static string CStringToString(char[] arg)
        {
            string rv = "";
            int i = 0;

            if (arg == null)
                return null;

            while (arg[i] != EOS)
            {
                rv += arg[i];
            }


            return rv;
        }


        // Funcion para generar CStrings para los tests
        static char[][] GenerateTestCStrings()
        {
            string str1 = "Hola amigo";
            string str2 = " como estas?  mas chars \0 AHSDJAKN";

            char[] cStr1 = new char[25];
            char[] cStr2 = new char[40];

            StringToCString(str1, cStr1);
            MostrarCStrEnConsola(cStr1);

            StringToCString(str2, cStr2);
            MostrarCStrEnConsola(cStr2);

            char[][] cStrings = { cStr1, cStr2 };
            return cStrings;
        }

        // Overload que permite pasar las strings que quieres usar
        static char[][] GenerateTestCStrings(string string1, string string2)
        {
            char[] cStr1 = new char[25];
            char[] cStr2 = new char[40];

            StringToCString(string1, cStr1);
            MostrarCStrEnConsola(cStr1);

            StringToCString(string2, cStr2);
            MostrarCStrEnConsola(cStr2);

            char[][] cStrings = { cStr1, cStr2 };
            return cStrings;
        }

        /* funcion CStringConcat(destino, origen)
            Anexa una copia de la CString "origen" al final de la CString "destino". 
            El EOS final en "destino" sera sobreescrito por el primer char de "origen" y
            se agrega un EOS al final de la nueva CString formada por la concatenacion de ambas en "destino".

            NO se debe validar que el array "destino" tenga el espacio suficiente para albergar el resultado.

            Ejemplo de parametros:
            destino: [H][o][l][a][\0][\0][\0][\0][\0][\0][\0][\0][\0][\0][\0][\0][\0][\0][\0]
            origen:  [ ][c][o][m][o][ ][e][s][t][a][s][?][\0][\0][\0]

            Ejemplo de resultado luego de la ejecucion de la funcion:
            destino: [H][o][l][a][ ][c][o][m][o][ ][e][s][t][a][s][?][\0][\0][\0]
          


            Parametros:
            *destino: Es el array destino, debe ser una CString y debe tener espacio suficiente para almacenar el resultado.
            *origen: La CString a anexar.
            
            Retorno:
            * retorna destino.
                
         */
        static char[] CStringConcat(char[] destino, char[] origen)
        {
            int lengthOrigen = CStringLength(origen);
            int eosDestino = CStringLength(destino);

            for (int i = 0; i < lengthOrigen; i++)
            {
                destino[eosDestino + i] = origen[i];
            }

            return destino;
        }

        static void Test_CStringConCat()
        {
            string str1 = "Lorem ipsum";
            string str2 = " dolor sit amet";

            char[][] exampleStrings = GenerateTestCStrings(str1, str2);
            char[] cStr1 = exampleStrings[0];
            char[] cStr2 = exampleStrings[1];

            CStringConcat(cStr1, cStr2);

            MostrarCStrEnConsola(cStr1);
        }


        /* funcion CStringNCopy(destino, origen, inicio, cant) //Notese la N
            Copia "cant" caracteres desde el elemento "inicio" de la CString origen al principio de "destino".
            Si se encuentra un EOS antes de llegar a copiar "cant" caracteres, se completara con tantos EOS como resten. 

            NO se agregaran EOS de manera implicita al final de destino si el largo de "origen" fuese mayor a "cant".
            Haciendo que, en este caso, "destino" no sea considerado una CString y por lo tanto leerlo en este estado podria resultar en overflow.

            NO se debe validar que "destino" tenga espacio suficiente para almacenar la CString a copiar.

            Ejemplo:
            destino: [H][o][l][a][\0][F][X][A][N]
            origen:  [C][u][e][l][l][o][\0][\0][\0][\0]
            inicio: 2
            cant: 4
            
            Luego de la ejecucion de la funcion:
            destino: [e][l][l][o][\0][F][X][A][N]
          

            Parametros:
            *destino: Es el array destino, debe tener espacio suficiente para almacenar al menos "cant" caracteres.
            *origen: La CString a copiar.
            *inicio: El indice por el cual se comenzara a copiar "origen". (debe ser mayor o igual a 0, caso contrario no se realizan cambios)
            *cant: la cantidad maxima de caracteres a copiar. (debe ser mayor a 0, caso contrario no se realizan cambios)

            Retorno:
            * retorna destino.
            
           
                
         */
        static char[] CStringNCopy(char[] destino, char[] origen, int inicio, int cant)
        {
            bool validNums = inicio >= 0 && cant >= 0;

            if (validNums)
            {
                int indx = 0;
                char posActual;
                while (indx < cant)
                {
                    posActual = origen[inicio + indx];

                    if (posActual != EOS)
                    {
                        destino[indx] = posActual;
                    }
                    else
                    {
                        // Si el loop se consigue un EOS antes de llegar a cant, completa a partir de ese index, todos con EOS y sale del loop 
                        for (int i = indx; i < cant; i++)
                        {
                            destino[i] = EOS;
                        }
                        break;
                    }

                    indx++;
                }
            }
            return destino;
        }


        static void Test_CStringNCopy()
        {
            char[][] exampleStrings = GenerateTestCStrings();
            char[] cStr1 = exampleStrings[0];
            char[] cStr2 = exampleStrings[1];

            CStringNCopy(cStr1, cStr2, 19, 10);

            MostrarCStrEnConsola(cStr1);
        }



        /* funcion CStringCopy(destino, origen, inicio)
            Copia en "destino" todos los caracteres hasta el primer EOS que encuentre (tambien sera copiado) de "origen" 
            comenzando a partir del caracter ubicado en la posicion "inicio".

             NO se debe validar que "destino" tenga espacio suficiente para almacenar la CString a copiar.

            Ejemplo:
            destino: [H][o][l][a][P][F][X][A][N]
            origen:  [C][u][e][l][l][o][\0][\0][\0][\0]
            inicio: 2
            
            Luego de la ejecucion de la funcion:
            destino: [e][l][l][o][\0][F][X][A][N]
          


            Parametros:
            *destino: Es el array destino.
            *origen: La CString a copiar.
            *inicio: El indice por el cual se comenzara a copiar "origen". (debe ser mayor o igual a 0, caso contrario no sufrira cambios)
            
             
            Retorno:
            * retorna destino.

        */
        static char[] CStringCopy(char[] destino, char[] origen, int inicio)
        {
            bool validNum = inicio >= 0;

            if (validNum)
            {
                int indx = 0;
                int contador = inicio;
                char posActual;
                while (contador <= CStringLength(origen))
                {
                    posActual = origen[contador];

                    destino[indx] = posActual;

                    indx++;
                    contador++;
                }
            }
            return destino;
        }

        static void Test_CStringCopy()
        {
            char[][] exampleStrings = GenerateTestCStrings();
            char[] cStr1 = exampleStrings[0];
            char[] cStr2 = exampleStrings[1];

            CStringCopy(cStr1, cStr2, 20);

            MostrarCStrEnConsola(cStr1);
        }

        /* funcion CStringCompare(arg1, arg2)
            Compara los caracteres de la CString "arg1" con los de la CString "arg2".

            Esta funcion comienza a comparar a partir del primer caracter de las CStrings arg1 y arg2. Si son iguales, 
            continua con el siguiente hasta que alguno difiera o
            se haya alcanzado un EOS(Se debe comparar tambien) lo que suceda primero.


            Parametros:
            *arg1: La primer CString a comparar.
            *arg2: La segunda CString a comparar.
           

            Retorno:
            * un valor menor a 0 si el primer caracter que difiere tiene en arg1 un valor menor que en arg2.
            * 0 si todos los caracteres comparados son iguales.
            * un valor mayor a 0 si el primer caracter que difiere tiene en arg1 un valor mayor que en arg2.

            Recuerde: se pueden restar chars, en el return va a tener que castear a int. 

       
        */
        static int CStringCompare(char[] arg1, char[] arg2)
        {
            int comp = EOS;
            for (int i = 0; i <= CStringLength(arg1); i++)
            {
                for (int j = 0; j <= CStringLength(arg2); j++)
                {
                    if (i == j)
                    {
                        if (arg1[i] != arg2[j])
                        {
                            comp = arg1[i] - arg2[j];

                            // Ya conseguimos una diferencia, asi que damos condiciones finales a los loops para salir
                            j = CStringLength(arg2) + 1;
                            i = CStringLength(arg1) + 1;
                        }
                    }
                }
            }

            int return_value = 0;
            if (comp < 0)
            {
                return_value = -1;
            }
            else if (comp > 0)
            {
                return_value = 1;
            }

            return return_value;
        }

        static void Test_CStringCompare()
        {
            char[][] exampleStrings = GenerateTestCStrings("hola amigo ", "hola amigos ");
            char[] cStr1 = exampleStrings[0];
            char[] cStr2 = exampleStrings[1];

            int compare = CStringCompare(cStr1, cStr2);

            Console.Write(compare);
        }

        /* funcion CStringNCompare(arg1, arg2, cant) //Notese la N
            Compara hasta "cant" caracteres de la CString arg1 con los de la CString arg2.
            
            Esta funcion comienza a comparar el primer caracter de ambas CStrings. Si son iguales, 
            continua con el siguiente hasta que alguno difiera, 
            se haya alcanzado un EOS(Se debe comparar tambien), o hasta que "cant" caracteres sean iguales en ambas CStrings, lo que suceda primero.
            

            Parametros:
            *arg1: La primer CString a comparar.
            *arg2: La segunda CString a comparar.
            *cant: La cantidad de caracteres a comparar (debe ser mayor a 0)
            
             
            Retorno:
            * un valor menor a 0 si el primer caracter que difiere tiene en arg1 un valor menor que en arg2.
            * 0 si todos los caracteres comparados son iguales.
            * un valor mayor a 0 si el primer caracter que difiere tiene en arg1 un valor mayor que en arg2.
            
            Recuerde: se pueden restar chars.

           
        */
        static int CStringNCompare(char[] arg1, char[] arg2, int cant)
        {
            int comp = EOS;
            for (int i = 0; i < cant; i++)
            {
                for (int j = 0; j < cant; j++)
                {
                    if (i == j)
                    {
                        if (arg1[i] != arg2[j])
                        {
                            comp = arg1[i] - arg2[j];

                            // Ya conseguimos una diferencia, asi que damos condiciones finales a los loops para salir
                            j = cant;
                            i = cant;
                        }
                    }
                }
            }

            int return_value = 0;
            if (comp < 0)
            {
                return_value = -1;
            }
            else if (comp > 0)
            {
                return_value = 1;
            }

            return return_value;
        }

        static void Test_CStringNCompare()
        {
            char[][] exampleStrings = GenerateTestCStrings("hola amigo como estas", "hola amigos como estan");
            char[] cStr1 = exampleStrings[0];
            char[] cStr2 = exampleStrings[1];

            int compare = CStringNCompare(cStr1, cStr2, 12);

            Console.Write(compare);
        }


        /* funcion CStringFindAnyChar(str1, bindx, str2)
           Retorna el indice de la primer ocurrencia en "str1" de cualquiera de 
           los caracteres que forman parte de "str2" o -1 si no hay ocurrencias.
           La busqueda comienza a partir de "bindex" en "str1".

            La busqueda no incluye el EOS pero termina ahi.

            Parametros:
            *str1: La CString donde buscar.
            *bindx: El indice a partir del cual se comenzar a buscar en str1
            *str2: La CString que contendra la lista de char que vamos buscar (debe contener al menos 1 char y finalizar con EOS).
           
             
            Retorno:
            *El indice de str1 donde se encontro la primer ocurrencia o -1 si no se encontro ninguna.
            *-2 si no se supera alguna validacion.



        
        */
        static int CStringFindAnyChar(char[] str1, char[] str2, int bindx)
        {
            int return_value = -1;

            if (CStringLength(str2) >= 1 && str2[CStringLength(str2)] == EOS)
            {
                for (int i = 0; i < CStringLength(str2); i++)
                {
                    for (int j = bindx; j < CStringLength(str1); j++)
                    {
                        if (str1[j] == str2[i])
                        {
                            return_value = j;

                            // Ya conseguimos una ocurrencia, asi que damos condiciones finales a los loops para salir
                            j = CStringLength(str1);
                            i = CStringLength(str2);
                        }
                    }
                }
            }
            else
            {
                return_value = -2;
            }

            return return_value;
        }

        static void Test_CStringFindAnyChar()
        {
            char[][] exampleStrings = GenerateTestCStrings("hola", "a");
            char[] cStr1 = exampleStrings[0];
            char[] cStr2 = exampleStrings[1];

            int index = CStringFindAnyChar(cStr1, cStr2, 1);

            Console.Write(index);
        }

        /* funcion CStringFindChar(unaStr, bindx, unChar)
                  Retorna el indice de la primer ocurrencia de "unChar" en "unaStr" o -1 si no hay ocurrencias.

                   El EOS se considera un char valido y parte de la string por lo cual puede ser buscado.

                   Parametros:
                   *unaStr: La CString donde buscar.
                   *bindx: El indice a partir del cual se comenzar a buscar en unaStr
                   *unChar: El char que queremos buscar.


                   Retorno:
                   *El indice de unaStr donde se encontro la primer ocurrencia o -1 si no se encontro ninguna.
                   
       
                        
               */
        static int CStringFindChar(char[] unaStr, int bindx, char unChar)
        {
            int return_value = -1;

            for (int i = bindx; i <= CStringLength(unaStr); i++)
            {
                if (unaStr[i] == unChar)
                {
                    return_value = i;

                    // Ya conseguimos una ocurrencia, asi que damos condicion final al loop para salir
                    i = CStringLength(unaStr) + 1;
                }
            }

            return return_value;
        }

        static void Test_CStringFindChar()
        {
            string str1 = "Amaterasu";
            char[] cStr1 = new char[20];
            StringToCString(str1, cStr1);

            int index = CStringFindChar(cStr1, 3, 'a');

            Console.Write(index);
        }

        /* funcion CStringReverseFindChar(unaStr, bindx, unChar)
            Retorna el indice de la ULTIMA ocurrencia de unChar en "unaStr" o -1 si no hay ocurrencias.

             El EOS se considera un char valido y parte de la string por lo cual puede ser buscado.
             
            

             Parametros:
             *unaStr: La CString donde buscar.
             *bindx: El indice a partir del cual se comenzar a buscar en unaStr
             *unChar: El char que queremos buscar.


             Retorno:
             *El indice de unaStr donde se encontro la ULTIMA ocurrencia o -1 si no se encontro ninguna.
             


         */



        /* funcion CStringFindCString(str1, bindx, str2)
            Retorna el indice de la primer ocurrencia de "str2" en "str1" o -1 si no hay ocurrencias.
            
             Parametros:
             *str1: La CString donde buscar.
             *bindx: El indice a partir del cual se comenzar a buscar en str1
             *str2: La CString que queremos buscar.


             Retorno:
             *El indice de str1 donde se encontro la primer ocurrencia o -1 si no se encontro ninguna.



        */



        /* funcion EsEspacio(unChar)
           Valida si "unChar" es un espacio en blanco.
           Decimos que "unChar" es un espacion en blanco si es alguno de estos:
           ' '	space (SPC)
           '\t'	horizontal tab (TAB)
           '\n'	newline (LF)
           '\v'	vertical tab (VT)
           '\f'	feed (FF)
           '\r'	carriage return (CR)


            Parametros:
            *unChar: El char a ser chequeado.

            Retorno:
            *true si es alguno de los valores listados, de lo contrario falso.


       */



        /* funcion EsDigito(unChar)
            Valida si "unChar" es un digito decimal: '0' '1' '2' '3' '4' '5' '6' '7' '8' '9'
            
             Parametros:
             *unChar: El char a ser chequeado.
           
             Retorno:
             *true si es alguno de los valores listados, de lo contrario falso.



          */



        /* funcion CStringToInt(str)
            Parsea la CString "str" interpretando su contenido como un numero entero que es retornado como un valor del tipo int.
            La funcion primero descarta tantos caracteres considerados espacios en blanco (segun la funcion EsEspacio) como sean necesarios
            hasta encontrar el primer caracter que no sea espacio.
            Luego, comenzando desde este caracter, puede haber un signo + o - seguido de tantos digitos en base-10 como sean posibles y los interpreta
            como un valor numerico.
            
            Si la primer secuencia de caracteres que no son espacio no forman un entero valido o si no existe una secuencia, porque "str" esta vacio 
            o solo contiene espacios en blanco, no se realiza ninguna conversion y se retornara cero (0).

      
             Parametros:
             *str: La CString a parsear.

             Retorno:
             *El valor de la CString interpretado como int o 0 si no se pudo realizar el parseo.


        */


        public static void Main(string[] args)
        {
            //Test_StringToCString();

            //Test_CStringConCat();
            //Test_CStringNCopy();
            //Test_CStringCopy();
            //Test_CStringCompare();
            //Test_CStringNCompare();
            //Test_CStringFindAnyChar();
            Test_CStringFindChar();

            Console.ReadLine();

        }
    }
}
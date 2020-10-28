using System;
using System.Collections.Generic;
using ATM_Machine.Lib;

namespace ATM_Machine
{
    class Program
    {
        static readonly string[] MENU_PRINCIPAL_OPTS = new string[] { "0- Retirar dinero",
                                                                        "1- Transferir dinero",
                                                                        "2- Ver CBU",
                                                                        "3- Cambiar clave",
                                                                        "4- Salir"
                                                                        };


        const string MSG_INPUT_CAJA_CBU = "Seleccione caja de ahorro para ver CBU:";
        const string MSG_INFO_CBU_FMT_MONISO_CANRO_CBU = "El CBU de la caja de ahorro {0} - {1} es: \n {2}";
        const string MSG_PRESIONE_ENTER = "Presione ENTER para continuar.";
        const string MSG_INPUT_CLAVE_ACTUAL = "Ingrese clave actual:";
        const string MSG_INPUT_CLAVE_NUEVA = "Ingrese clave nueva:";
        const string MSG_INPUT_CLAVE_NUEVA_REP = "Repita clave nueva:";
        const string MSG_CLAVE_INVALIDA = "Clave invalida";
        const string MSG_CLAVE_NUEVA_DIFERENTE = "Las claves difieren.";
        const string MSG_INPUT_NRO_TARJETA = "Numero de Tarjeta de Debito";
        const string MSG_INPUT_CLAVE = "Clave:";
        const string MSG_TARJETA_INVALIDA = "Tarjeta invalida";
        const string MSG_INPUT_CAJA_TX_ORIGEN = "Seleccione caja de ahorro Origen:";
        const string MSG_INPUT_CAJA_TX_DESTINO = "Seleccione caja de ahorro Destino:";
        const string MSG_INPUT_MONTO_TX = "Ingrese el monto a transferir (0 para cancelar)";
        const string MSG_RETIRO_ARS_EXITOSO_FMT_M = "Retiro exitoso, usted retiró {0} ARS";
        const string MSG_TARJETA_INACTIVA = "Tarjeta Inactiva!";
        const string MSG_INPUT_CAJA_RETIRO = "Seleccione caja de ahorro:";
        const string MSG_MTO_RETIRAR_FMT_MONISO_CANRO_CABAL_CADES = "Cuanto desea retirar de la caja de ahorro {0} - {1}? (Fondos: ${2} Descubierto: ${3})";
        const string MSG_INPUT_MONTO_RETIRO = "Ingrese el monto (0 para cancelar):";
        const string MSG_CAJA_DE_AHORRO_SIN_FONDO = "Caja de ahorro sin fondos.";
        const string MSG_CAJERO_SIN_FONDO = "Cajero sin fondos.";
        const string MSG_BIENVENIDA = "Bienvenido";

        const int INPUT_NRO_TARJETA_LEN = 16;
        const int INPUT_CLAVE_LEN = 4;
        const int MAX_INTENTOS_INVALIDOS = 3;


        const int MENU_PRINCIPAL_OPT_RETIRO = 0;
        const int MENU_PRINCIPAL_OPT_TX = 1;
        const int MENU_PRINCIPAL_OPT_VERCBU = 2;
        const int MENU_PRINCIPAL_OPT_CMB_CLAVE = 3;
        const int MENU_PRINCIPAL_OPT_SALIR = 4;

        static void ShowMessage(string message, ConsoleColor color)
        {
            Console.Clear();
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

            Console.WriteLine("\nPress Enter to return");
            Console.ReadLine();
        }

        static bool IsValidOption(int minValue, int maxValue, int option, string message)
        {
            if (option < minValue || option > maxValue)
            {
                ShowMessage(message, ConsoleColor.Red);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int ValidateOption(string[] menuOptions, int minValue, int maxValue)
        {
            int maxAttempts = 3;
            int failedAttempts = 0;

            bool validOption = false;
            bool isNum = false;

            int option = 0;

            while (!validOption || !isNum)
            {
                if (failedAttempts == maxAttempts)
                {
                    ShowMessage("You ran out of attempts, exiting the game.", ConsoleColor.Red);
                    return 0;
                }

                Console.Clear();
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    Console.WriteLine(menuOptions[i]);
                }

                isNum = int.TryParse(Console.ReadLine(), out option);

                if (isNum)
                {
                    validOption = IsValidOption(minValue, maxValue, option, $"Invalid option.\nYou have {maxAttempts - ++failedAttempts} attempts left.");
                }
                else
                {
                    ShowMessage($"Invalid option.\nYou have {maxAttempts - ++failedAttempts} attempts left.", ConsoleColor.Red);
                }
            }

            return option;
        }


        static TarjetaDebito MostrarPantallaBienvenida(CajeroAutomaticoDB cajero)
        {
            bool datosValidos = false;
            int intentosFallidos = 0;

            TarjetaDebito testTarjeta = new TarjetaDebito();

            while (!datosValidos)
            {
                Console.Write("Ingrese numero de tarjeta: ");
                string numeroTarjeta = Console.ReadLine();

                Console.Write("Ingrese clave: ");
                string clave = Console.ReadLine();

                testTarjeta = cajero.BuscarTarjeta(numeroTarjeta);

                if (intentosFallidos == 3 && testTarjeta != null)
                {
                    testTarjeta.Activa = false;
                    Console.WriteLine("Superaste la cantidad de intentos, tarjeta inhabilitada.");
                    intentosFallidos = 0;
                }

                if (testTarjeta == null)
                {
                    Console.WriteLine("Clave invalida.");
                    intentosFallidos++;
                }

                if (clave == testTarjeta.Clave && !testTarjeta.Activa)
                {
                    Console.WriteLine("Tarjeta invalida.");
                }

                if (testTarjeta != null && clave == testTarjeta.Clave)
                {
                    datosValidos = true;
                }
            }

            return testTarjeta;
        }

        static void MostrarPantallaPrincipal(TarjetaDebito tarjeta)
        {
            int option = ValidateOption(MENU_PRINCIPAL_OPTS, 1, 5);

            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }

        static void Main(string[] args)
        {
            CajeroAutomaticoDB test = new CajeroAutomaticoDB();

            TarjetaDebito tarjeta = MostrarPantallaBienvenida(test);


        }


    }
}
using System;
using System.Collections.Generic;
using ATM_Machine.Lib;

namespace ATM_Machine
{
    class Program
    {
        static readonly string[] MENU_PRINCIPAL_OPTS = new string[] { "Retirar dinero",
                                                                        "Transferir dinero",
                                                                        "Ver CBU",
                                                                        "Cambiar clave",
                                                                        "Salir"
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


        //Datos
        static bool EsStringNumerica(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }


        //Vista
        static int PedirValorInt(string mensaje)
        {
            int rv = 0;

            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out rv))
            {
                Console.WriteLine("Valor invalido.");
                Console.Write(mensaje);
            }
            return rv;
        }

        static decimal PedirValorDecimal(string mensaje)
        {
            decimal rv = 0;

            Console.Write(mensaje);
            while (!decimal.TryParse(Console.ReadLine(), out rv))
            {
                Console.WriteLine("Valor invalido.");
                Console.Write(mensaje);
            }
            return rv;
        }




        //Vista
        static int PedirValorIntClampeado(string mensaje, int cotaInferior, int cotaSuperior)
        {
            int rv = PedirValorInt(mensaje);

            while (rv < cotaInferior || rv > cotaSuperior)
            {
                Console.WriteLine("Valor invalido.");
                rv = PedirValorInt(mensaje);
            }

            return rv;
        }

        static decimal PedirValorDecimalClampeado(string mensaje, decimal cotaInferior, decimal cotaSuperior)
        {
            decimal rv = PedirValorDecimal(mensaje);

            while (rv < cotaInferior || rv > cotaSuperior)
            {
                Console.WriteLine("Valor invalido.");
                rv = PedirValorInt(mensaje);
            }

            return rv;
        }

        //Vista
        static string PedirStringDeLargo(string mensaje, int largo)
        {
            string rv = "";

            Console.Write(mensaje);
            while ((rv = Console.ReadLine()).Length != largo)
            {
                Console.WriteLine($"Valor invalido, el largo debe ser de [{largo}].");
                Console.Write(mensaje);
            }
            return rv;
        }



        //Vista
        static string PedirStringNumerica(string mensaje, int largo)
        {
            string rv = PedirStringDeLargo(mensaje, largo);

            while (!EsStringNumerica(rv))
            {
                rv = PedirStringDeLargo(mensaje, largo);
            }

            return rv;
        }

        //Vista
        static int MostrarMenu(string titulo, string[] opciones)
        {
            int eleccion = -1;

            Console.WriteLine($"{titulo}");

            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine($"{i} - {opciones[i]}");
            }

            eleccion = PedirValorIntClampeado("Su eleccion:", 0, opciones.Length - 1);

            return eleccion;
        }

        //Vista
        static CajaDeAhorro MostrarPantallaSeleccionCaja(string titulo, List<CajaDeAhorro> cajas)
        {
            int eleccion = -1;

            Console.WriteLine($"{titulo}");

            for (int i = 0; i < cajas.Count; i++)
            {
                CajaDeAhorro caja = cajas[i];
                Console.WriteLine($"{i} - {caja.Moneda.CodigoISO} - {caja.Nro} (${caja.Balance}) (${caja.Descubierto})");
            }
            Console.WriteLine($"{cajas.Count} - Cancelar");
            eleccion = PedirValorIntClampeado("Su eleccion:", 0, cajas.Count);

            if (eleccion == cajas.Count)
                return null;

            return cajas[eleccion];
        }



        //Vista
        static TarjetaDebito MostrarPantallaDeBienvenida(CajeroAutomaticoDB cajero)
        {
            string nroTarjeta = PedirStringNumerica(MSG_INPUT_NRO_TARJETA, INPUT_NRO_TARJETA_LEN);
            string clave = PedirStringNumerica(MSG_INPUT_CLAVE, INPUT_CLAVE_LEN);

            TarjetaDebito tarjeta = CajeroAutomatico_BuscarTarjeta(cajero, nroTarjeta);

            //No encontre la tarjeta
            if (tarjeta == null)
            {
                Console.WriteLine(MSG_TARJETA_INVALIDA);
                return null;
            }
            else
            {
                //La encontre, valido la clave.
                int intentosInvalidos = 0;
                while (tarjeta.Clave != clave && intentosInvalidos < MAX_INTENTOS_INVALIDOS)
                {
                    intentosInvalidos++;
                    Console.WriteLine(MSG_TARJETA_INVALIDA);
                    clave = PedirStringNumerica(MSG_INPUT_CLAVE, INPUT_CLAVE_LEN);
                }
                //Si llego al maximo de intentos, la desactivo.
                if (intentosInvalidos == MAX_INTENTOS_INVALIDOS)
                {
                    TarjetaDebito_Desactivar(tarjeta);
                    return null;
                }

                if (tarjeta.FechaVencimiento < DateTime.Now || !tarjeta.Activa)
                {
                    Console.WriteLine(MSG_TARJETA_INVALIDA);
                    return null;
                }
            }


            if (!tarjeta.Activa)
            {
                Console.WriteLine(MSG_TARJETA_INACTIVA);
                return null;
            }


            return tarjeta;
        }


        //Vista
        static void MostrarPantallaDeRetiro(CajeroAutomaticoDB cajero, List<CajaDeAhorro> cajasDeAhorro)
        {

            CajaDeAhorro caja = null;
            decimal monto = 0;
            decimal montoEnARS = 0;


            if (cajero == null)
                throw new ArgumentNullException("cajero");
            if (cajasDeAhorro == null)
                throw new ArgumentNullException("cajasDeAhorro");


            caja = MostrarPantallaSeleccionCaja(MSG_INPUT_CAJA_RETIRO, cajasDeAhorro);

            if (caja == null) //Eligio cancelar
                return;


            Console.WriteLine(MSG_MTO_RETIRAR_FMT_MONISO_CANRO_CABAL_CADES, caja.Moneda.CodigoISO, caja.Nro, caja.Balance, caja.Descubierto);

            monto = PedirValorDecimalClampeado(MSG_INPUT_MONTO_RETIRO, 0, decimal.MaxValue);
            montoEnARS = Moneda_ConvertirMontoAARS(caja.Moneda, monto);

            //si el monto es 0, tiene que cancelar
            if (monto == 0)
                return;

            if (!CajaDeAhorro_PuedeExtraer(caja, monto))
            {
                Console.WriteLine(MSG_CAJA_DE_AHORRO_SIN_FONDO);
                return;
            }

            if (!CajeroAutomatico_PuedeRetirar(cajero, montoEnARS))
            {
                Console.WriteLine(MSG_CAJERO_SIN_FONDO);
                return;

            }


            CajaDeAhorro_Extraer(caja, monto);
            CajeroAutomatico_RealizarRetiro(cajero, montoEnARS);
            Console.WriteLine(MSG_RETIRO_ARS_EXITOSO_FMT_M, montoEnARS);
        }

        //Vista
        static void MostrarPantallaDeTransferencia(List<CajaDeAhorro> cajasDeAhorro)
        {
            CajaDeAhorro cajaOrigen = null;
            CajaDeAhorro cajaDestino = null;


            cajaOrigen = MostrarPantallaSeleccionCaja(MSG_INPUT_CAJA_TX_ORIGEN, cajasDeAhorro);

            //Si elige cancelar, termino la funcion.
            if (cajaOrigen == null)
                return;

            cajaDestino = MostrarPantallaSeleccionCaja(MSG_INPUT_CAJA_TX_DESTINO, cajasDeAhorro);
            //Si elige cancelar, termino la funcion.
            if (cajaDestino == null)
                return;

            decimal monto = PedirValorDecimalClampeado(MSG_INPUT_MONTO_TX, 0, decimal.MaxValue);

            if (monto == 0)
                return;

            if (!CajaDeAhorro_PuedeExtraer(cajaOrigen, monto))
            {
                Console.WriteLine(MSG_CAJA_DE_AHORRO_SIN_FONDO);
                return;
            }

            CajaDeAhorro_Transferir(cajaOrigen, cajaDestino, monto);

        }

        //Vista
        static void MostrarPantallaDeVistaCBU(List<CajaDeAhorro> cajasDeAhorro)
        {
            CajaDeAhorro caja = null;

            caja = MostrarPantallaSeleccionCaja(MSG_INPUT_CAJA_CBU, cajasDeAhorro);

            if (caja == null)
                return;
            Console.WriteLine(MSG_INFO_CBU_FMT_MONISO_CANRO_CBU, caja.Moneda.CodigoISO, caja.Nro, caja.CBU);
            Console.WriteLine(MSG_PRESIONE_ENTER);
            Console.ReadLine();
        }

        //Vista
        static void MostrarPantallaDeCambioDeClave(TarjetaDebito tarjeta)
        {

            string claveActual = PedirStringNumerica(MSG_INPUT_CLAVE_ACTUAL, INPUT_CLAVE_LEN);
            string nuevaClave = PedirStringNumerica(MSG_INPUT_CLAVE_NUEVA, INPUT_CLAVE_LEN);
            string nuevaClaveRepetida = PedirStringNumerica(MSG_INPUT_CLAVE_NUEVA_REP, INPUT_CLAVE_LEN);

            if (claveActual != tarjeta.Clave)
            {
                Console.WriteLine(MSG_CLAVE_INVALIDA);
                return;
            }

            if (nuevaClave != nuevaClaveRepetida)
            {
                Console.WriteLine(MSG_CLAVE_NUEVA_DIFERENTE);
                return;
            }

            if (nuevaClave == claveActual)
            {
                Console.WriteLine(MSG_CLAVE_INVALIDA);
                return;
            }

            //Hago el cambiaso.
            tarjeta.Clave = nuevaClave;
        }

        //Vista
        static void MostrarPantallaPrincipal(CajeroAutomaticoDB cajero, TarjetaDebito td)
        {
            int opt = 0;
            Cliente cliente = td.Cliente;


            while ((opt = MostrarMenu($"{MSG_BIENVENIDA} {cliente.Nombre} {cliente.Apellido}", MENU_PRINCIPAL_OPTS)) != MENU_PRINCIPAL_OPT_SALIR)
            {
                switch (opt)
                {
                    case MENU_PRINCIPAL_OPT_RETIRO:
                        MostrarPantallaDeRetiro(cajero, cliente.CajasDeAhorro);
                        break;
                    case MENU_PRINCIPAL_OPT_TX:
                        MostrarPantallaDeTransferencia(cliente.CajasDeAhorro);
                        break;
                    case MENU_PRINCIPAL_OPT_VERCBU:
                        MostrarPantallaDeVistaCBU(cliente.CajasDeAhorro);
                        break;
                    case MENU_PRINCIPAL_OPT_CMB_CLAVE:
                        MostrarPantallaDeCambioDeClave(td);
                        break;
                }
            }

        }

        static void Main(string[] args)
        {

            CajeroAutomaticoDB cajero = new CajeroAutomaticoDB();

            CajeroAutomatico_CargarDatosPrueba(cajero);

            while (true)
            {
                TarjetaDebito td = MostrarPantallaDeBienvenida(cajero);

                if (td != null)
                {
                    MostrarPantallaPrincipal(cajero, td);
                }
            }
        }


    }
}
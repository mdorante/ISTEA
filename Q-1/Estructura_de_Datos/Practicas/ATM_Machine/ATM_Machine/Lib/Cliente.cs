using System;
using System.Collections.Generic;

namespace ATM_Machine.Lib
{
    public class Cliente
    {
        public string Nombre;
        public string Apellido;
        public string DNI;
        public long NumeroCliente;
        public List<CajaDeAhorro> CajasDeAhorro = new List<CajaDeAhorro>();
    }
}

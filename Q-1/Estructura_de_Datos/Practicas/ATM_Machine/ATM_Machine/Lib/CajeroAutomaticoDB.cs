using System;
using System.Collections.Generic;

namespace ATM_Machine.Lib
{
    public class CajeroAutomaticoDB
    {
        public List<TarjetaDebito> Tarjetas = new List<TarjetaDebito>();
        public decimal FondosEnARS;

        public CajeroAutomaticoDB()
        {
            this.Tarjetas = new List<TarjetaDebito>();
            this.FondosEnARS = (decimal)0.0;
        }

        public TarjetaDebito BuscarTarjeta(string numeroTarjeta)
        {
            for (int i = 0; i < Tarjetas.Count; i++)
            {
                if (Tarjetas[i].Numero == numeroTarjeta)
                {
                    return Tarjetas[i];
                }
            }

            return null;
        }
    }
}

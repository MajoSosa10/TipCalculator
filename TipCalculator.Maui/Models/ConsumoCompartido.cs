using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator.Maui.Models
{
    public class ConsumoCompartido
    {
        //propiedades necesarias para hacer los cálculos
        public decimal ImporteDelConsumo { get; set; }
        public int NumeroDePersonas { get; set; }
        public decimal PorcentajeDePropina {  get; set; }

        //propiedades que guardan los cálculos resultantes
        public decimal ImporteDelConsumoPorPersona => ImporteDelConsumo / NumeroDePersonas;
        public decimal ImporteDeLaPropina => ImporteDelConsumo * PorcentajeDePropina / 100.0m; //m para convertir a decimal
        public decimal ImporteDeLaPropinaPorPersona => ImporteDelConsumoPorPersona / NumeroDePersonas;
        public decimal ImporteTotalCorPropina => ImporteDelConsumo + ImporteDeLaPropina;
        public decimal ImporteTotalConPropinaPorPersona => ImporteDeLaPropina / NumeroDePersonas;
        public ConsumoCompartido(decimal importeDeConsumo, int numeroDePersonas, decimal porcentajeDePropina)
        {
            ImporteDelConsumo = importeDeConsumo;
            NumeroDePersonas = numeroDePersonas;
            PorcentajeDePropina = porcentajeDePropina;
        }
    }
}

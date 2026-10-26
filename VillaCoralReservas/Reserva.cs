using System;
using System.Collections.Generic;
using System.Text;

namespace VillaCoralReservas
{
   public class Reserva
    {
        public string Codigo { get; set; } = "";
        public string Cliente { get; set; } = "";
        public string Tipo { get; set; } = "";
        public DateTime Entrada { get; set; }
        public int Noches { get; set; }
        public int Huespedes { get; set; }
        public decimal Total { get; set; }

        // Lo que se ve cuando la reserva aparece en el ListBox
        public override string ToString()
        {
            return $"{Codigo} | {Cliente} | {Tipo} | {Entrada:dd/MM/yyyy} | {Noches} noches | US$ {Total:N2}";
        }

    }
}

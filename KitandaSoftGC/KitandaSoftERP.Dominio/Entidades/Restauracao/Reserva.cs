using KitandaSoftERP.Dominio.Entidades.Geral;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Restauracao
{
    public class Reserva 
    {
        public int Codigo { get; set; }
        public string Referencia { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public DateTime HoraTermino { get; set; }
        public Entidade Cliente { get; set; }
        public int CustomerID { get; set; }
        public string Mesa { get; set; }
        public string BookingStatus { get; set; }
        public int Ocupantes { get; set; }
        public string Tipo { get; set; }
        public string Notas { get; set; }
    }
}

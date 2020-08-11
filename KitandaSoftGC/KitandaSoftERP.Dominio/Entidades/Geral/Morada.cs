using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Morada
    {
        public int Codigo { get; set; }
        public string NumeroEdificio { get; set; }
        public string NumeroApartamento { get; set; }
        public string Centralidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Municipio { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
    }
}

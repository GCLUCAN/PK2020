using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Evento
    {
        public int EventoID { get; set; }
        public string NomeEvento { get; set; }
        public string DataEvento { get; set; }
        public string DetalheEvento{ get; set; }
    }
}

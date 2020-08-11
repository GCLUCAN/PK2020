using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Contacto : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Telefone { get; set; }
        public string TelefoneAlt { get; set; }
        public string TelefoneFax { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Tipo { get; set; }
        public string IsPrincial{get;set;}
    }
}

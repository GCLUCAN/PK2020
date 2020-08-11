using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class EntidadeDocumentacao : Retorno.Retorno
    {
        
        public int Codigo{get; set;}
        public string NomeEntidade { get; set; }
        public int Documento{get; set;}
        public string NomeDocumento{get; set;}
        public string Numero{ get;set;}
        public DateTime Emissao {get;set;}
        public DateTime Validade{get;set;}
        public string LocalEmissao{ get; set; }
    }
}

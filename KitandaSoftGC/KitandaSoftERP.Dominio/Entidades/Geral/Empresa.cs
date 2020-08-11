using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Empresa : Entidade
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public Empresa()
        {

        }
        public Empresa(int pCodigo)
        {
            Codigo = pCodigo;
        }
        public int ProvinciaMorada { get; set; }
    }
}

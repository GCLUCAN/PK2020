using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Geral
{
    public class Tecnico : Retorno.Retorno
    {
        public Tecnico()
        {

        }
        public Tecnico(string pNome, string pFilial)
        {
            Entity = new Entidade(pNome);
            Filial = pFilial;
        }
        public int ProfissionalID { get; set; }
        public Entidade Entity { get; set; }
        public int Comissao { get; set; }
        public decimal ValorComissao { get; set; }
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public string Tipo { get; set; }
        public string PINCode { get; set; }

    }
}

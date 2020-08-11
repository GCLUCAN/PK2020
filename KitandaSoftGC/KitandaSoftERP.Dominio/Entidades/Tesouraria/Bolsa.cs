using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Bolsa : Retorno.TabelaGeral
    {
        public DateTime Inicio { get; set; }

        public DateTime Termino { get; set; }

        public Bolsa()
        {
            Codigo = 0;
            Descricao = "";
            Inicio = DateTime.MinValue;
            Termino = DateTime.MinValue;
            CompanyID = "-1";
            Entidade = -1;
            DadosEntidade = "-1";
        }

        public Bolsa(string pCodigo)
        {
            Codigo = Convert.ToInt32(pCodigo);
        }

       
        public string Criterio { get; set; }
        public int Quantidade { get; set; }
        public bool RemovedIfLate { get; set; }
    }
}

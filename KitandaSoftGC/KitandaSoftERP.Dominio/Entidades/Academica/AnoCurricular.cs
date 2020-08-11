using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class AnoCurricular : Retorno.Retorno
    {
        public AnoCurricular(int pCodigo, Ramo pRamo, int pAnoCurricular, string pDescricao, string pTipo)
        {
            this.AnoCurricular = pAnoCurricular;
            this.Ramo = pRamo;
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
            this.Tipo = pTipo;
        }

        public AnoCurricular()
        {

        }

        public AnoCurricular(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public AnoCurricular(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }
        public Ramo Ramo { get; set; }
        public int AnoCurricular { get; set; }
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string DataLimite { get; set; }
        public int Inicio { get; set; }
        public int Final { get; set; }
        public int TurmaID { get; set; }
        public int Idade { get; set; }
        public bool IsNotaEstagioRequired { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.RecursosHumanos
{
    public class GrupoSalarial : Retorno.TabelaGeral
    {
        public int Moeda { get; set; }
        public string SiglaMoeda { get; set; }
        public double SalarioBase { get; set; }
        public GrupoSalarial()
        {

        }

        public GrupoSalarial(int pCodigo)
        {
            Codigo = pCodigo;
        }

        public GrupoSalarial(int pCodigo, string pDescricao)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
        }

        public GrupoSalarial(int pCodigo, string pDescricao, string pSigla)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
        }

        public GrupoSalarial(int pCodigo, int pMoeda)
        {
            Codigo = pCodigo;
            Moeda = pMoeda;
        }

        public GrupoSalarial(string pDescricao, int pMoeda)
        {
            Descricao = pDescricao;
            Moeda = pMoeda;
        }


        public GrupoSalarial(int pCodigo, string pDescricao, string pSigla, int pEstado)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
        }

        public GrupoSalarial(int pCodigo, string pDescricao, string pSigla, int pEstado, double pSalario, int pMoeda)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            SalarioBase = pSalario;
            Moeda = pMoeda;
        }

        public GrupoSalarial(int pCodigo, string pDescricao, string pSigla, int pEstado, int pMoeda, string pSiglaMoeda, double pSalario)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Sigla = pSigla;
            Estado = pEstado;
            Moeda = pMoeda;
            SiglaMoeda = pSiglaMoeda;
            SalarioBase = pSalario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Mensalidade
    {
        public Mensalidade()
        {

        }

        public Mensalidade(string pMensalidade, int pAnoLectivo)
        {
            Codigo = Convert.ToInt32(pMensalidade);
            AnoLectivo = pAnoLectivo;
        }

        public Mensalidade(int pMensalidade)
        {
            Codigo = pMensalidade;
        }

        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public int Dia { get; set; }

        public string Inicio { get; set; }

        public string Termino { get; set; }
        public String Tipo { get; set; }
        public string ModoCobranca { get; set; }

        public string ModalidadePagto { get; set; }

        public string InicioCobranca { get; set; }

        public string CobrancaPrimeiroMes { get; set; }

        public string MultaPrimeiroMes { get; set; }

        public string MultaUltimoMes { get; set; }

        public string MultaInscricao { get; set; }

        public Mensalidade(int pCodigo, string pDescricao, int pDia, string pInicio, string pTermino, string pTipo, int pFilial)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Dia = pDia;
            Inicio = pInicio;
            Termino = pTermino;
            Tipo = pTipo;
            CompanyID = pFilial.ToString();
        }

        public Mensalidade(int pCodigo, string pDescricao, int pDia, string pInicio, string pTermino, string pTipo, decimal pPreco, string pModalidade, int pAnoLectivo, int pEntityID, bool pIsExternal)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Dia = pDia;
            Inicio = pInicio;
            Termino = pTermino;
            Tipo = pTipo;
            Preco = pPreco;
            ModalidadePagto = pModalidade;
            AnoLectivo = pAnoLectivo;
            ExternalEntity = pEntityID;
            IsExternaItem = pIsExternal;
        }

        public Mensalidade(int pCodigo, string pDescricao, string pTipo)
        {
            Codigo = pCodigo;
            Descricao = pDescricao;
            Tipo = pTipo;
        }

        public Decimal Preco { get; set; }

        public int ExternalEntity { get; set; }

        public bool IsExternaItem { get; set; }
        public int PaymentPriority { get; set; }
        public bool MandatoryPenalty { get; set; }
    }
}

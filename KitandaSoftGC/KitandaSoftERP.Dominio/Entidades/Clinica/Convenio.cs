using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Convenio : Retorno.TabelaGeral
    {
        public decimal ValorParceiro { get; set; }
        public decimal ValorUtente { get; set; }
        public DateTime Validade { get; set; }
        public decimal PrecoProposto { get; set; }
        public decimal ValorAcordado { get; set; }
        public decimal PercentualProposto { get; set; }
        public List<ConvenioCoberturaItemDTO> ItensCobertos { get; set; }
        public Convenio()
        {

        }

        public Convenio(int pCodigo)
        {
            this.Codigo = pCodigo;
        }

        public Convenio(int pCodigo, string pDescricao)
        {
            this.Codigo = pCodigo;
            this.Descricao = pDescricao;
        }

        public Convenio(string pDescricao, int pEntidade)
        {
            this.Descricao = pDescricao;
            this.Entidade = pEntidade;
        }


    }

    public class ConvenioCoberturaItemDTO : Retorno.Retorno
    {
        public int Artigo { get; set; }
        public int ConvenioID { get; set; }
        public decimal ValorParceiro { get; set; }
        public decimal ValorUtente { get; set; }
        public string ItemDesignation { get; set; }
        public string AggrementDesignation { get; set; }
        public decimal PrecoProposto { get; set; }
        public decimal PrecoAcordado { get; set; }
        public decimal PrecoVendaPublico { get; set; }

        public Convenio Convenio { get; set; }
    }
}


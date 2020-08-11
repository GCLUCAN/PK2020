using KitandaSoftERP.Dominio.Entidades.Geral;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class LaboratorioExame : Artigo
    {
        public int AmostraID { get; set; }
        public string AplicacaoClinica { get; set; }
        public string CuidadosColecta { get; set; }
        public string TransporteArmazenamento { get; set; }
        public string MetodosLaboratoriais { get; set; }
        public string CometarioPatologistaClinico { get; set; }
        public string NotasPaciente { get; set; }
        public int MasterID { get; set; }
        public List<LaboratorioExameValoresReferenciaDTO> ValoresReferencia { get; set; }
        public int ExameArtigoID { get; set; }
        public List<LaboratorioExame> ChildrenComposeList { get; set; }
    }
    public class LaboratorioExameValoresReferenciaDTO : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public int ExameID { get; set; }
        public int FaixaEtariaID { get; set; }
        public string Sinal { get; set; }
        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; }
        public string ValorReferencia { get; set; }

    }
}

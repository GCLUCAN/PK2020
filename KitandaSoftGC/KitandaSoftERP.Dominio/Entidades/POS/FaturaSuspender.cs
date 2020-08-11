using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.POS
{
    public class FaturaSuspender : Retorno.Retorno
    {
        public int CodigoReferencia { get; set; }
        public string DesignacaoReferencia { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Data_Ini { get; set; }
        public DateTime Data_Fin { get; set; }
        public int Ordem { get; set; }
        public int Codigo { get; set; }
        public int Artigo { get; set; }
        public string Designacao { get; set; }
        public decimal Imposto { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Desconto { get; set; }
        public decimal TotalLiquido { get; set; }
        public string Referencia { get; set; }
        public decimal DescontoNumerario { get; set; }
        public int TaxID { get; set; }
        public string UnidadeID { get; set; }
        public string Unidade { get; set; }
        public decimal ValorImposto { get; set; }
        public int ImpostoID { get; set; }
        public int LoteID { get; set; }
        public int DimensaoID { get; set; }
        public int SerialNumberID { get; set; }
        public string ItemNotes { get; set; }
        public decimal ValorDesconto { get; set; }
        public int ArmazemID { get; set; }
        public decimal ExistenciaAnterior { get; set; }
        public int DocEnvioID { get; set; }
        public int EnvioLineNumber { get; set; }
        public DateTime DataEnvio { get; set; }
        public int CookerID { get; set; }
        public int DocOrigemID { get; set; }
        public int OrigemLineNumber { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal WidthSize { get; set; }
        public decimal HeightSize { get; set; }
        public string Foto { get; set; }

        public FaturaSuspender(string pUtilizador, DateTime pData_Ini, DateTime pData_Fin, string pFilial)
        {
            //DesignacaoReferencia = pDesignacaoRefe;
            Utilizador = pUtilizador;
            Data_Ini = pData_Ini;
            Data_Fin = pData_Fin;
            Filial = pFilial;
        }
        public FaturaSuspender()
        {

        }
    }
}

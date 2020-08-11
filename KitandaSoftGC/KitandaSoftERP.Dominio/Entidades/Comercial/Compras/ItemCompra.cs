using KitandaSoftERP.Dominio.Entidades.Geral;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Comercial.Compras
{
    public class ItemCompra: Retorno.Retorno
    {
        public int Compra { get; set; }
        public int Artigo { get; set; }
        public string Referencia { get; set; }
        public string Designacao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Desconto { get; set; }
        public decimal DescontoCompra { get; set; }
        public decimal Imposto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorImposto { get; set; }
        public decimal TotalLiquido { get; set; }
        public string Comentarios { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Notas { get; set; }
        public bool MovimentaStock { get; set; }
        public int ArmazemID { get; set; }
        public List<Armazem> ArmazemList { get; set; }
        public bool Composicao { get; set; }
        public int ComposeID { get; set; }
        public int LoteID { get; set; }
        public int DimensaoID { get; set; }
        public int SerialNumberID { get; set; }

        public List<ComposicaoDTO> ComposeList { get; set; }
        public bool KitchenOrder { get; set; }
        public bool OrderSaved { get; set; }
        public bool SavedNote { get; set; }
        public string ItemNotes { get; set; }
        public object PedidoID { get; set; }
        public string PrinterDestiny { get; set; }
        public bool Deleted { get; set; }
        public int CookerID { get; set; }
        public string Prioridade { get; set; }
        public int TaxID { get; set; }
        public string UnidadeID { get; set; }
        public DateTime DataEntrega { get; set; }
        public string ItemStatus { get; set; }
        public decimal QuatidadeEncomendada { get; set; }
        public decimal QuantidadeReservada { get; set; }
        public decimal Retencao { get; set; }
        public object OrigemID { get; set; }
        public int OrigemLine { get; set; }
        public object EnvioID { get; set; }
        public int EnvioLine;
        public decimal DescontoFinanceiro { get; set; }
        public decimal ValorDescontoFinanceiro { get; set; }
        public decimal PrecoCusto { get; set; }
        public string Unidade { get; set; }
        public decimal DescontoNumerario { get; set; }
        public string BarCode { get; set; }
        public decimal ExistenciaAnterior { get; set; }
        public decimal Lucro { get; set; }
        public decimal ValorFreteViagem { get; set; }
        public decimal ValorDespesasAduaneiras { get; set; }
        public decimal ValorSeguro { get; set; }
        public decimal ValorHonorariosDespachante { get; set; }
        public decimal ValorTransporteLocal { get; set; }
        public decimal OutrosEncargos { get; set; }


        public ItemCompra()
        {
            NroOrdenacao = 1;
            Compra = -1;
            Artigo = -1;
            Referencia = string.Empty;
            Designacao = string.Empty;
            Quantidade = 0;
            PrecoUnitario = 0;
            Desconto = 0;
            DescontoCompra = 0;
            Imposto = 0;
            ValorDesconto = 0;
            ValorImposto = 0;
            TotalLiquido = 0;
            Comentarios = string.Empty;
            DataEntrada = DateTime.Now;
            ArmazemList = new List<Armazem>();
            ArmazemID = -1;
            Status = 1;
            Composicao = false;
            LoteID = 0;
            DimensaoID = 0;

        }

        public ItemCompra(int pOrdem)
        {
            NroOrdenacao = pOrdem;
            Compra = -1;
            Artigo = -1;
            Referencia = string.Empty;
            Designacao = string.Empty;
            Quantidade = 0;
            PrecoUnitario = 0;
            Desconto = 0;
            DescontoCompra = 0;
            Imposto = 0;
            ValorDesconto = 0;
            ValorImposto = 0;
            TotalLiquido = 0;
            Comentarios = string.Empty;
            DataEntrada = DateTime.Now;
            ArmazemList = new List<Armazem>();
            ArmazemID = -1;
            Status = 1;
        }
    }
}

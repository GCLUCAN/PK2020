using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class ItemCobranca : Retorno.Retorno
    {
        public int ItemCodigo { get; set; }
        public string ItemDescricao { get; set; }
        public int ItemCategoria { get; set; }

        public PrecoItemCobranca ItemPreco { get; set; }

        public string ItemTaxa { get; set; }
        public decimal Quantidade { get; set; }
     
        public ItemCobrancaPlanoCurricular ItemPlano { get; set; }

        public string ItemStatus { get; set; }
        public decimal PrecoUnitario { get; set; }

        public string Designacao { get; set; }

        public ItemCobranca()
        {

        }

        public ItemCobranca(int pCodigo, string pDescricao, int pFilial, int pAnoLectivo)
        {
            ItemCodigo = pCodigo;
            ItemDescricao = pDescricao;
            CompanyID = pFilial.ToString();
            AnoLectivo = pAnoLectivo;

        }

        public ItemCobranca(int pCodigo, string pDescricao, int pCategoria, string pTaxa, string pStatus, int pFilial)
        {
            ItemCodigo = pCodigo;
            ItemDescricao = pDescricao;
            ItemCategoria = pCategoria;
            ItemTaxa = pTaxa;
            ItemStatus = pStatus;
            CompanyID = pFilial.ToString();

        }

        public ItemCobranca(int pCodigo, string pDescricao)
        {
            ItemCodigo = pCodigo;
            ItemDescricao = pDescricao;

        }

        public ItemCobranca(int pCodigo)
        {
            ItemCodigo = pCodigo;
        }

        public ItemCobranca(string pDescricao, int pPreco)
        {
            // TODO: Complete member initialization
            ItemDescricao = pDescricao;
            ItemValor = pPreco;
        }

        public Decimal ItemValor { get; set; }

        public DateTime From { get; set; }
        public DateTime Until { get; set; }
        public int ItemObrigatorio { get; set; }

        public string Rubrica { get; set; }

        public int MovimentStock { get; set; }

        public string ContaTesouraria { get; set; }

        public bool ItemExterno { get; set; }

        public decimal Existencia { get; set; }

        public decimal Maximo { get; set; }

        public decimal Minimo { get; set; }

        public decimal PrecoCusto { get; set; }

        public string MonthlyPaymentType { get; set; }

        public bool CobraMulta { get; set; }
        public int VatTaxID { get; set; }
        public bool IncludeRetention { get; set; }
        public decimal VatTaxPercent { get; set; }

    }
}

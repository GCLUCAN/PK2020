using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Stock
{
    public class Stock: Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Referencia { get; set; }
        public int ArmazemID { get; set; }
        public int ProductID { get; set; }
        public decimal Existencia { get; set; }
        public decimal Minimo { get; set; }
        public decimal Maximo { get; set; }
        public DateTime UltimaContagem { get; set; }
        public string Type { get; set; }
        public int Categoria { get; set; }
        public bool IsComercial { get; set; }
        public DateTime UltimaEntrada { get; set; }
        public DateTime UltimaSaida { get; set; }
        public string Designation { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoMedioCusto { get; set; }
        public decimal ValorStockPVP { get; set; }
        public decimal ValorStockPCU { get; set; }
        public int MovimentID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal SubTotal { get; set; }

        public string CatergoryDesignation { get; set; }

        public DateTime DataFrom { get; set; }

        public DateTime DataUntil { get; set; }
    }

    public class MovimentoStockDTO : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public DateTime DataMovimento { get; set; }
        public DateTime DataStock { get; set; }
        public int EntityID { get; set; }
        public string Type { get; set; }
        public string DocumentReference { get; set; }
        public int WarehouseFrom { get; set; }
        public int WarehouseTarget { get; set; }
        public int WarehouseRoot { get; set; }
        public string Notes { get; set; }
        public int InvoiceID { get; set; }

    }

}


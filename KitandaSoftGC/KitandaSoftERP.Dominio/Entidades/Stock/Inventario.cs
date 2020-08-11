using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Stock
{
    public class Inventario : Retorno.Retorno
    {
        public int InventoryID { get; set; }

        public string Reference { get; set; }

        public DateTime InventoryDate { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int EmployeeID { get; set; }

        public int WarehouseID { get; set; }

        public string InventoryStatus { get; set; } // F - Fechado; C - EM CONTAGEM; A - ANULADO;

        public List<ItemMovimentoStock> InventoryItemsList { get; set; }

        public string Localizacao { get; set; }
    }
}

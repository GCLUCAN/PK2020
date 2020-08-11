using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Logistica
{
    public class BillOfLoading : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Reference { get; set; }
        public string ManifestID { get; set; }
        public int ShipperID { get; set; }
        public int OwnerID { get; set; }
        public int AgentID { get; set; }
        public string IssuePlace { get; set; }
        public DateTime IssueDate { get; set; }
        public string ShipName { get; set; }
        public string VoyageNumber { get; set; }
        public int LoadingPortID { get; set; }
        public int DestinationPortID { get; set; }
        public DateTime AtracationDate { get; set; }
        public DateTime DeschageStartDate { get; set; }
        public DateTime DeachargeEndDate { get; set; }
        public DateTime DesAtracationDate { get; set; }
        public decimal TotalItems { get; set; }
        public decimal TotalTons { get; set; }
    }

    public class BLItems
    {
        public int CodigoBL { get; set; }
        public int ProductID { get; set; }
        public decimal QuantityManifested { get; set; }
        public decimal QuantityCharged { get; set; }
        public decimal TonsManifested { get; set; }
        public decimal TonsCharged { get; set; }
    }
}

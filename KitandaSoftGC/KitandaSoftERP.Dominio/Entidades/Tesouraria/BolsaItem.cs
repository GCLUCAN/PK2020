using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class BolsaItem : Retorno.Retorno
    {
        public string ItemCobranca { get; set; }
        public int CategoryID { get; set; }
        public string Bolsa { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Validade { get; set; }
        public Decimal Valor { get; set; }
        public Decimal Percentagem { get; set; }
        public string Multa { get; set; }
        public string ItemDesignacao { get; set; }

        public BolsaItem()
        {
            Bolsa = "";
            ItemCobranca = "";
           // CompanyID = "-1";
            Valor = 0;
            Inicio = DateTime.MinValue;
            Validade = DateTime.MinValue;
            Multa = "N";

        }

        public BolsaItem(string pBolsa)
        {
            Bolsa = pBolsa;
        }




        public BolsaItem(string pBolsa, string pFilial, string pItem, string pMulta)
        {
            Bolsa = pBolsa;
        //    CompanyID = pFilial;
            ItemCobranca = pItem;
            Multa = pMulta;
        }




      
    }
}

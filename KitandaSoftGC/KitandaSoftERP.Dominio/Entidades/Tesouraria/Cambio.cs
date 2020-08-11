using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Cambio: Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Moeda { get; set; }
        public decimal CambioCompra { get; set; }
        public decimal CambioVenda { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public int BancoID { get; set; }
        public int MoedaBase { get; set; }
        public DateTime Data { get; set; }

        public Cambio()
        {
        }
        public Cambio(string pMoeda)
        {
            Moeda = pMoeda;
        }
        public Cambio(int pCodigo, string pMoeda, decimal cambio, DateTime pFrom, DateTime pUntil, string pDescricao)
        {
            Codigo = pCodigo;
            Moeda = pMoeda;
            CambioCompra = cambio;
            Inicio = pFrom;
            Termino = pUntil;
            Descricao = pDescricao;
        }
        public Cambio(string pMoeda, string pCompanyID)
        {
            Moeda = pMoeda;
            Filial = pCompanyID;
        }

       
    }
}

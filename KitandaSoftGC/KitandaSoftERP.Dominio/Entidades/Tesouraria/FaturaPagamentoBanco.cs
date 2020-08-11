using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class FaturaPagamentoBanco : Retorno.Retorno
    {
        public int PagamentoBancoCodigo { get; set; }
        public FaturaPagamento FaturaPagamento { get; set; }
        public ContaBancariaDTO ContaBancaria { get; set; }
        public Double PagamentoBancoValor { get; set; }
        public String PagamentoBancoDocumento { get; set; }


        public FaturaPagamentoBanco()
        {

        }
        public FaturaPagamentoBanco(Int32 codigo, FaturaPagamento faturaPagamento, ContaBancariaDTO contaBancaria, Double valor, String documento)
        {
            this.PagamentoBancoCodigo = codigo;
            this.FaturaPagamento = faturaPagamento;
            this.ContaBancaria = contaBancaria;
            this.PagamentoBancoDocumento = documento;
            this.PagamentoBancoValor = valor;
        }
    }
    public class ListaFaturaPagamentosBancoDTO : List<FaturaPagamentoBanco>
    {

    }
}

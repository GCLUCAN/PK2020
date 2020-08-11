using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class MovimentoCaixaDTO : Retorno.Retorno
    {

        public int MovCodigo { get; set; }
        public DateTime MovData { get; set; }
        public String MovMovimento { get; set; }
        public String MovDescricao { get; set; }
        public String MovUtilizador { get; set; }
        public Int32 MovMoeda { get; set; }
        public Int32 MovFatura { get; set; }
        public Int32 MovFormaPagamento { get; set; }
        public string MovDataIni { get; set; }
        public string MovDataTerm { get; set; }
        public String MovNatureza { get; set; }
        public EntradaCaixa Entrada { get; set; }
  

        public SaidaCaixa Saida { get; set; }
        private string _banco = "-1";

        public string Banco { get; set; }
        public string Conta { get; set; }
        public string NomeResponsavel { get; set; }
        public string DescricaoPagamento { get; set; }


        private PlanoConta _rubrica = new PlanoConta();


        public MovimentoCaixaDTO(int codigo, DateTime data, string tipo, string descricao, string utilizador, int moeda, int fatura, int formaPagamento, EntradaCaixa entrada, SaidaCaixa saida)
        {
            this.MovCodigo = codigo;
            this.MovData = data;
            this.MovDescricao = descricao;
            this.MovFatura = fatura;
            this.MovFormaPagamento = formaPagamento;
            this.MovMoeda = moeda;
            this.MovMovimento = tipo;
            this.MovUtilizador = utilizador;
            this.Entrada = entrada;
            this.Saida = saida;

        }
        public MovimentoCaixaDTO()
        {

        }

        public string CentroCusto { get; set; }

        public Decimal Saldo { get; set; }

        public Decimal SaldoInicial { get; set; }

        public decimal MovMontante { get; set; }

    }

    public class ListaMovimentosCaixaDTO : List<MovimentoCaixaDTO>
    {

    }
}


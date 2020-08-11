using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Clinica
{
    public class Servico
    {
        public int Codigo { get; set; }
        public Especialidade Especialidade { get; set; }
        public double Preco { get; set; }
        public string Sigla { get; set; }
        public int Estado   { get; set; }
        public int Duracao { get; set; }
        public string Unidade { get; set; }
        public string Categoria { get; set; }
        public Servico()
        {

        }

        public Servico(int pCodigo)
        {
            this.Codigo = pCodigo;

        }

        public Servico(int pCodigo, string pNome)
        {
            this.Especialidade = new Especialidade(pCodigo, pNome);
        }

        public Servico(string pTipo, string pNome)
        {
            this.Especialidade = new Especialidade(0, pNome);
        }

        public Servico(int pCodigo, string pNome, double pValor)
        {
            this.Especialidade = new Especialidade(pCodigo, pNome);
            this.Preco = pValor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.RecursosHumanos
{
    public class Agregado : Geral.Pessoa
    {
        public int Funcionario { get; set; }
        public string Parentesco { get; set; }

        public Agregado()
        {

        }

        public Agregado(int pFuncionario, string pNome, string pIdentificacao, DateTime pDataNascimento, string pGrauParenteco)
        {
            Funcionario = pFuncionario;
            NomeCompleto = pNome;
            Identificacao = pIdentificacao;
            DataNascimento = pDataNascimento;
            Parentesco = pGrauParenteco;
        }

    }
}

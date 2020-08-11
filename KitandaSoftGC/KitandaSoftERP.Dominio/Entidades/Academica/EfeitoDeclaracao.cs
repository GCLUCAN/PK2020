using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class EfeitoDeclaracao : Retorno.Retorno
    {
        public EfeitoDeclaracao()
        {

        }

        public int EfeCodigo { get; set; }
        public string EfeDescricao { get; set; }
        public String EfeTipo { get; set; }


        public EfeitoDeclaracao(int codigo, string descricao, string tipo)
        {
            this.EfeCodigo = codigo;
            this.EfeDescricao = descricao;
            this.EfeTipo = tipo;
        }

    }
}

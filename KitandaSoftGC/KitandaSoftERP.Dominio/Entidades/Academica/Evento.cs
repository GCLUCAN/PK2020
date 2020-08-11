using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Academica
{
    public class Evento :Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public DateTime DataRealizacao { get; set; }
        public string Data { get; set; }
        public int Visualizacoes { get; set; }
        public object Conteudo { get; set; }
        public int Likes { get; set; }
        public int Views { get; set; }

        public Evento()
        {

        }

        public Evento(int codigo)
        {
            this.Codigo = codigo;
        }

        public Evento(string titulo, string descricao)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
        }

        public Evento(int codigo, string titulo, string data, string descricao)
        {
            this.Codigo = codigo;
            this.Titulo = titulo;
            this.Data = data;
            this.Descricao = descricao;
        }

        public Evento(int codigo, string titulo, string data, string descricao, int visualizacoes)
        {
            this.Codigo = codigo;
            this.Titulo = titulo;
            this.Data = data;
            this.Descricao = descricao;
            this.Visualizacoes = visualizacoes;
        }
    }
}

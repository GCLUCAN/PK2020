using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class Utilizador : Retorno.Retorno    
    {
        public int Codigo { get; set; }
        public Perfil Perfil { get; set; }
        public Idioma Idioma { get; set; }
        public int IdiomaID { get; set; }
        public string DescricaoPerfil { get; set; }

        public Utilizador()
        {
            Utilizador = "";
            SocialName = "";
           
        }

        public Utilizador(string pUtilizador)
        {
            Utilizador = pUtilizador;
            Situacao = string.Empty;
            SocialName = string.Empty;
            Perfil = new Perfil(-1);
        }

        public Utilizador(string pUtilizador, int pFilial)
        {
            Utilizador = pUtilizador;
            Filial = pFilial.ToString();
            Perfil = new Perfil(-1);
        }

        public Utilizador(string pUtilizador, string pNome)
        {
            Utilizador = pUtilizador;
            SocialName = pNome;
            Perfil = new Perfil(-1);
        }

    }
}

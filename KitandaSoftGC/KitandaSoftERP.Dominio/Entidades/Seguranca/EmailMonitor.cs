using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class EmailMonitor : Retorno.Retorno
    {
        public int Codigo { get; set; }
        public string Remetente { get; set; }
        public string Endereco { get; set; }
        public string Servidor { get; set; }
        public string Usuario { get; set; }
        public string Porta { get; set; }
        public bool AtivaSSL { get; set; }
        public EmailMonitor()
        {

        }

        public EmailMonitor(int pCodigo, string pRemetente, string pEndereco, string pHost, string pUsuario, string pSenha, string pPorta)
        {
            Codigo = pCodigo;
            Remetente = pRemetente;
            Endereco = pEndereco;
            Servidor = pHost;
            Usuario = pUsuario;
            CurrentPassword = pSenha;
            Porta = pPorta;
        }

        public EmailMonitor(int pCodigo)
        {
            Codigo = pCodigo;
        }
    }
}

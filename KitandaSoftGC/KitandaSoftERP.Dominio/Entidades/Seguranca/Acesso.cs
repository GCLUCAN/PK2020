using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class Acesso
    {
        public int Codigo { get; set; }
        public string Maquina { get; set; }
        public string IP { get; set; }
        public DateTime DataLogin { get; set; }
        public DateTime DataLogout { get; set; }
        public string StatusSessao { get; set; }
        public Configuracao Settings { get; set; }
        public List<PermissaoFormulario> UserAccess { get; set; }
        public List<PagamentoDTO> PaymentReceivedList { get; set; }
        public PosDTO UserPOS { get; set; }
        public ArmazemDTO UserDefaultWarehouse { get; set; }
        public string ServerMacAddress { get; set; }
        public bool IsMultiCompany { get; set; }
        public string ServerName { get; set; }
        public string InvoiceProductList { get; set; }
        public DateTime HoraLogin { get; set; }
        public DateTime HoraLogout { get; set; }
        public object DocumentLinesNotesList { get; set; }
        public object InvoiceData { get; set; }
        public string Language { get; set; }
        public string DefaultLanguage { get; set; }
        public string CurrentSystem { get; set; }
        public Acesso()
        {
            Codigo = 0;
            Maquina = string.Empty;
            IP = string.Empty;
            Utilizador = string.Empty;
            CurrentPassword = string.Empty;
        }

        public Acesso(int pCodigo, string pMaquina, string pIP, string pUtilizador, string pSenha)
        {
            Codigo = pCodigo;
            Maquina = pMaquina;
            IP = pIP;
            Utilizador = pUtilizador;
            CurrentPassword = pSenha;
        }

        public Acesso(int pCodigo, string pMaquina, string pIP, string pUtilizador)
        {
            Codigo = pCodigo;
            Maquina = pMaquina;
            IP = pIP;
            Utilizador = pUtilizador;
        }

        public static string AdminMaster
        {
            get
            {
                return "administrador";
            }
        }

        public static int isGerente
        {
            get
            {
                return 3;
            }
        }

        public static int CashRegisterProfile
        {
            get
            {
                return 2;
            }
        }

        
    }
}

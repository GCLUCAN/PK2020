using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Tesouraria
{
    public class Pagamento
    {
        public int PaymentMethod { get; set; }
        public string PaymentDescription { get; set; }
        public decimal Value { get; set; }
        public string Account { get; set; }
        public string DocumentNumber { get; set; }
        public int Order { get; set; }
        public DateTime PaymentDate { get; set; }
        public Pagamento()
        {
            PaymentMethod = -1;
            Order = 0;
            PaymentDescription = string.Empty;
            Value = 0;
            Account = string.Empty;
            DocumentNumber = string.Empty;
            PaymentDate = DateTime.MinValue;
        }
        public Pagamento(int pOrder, int pID, string pDescription, decimal pValue, string pAccount, string pDocumentNumber, DateTime pDate)
        {
            PaymentMethod = pID;
            Order = pOrder;
            PaymentDescription = pDescription;
            Value = pValue;
            Account = pAccount;
            DocumentNumber = pDocumentNumber;
            PaymentDate = pDate;
        }
       
    }
}

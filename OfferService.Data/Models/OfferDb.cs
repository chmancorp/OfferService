using System;
using System.Collections.Generic;

namespace OfferService.Data.Entities
{
    public partial class OfferDb
    {
        public int CreditId { get; set; }
        public int? OfertaId { get; set; }
        public int? Amount { get; set; }
        public int? Period { get; set; }
        public int? InsuranceId { get; set; }
        public int? Bond { get; set; }
        public int? MonthPay { get; set; }
        public int? PersonaId { get; set; }
        public int? RequestId { get; set; }
        public int? FirtPay { get; set; }
    }
}

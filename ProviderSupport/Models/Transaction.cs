using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProviderSupport.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public DateTime TimeStamp { get; set; }
        public int ProviderID { get; set; }
        public int ClientID { get; set; }
        public DateTime DateWorked { get; set; }
        public int ServiceType { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public string ServiceDesc { get; set; }
        public string ProgressNote { get; set; }
        public int? OdometerStart { get; set; }
        public int? OdometerEnd { get; set; }
        public string TravelPurpose { get; set; }
        public string ExpenseVendor { get; set; }
        public string ExpensePurpose { get; set; }
        public string ExpenseAmount { get; set; }
        public int? EmploymentType { get; set; }
        public int? EmploymentDirSuppHrs { get; set; }
        public bool? IsDuplicate { get; set; }
        public DateTime? WhenInvoiced { get; set; }
        public DateTime? WhenSentToExprs { get; set; }
        public DateTime? WhenPaidToPayroll { get; set; }

        public virtual Provider Provider { get; set; }
        public virtual Client Client { get; set; }
    }
}
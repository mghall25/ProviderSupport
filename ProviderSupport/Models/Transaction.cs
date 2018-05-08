using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProviderSupport.Models
{    
    public class Transaction
    {
        // constructor
        public Transaction()
        {
            TimeStamp = DateTime.Now;
        }

        public int TransactionID { get; set; }
                
        public DateTime TimeStamp { get; set; }

        public int ProviderID { get; set; }
        public int ClientID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Service Date")]
        public DateTime DateWorked { get; set; }
                
        public int ServiceTypeID { get; set; }

        //[DataType(DataType.Time)]
        //[DisplayFormat(DataFormatString ="{0:hh:mm ampm", ApplyFormatInEditMode =true)]
        [Display(Name = "Time In")]
        public DateTime TimeIn { get; set; }

        //[DataType(DataType.Time)]
        //[DisplayFormat(DataFormatString ="{0:hh:mm ampm", ApplyFormatInEditMode =true)]
        [Display(Name = "Time Out")]
        public DateTime TimeOut { get; set; }

        public string ServiceDesc { get; set; }

        public string ProgressNote { get; set; }

        public int? OdometerStart { get; set; }
        public int? OdometerEnd { get; set; }

        public string TravelPurpose { get; set; }

        public string ExpenseVendor { get; set; }

        public string ExpensePurpose { get; set; }

        public int? ExpenseAmount { get; set; }

        [Required]        
        public int? ServiceTypeEmplID { get; set; }

        public int? EmploymentDirSuppHrs { get; set; }

        public bool? IsDuplicate { get; set; }

        public DateTime? WhenInvoiced { get; set; }

        public DateTime? WhenSentToExprs { get; set; }

        public DateTime? WhenPaidToPayroll { get; set; }
        
        public virtual Provider Provider { get; set; }
        public virtual Client Client { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual ServiceTypeEmpl ServiceTypeEmpl { get; set; }
    }
}
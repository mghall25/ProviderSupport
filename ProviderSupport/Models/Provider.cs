using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProviderSupport.Models
{
    public class Provider
    {
        public int ProviderID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double PayRate { get; set; }
        public DateTime CprExpDate { get; set; }
        public bool? Archived { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
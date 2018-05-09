using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProviderSupport.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string PrimeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyEmail { get; set; }
        public string EmergencyPhone { get; set; }
        public string PA { get; set; }
        public string PaOrg { get; set; }
        public bool? Archived { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
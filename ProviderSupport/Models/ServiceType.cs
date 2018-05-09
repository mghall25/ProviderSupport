using ProviderSupport.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProviderSupport.Models
{
    public class ServiceType
    {
        // for use in ServiceType radio button group
        /*public List<ServiceType> ServiceTypes
        {
            get
            {
                ProviderSupportContext db = new ProviderSupportContext();
                return db.ServiceTypes.ToList();
            }
        }*/

        // for use in radio button group
        /*private class Enumerator : IEnumerator<ServiceType>
        { 
            public ServiceType Current { get; private set; }
            object IEnumerator.Current => this.Current;

            //ServiceType IEnumerator<ServiceType>.Current => throw new NotImplementedException();

            //object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose() { }
            public bool MoveNext()
            {
                if (this.Current == null)
                {
                    this.Current = new ServiceType();
                    return true;
                }
                this.Current = null;
                return false;
            }
            public void Reset() { this.Current = null; }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }
        }
        public IEnumerator<ServiceType> GetEnumerator()
        {
            return new Enumerator();
        }
        */

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceTypeID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Enter up to 50 characters.")]
        [Display(Name = "Description")]
        public string Desc { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Enter up to 150 characters.")]
        [Display(Name = "Long Description")]
        public string DescLong { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
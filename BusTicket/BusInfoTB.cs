//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusTicket
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusInfoTB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusInfoTB()
        {
            this.TripInfoTBs = new HashSet<TripInfoTB>();
        }
    
        public int ID { get; set; }
        public string BusName { get; set; }
        public string BusNumber { get; set; }
        public int TotalSits { get; set; }
        public string BusType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TripInfoTB> TripInfoTBs { get; set; }
    }
}

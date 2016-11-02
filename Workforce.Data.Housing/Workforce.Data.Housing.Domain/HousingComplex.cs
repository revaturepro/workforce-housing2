//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Workforce.Data.Housing.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class HousingComplex
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HousingComplex()
        {
            this.Apartment = new HashSet<Apartment>();
        }
    
        public int HotelID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsHotel { get; set; }
        public string PhoneNumber { get; set; }
        public bool ActiveBit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apartment> Apartment { get; set; }
    }
}
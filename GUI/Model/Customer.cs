//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.Model
{
    using GUI.ViewMD;
    using System;
    using System.Collections.Generic;
    
    public partial class Customer : ViewModelBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Bills = new HashSet<Bill>();
        }
    
        public int id { get; set; }
        //public string name { get; set; }
        //public string sdt { get; set; }

        private string _name;
        public string name { get => _name; set { _name = value; OnPropertyChanged(); } }
        private string _sdt;
        public string sdt { get => _sdt; set { _sdt = value; OnPropertyChanged(); } }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTecBits_MVC5_Bootstrap3_EF6_DatabaseFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemParameter
    {
        public int SystemParameterID { get; set; }
        public string DeliveryAddressLine1 { get; set; }
        public string DeliveryAddressLine2 { get; set; }
        public int DeliveryCityID { get; set; }
        public string DeliveryPostalCode { get; set; }
        public System.Data.Entity.Spatial.DbGeography DeliveryLocation { get; set; }
        public string PostalAddressLine1 { get; set; }
        public string PostalAddressLine2 { get; set; }
        public int PostalCityID { get; set; }
        public string PostalPostalCode { get; set; }
        public string ApplicationSettings { get; set; }
        public int LastEditedBy { get; set; }
        public System.DateTime LastEditedWhen { get; set; }
    
        public virtual City City { get; set; }
        public virtual City City1 { get; set; }
        public virtual Person Person { get; set; }
    }
}

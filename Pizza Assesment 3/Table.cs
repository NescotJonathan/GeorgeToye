//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pizza_Assesment_3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table
    {
        public int Transaction_Id { get; set; }
        public Nullable<int> Customer_Id { get; set; }
        public Nullable<int> Login_Id { get; set; }
        public int Order_Id { get; set; }
        public int Price { get; set; }
        public byte[] Time_Stamp { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Login Login { get; set; }
        public virtual Order Order { get; set; }
        public virtual Price Price1 { get; set; }
    }
}

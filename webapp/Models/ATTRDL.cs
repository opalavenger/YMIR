//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YMIR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ATTRDL
    {
        public System.Guid ID { get; set; }
        public System.Guid PID { get; set; }
        public string ATTR_TY { get; set; }
        public string ATTR_NO { get; set; }
        public string ATTR_NM { get; set; }
        public string ATTR_SR { get; set; }
        public string C_TY { get; set; }
        public string TABLE_NM { get; set; }
        public string PRG_NO { get; set; }
        public string C_SOURCE { get; set; }
        public string C_STA { get; set; }
        public string REMK { get; set; }
        public string OWNER_USR_NO { get; set; }
        public string OWNER_GRP_NO { get; set; }
        public Nullable<System.DateTime> ADD_DT { get; set; }
        public string MDY_USR_NO { get; set; }
        public Nullable<System.DateTime> MDY_DT { get; set; }
        public string IP_NM { get; set; }
        public string CP_NM { get; set; }
    
        public virtual ATTRMT ATTRMT { get; set; }
    }
}

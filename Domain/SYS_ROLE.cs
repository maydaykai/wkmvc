//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_ROLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_ROLE()
        {
            this.SYS_ROLE_PERMISSION = new HashSet<SYS_ROLE_PERMISSION>();
            this.SYS_USER_ROLE = new HashSet<SYS_USER_ROLE>();
        }
    
        public int ID { get; set; }
        public string ROLENAME { get; set; }
        public int ISCUSTOM { get; set; }
        public string ROLEDESC { get; set; }
        public string CREATEPERID { get; set; }
        public System.DateTime CREATEDATE { get; set; }
        public System.DateTime UPDATEDATE { get; set; }
        public string UPDATEUSER { get; set; }
        public string FK_BELONGSYSTEM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_ROLE_PERMISSION> SYS_ROLE_PERMISSION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_USER_ROLE> SYS_USER_ROLE { get; set; }
    }
}

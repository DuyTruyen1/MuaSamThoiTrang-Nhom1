using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace MuaSamThoiTrang.Module.BusinessObjects.QUANLYMUASAM
{
    [DefaultClassOptions]

    public partial class HOA_DON
    {
<<<<<<< HEAD
        public HOA_DON(Session session) : base(session) {}
        public override void AfterConstruction()
        { base.AfterConstruction();
            if (Session.IsNewObject(this)) 
=======
        public HOA_DON(Session session) : base(session) { }
        public override void AfterConstruction()
        { base.AfterConstruction();
            if(Session.IsNewObject(this))
>>>>>>> 41fd1856b43042ac3e5b0b3ac523503b0f4f9f58
            {
                NgayLapHD = DateTime.Now;
            }
        }
<<<<<<< HEAD
=======
        protected override void OnSaving()
        {
           
            base.OnSaving();
            tinhTong();
        }
>>>>>>> 41fd1856b43042ac3e5b0b3ac523503b0f4f9f58
    }

}

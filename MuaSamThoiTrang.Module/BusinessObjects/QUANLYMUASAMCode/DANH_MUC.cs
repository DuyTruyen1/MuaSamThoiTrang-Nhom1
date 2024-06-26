using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.XtraRichEdit.Model;
namespace MuaSamThoiTrang.Module.BusinessObjects.QUANLYMUASAM
{
    [DefaultClassOptions]

    public partial class DANH_MUC
    {
        public DANH_MUC(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        
    }

}

using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using MuaSamThoiTrang.Module.BusinessObjects.QUANLYMUASAM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MuaSamThoiTrang.Module.BusinessObjects.QUANLYMUASAMCode
{
    [DefaultClassOptions]
    [DefaultProperty("MaNhaCC")]
    public class NHA_CUNG_CAP : BaseObject
    { 
        public NHA_CUNG_CAP(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        string fMaNhaCC;
        [XafDisplayName("Mã nhà cung cấp")]
        public string MaNhaCC
        {
            get { return fMaNhaCC; }
            set { SetPropertyValue<string>(nameof(MaNhaCC), ref fMaNhaCC, value); }
        }
        string fTenNhaCC;
        [XafDisplayName("Tên nhà cung cấp")]
        public string TenNhaCC
        {
            get { return fTenNhaCC; }
            set { SetPropertyValue<string>(nameof(TenNhaCC), ref fTenNhaCC, value); }
        }
        string fDiaChi;
        [XafDisplayName("Địa chỉ")]
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
        [Association(@"SAN_PHAMReferencesNHA_CUNG_CAP")]
        public XPCollection<SAN_PHAM> SAN_PHAMs { get { return GetCollection<SAN_PHAM>(nameof(SAN_PHAMs)); } }
    }
}
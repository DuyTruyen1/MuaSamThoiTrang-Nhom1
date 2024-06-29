﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.DC;
namespace MuaSamThoiTrang.Module.BusinessObjects.QUANLYMUASAM
{

    public partial class USER : XPObject
    {
        string fUserID;
        public string UserID
        {
            get { return fUserID; }
            set { SetPropertyValue<string>(nameof(UserID), ref fUserID, value); }
        }
        string fTen;
        [XafDisplayName("Tên")]
        public string Ten
        {
            get { return fTen; }
            set { SetPropertyValue<string>(nameof(Ten), ref fTen, value); }
        }

        string fSoDT;
        [XafDisplayName("Sô điện thoại")]
        public string SoDT
        {
            get { return fSoDT; }
            set { SetPropertyValue<string>(nameof(SoDT), ref fSoDT, value); }
        }
        string fDiaChi;
        [XafDisplayName("Địa chỉ")]
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
        string fGhiChu;
        [XafDisplayName("Ghi chú")]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>(nameof(GhiChu), ref fGhiChu, value); }
        }
        [Association(@"DANH_GIAReferencesUSER")]
        public XPCollection<DANH_GIA> DANH_GIAs { get { return GetCollection<DANH_GIA>(nameof(DANH_GIAs)); } }
        [Association(@"DAT_HANGReferencesUSER")]
        public XPCollection<DAT_HANG> DAT_HANGs { get { return GetCollection<DAT_HANG>(nameof(DAT_HANGs)); } }
        [Association(@"HOA_DONReferencesUSER")]
        public XPCollection<HOA_DON> HOA_DONs { get { return GetCollection<HOA_DON>(nameof(HOA_DONs)); } }
    }

}

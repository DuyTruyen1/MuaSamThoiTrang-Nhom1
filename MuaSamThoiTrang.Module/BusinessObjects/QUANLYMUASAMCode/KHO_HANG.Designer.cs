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

    public partial class KHO_HANG : XPObject
    {
        string fMaKho;
        [XafDisplayName("Mã kho"), Size(100)]
        public string MaKho
        {
            get { return fMaKho; }
            set { SetPropertyValue<string>(nameof(MaKho), ref fMaKho, value); }
        }
        SAN_PHAM fLoaiSP;
        [XafDisplayName("Loại sản phẩm"), Size(100)]
        public SAN_PHAM LoaiSP
        {
            get { return fLoaiSP; }
            set { SetPropertyValue<SAN_PHAM>(nameof(LoaiSP), ref fLoaiSP, value); }
        }
        DateTime fNgayNhapKho;
        [XafDisplayName("Ngày nhập kho"), Size(100)]
        public DateTime NgayNhapKho
        {
            get { return fNgayNhapKho; }
            set { SetPropertyValue<DateTime>(nameof(NgayNhapKho), ref fNgayNhapKho, value); }
        }
        DateTime fNgayXuatKho;
        [XafDisplayName("Ngày xuất kho"), Size(100)]
        public DateTime NgayXuatKho
        {
            get { return fNgayXuatKho; }
            set { SetPropertyValue<DateTime>(nameof(NgayXuatKho), ref fNgayXuatKho, value); }
        }
        bool fTrangThai;
        [XafDisplayName("Trạng thái"), Size(100)]
        public bool TrangThai
        {
            get { return fTrangThai; }
            set { SetPropertyValue<bool>(nameof(TrangThai), ref fTrangThai, value); }
        }
        long fSoLuong;
        [XafDisplayName("Số lượng"), Size(100)]
        public long SoLuong
        {
            get { return fSoLuong; }
            set { SetPropertyValue<long>(nameof(SoLuong), ref fSoLuong, value); }
        }
        [Association(@"KHO_HANGReferencesSAN_PHAM")]
        public XPCollection<SAN_PHAM> SAN_PHAMs { get { return GetCollection<SAN_PHAM>(nameof(SAN_PHAMs)); } }
    }

}

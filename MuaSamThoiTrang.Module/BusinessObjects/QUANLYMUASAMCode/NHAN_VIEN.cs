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
    [DefaultProperty("MaNV")]
    public class NHAN_VIEN : BaseObject
    { 
        public NHAN_VIEN(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string fMaNV;
        [XafDisplayName("Mã nhân viên")]
        public string MaNV
        {
            get { return fMaNV; }
            set { SetPropertyValue<string>(nameof(MaNV), ref fMaNV, value); }
        }
        string fTaiKhoan;
        [XafDisplayName("Tài khoản")]
        public string TaiKhoan
        {
            get { return fTaiKhoan; }
            set { SetPropertyValue<string>(nameof(TaiKhoan), ref fTaiKhoan, value); }
        }
        string fTen;
        [XafDisplayName("Tên")]
        public string Ten
        {
            get { return fTen; }
            set { SetPropertyValue<string>(nameof(Ten), ref fTen, value); }
        }
        string fDiaChi;
        [XafDisplayName("Địa chỉ")]
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
        string fDienThoai;
        [XafDisplayName("Điện thoại")]
        public string DienThoai
        {
            get { return fDienThoai; }
            set { SetPropertyValue<string>(nameof(DienThoai), ref fDienThoai, value); }
        }
        string fGhiChu;
        [XafDisplayName("Ghi chú")]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>(nameof(GhiChu), ref fGhiChu, value); }
        }
        [Association(@"HOA_DONReferencesNHAN_VIEN")]
        public XPCollection<HOA_DON> HOA_DONs { get { return GetCollection<HOA_DON>(nameof(HOA_DONs)); } }
        [Association(@"THONG_KEReferencesNHAN_VIEN")]
        public XPCollection<THONG_KE> THONG_KEs { get { return GetCollection<THONG_KE>(nameof(THONG_KEs)); } }
    }
}
using System.Linq;
using System.Collections.Generic;
using VNG.Business.Models.Public;
using VNG.Business.Entities.Public;
using VNG.Business.Models.KhoTong;
using VNG.Business.Entities.KhoTong;

namespace API_VNG.Repository.KhoTong
{
    public class KhoTongRepository : IKhoTongRepository
    {
        private readonly IDapper _dapper;
        public KhoTongRepository(IDapper dapper)
        {
            _dapper = dapper;
        }
        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> KT_NhapKho(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proKT_NhapKho", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
                model.SoHoaDon_Den,
                model.NgayNhap,
                model.UserNhapKho,
                model.NVKiemHang,
                model.GhiChu,
                model.MaNhapKho
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> KT_XuatKho(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proKT_XuatKho", new
            {
                model.option,
                model.ID,
                model.TuNgay,
                model.DenNgay,
                model.SoHoaDon,
                model.MaXuatKho,
                model.NgayXuat,
                model.NoiNhan,
                model.NoiXuat,
                model.Kieu,
                model.Size,
                model.SoLuong,
                model.UserXuatKho,
                model.NVKiemHang,
                model.GhiChu,
                model.DienGiai

            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 16/09/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<KT_VanChuyen> KT_VanChuyen(KT_VanChuyen_ViewModel model)
        {
            return _dapper.ExecProcedureData<KT_VanChuyen>("proKT_VanChuyen", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
                model.SoHoaDon
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 02/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<KT_TonKho> KT_TonKho(KT_TonKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<KT_TonKho>("proKT_TonKho", new
            {
                model.action,
                model.TuNgay,
                model.DenNgay,
                model.Kieu,
                model.Size,
                model.SoLuong
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> KT_TonKhoThung(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proKT_TonKhoThung", new
            {
                model.option,
                model.SoHoaDon_Den
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 02/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<KT_YeuCauVungMien> KT_YeuCauTuVungMien(KT_YeuCauVungMien_ViewModel model)
        {
            return _dapper.ExecProcedureData<KT_YeuCauVungMien>("proKT_YeuCauVungMien", new
            {
                model.option,
                model.flag,
                model.NgayXuat,
                model.NoiXuat,
                model.NVKiemHang,
                model.UserXuatKho,
                model.GhiChu
            }).ToList();
        }


        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<KT_VanChuyen> KT_VanChuyen_HangLoi(KT_VanChuyen_ViewModel model)
        {
            return _dapper.ExecProcedureData<KT_VanChuyen>("proKT_VanChuyen_HangLoi", new
            {
                model.option,
                model.SoHoaDon,
                model.TuNgay,
                model.DenNgay
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> KT_NhapLoi(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proKT_NhapLoi", new
            {
                model.option,
                model.SoHoaDon_Den,
                model.MaNhapKho,
                model.NgayNhap,
                model.TuNgay,
                model.DenNgay,
                model.NVKiemHang,
                model.UserNhapKho
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 01/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> KT_XuatLoi(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proKT_XuatLoi", new
            {
                model.option,
                model.ID,
                model.MaXuatKho,
                model.SoHoaDon,
                model.TuNgay,
                model.DenNgay,
                model.Kieu,
                model.Size,
                model.SoLuong,
                model.NgayXuat,
                model.GhiChu,
                model.UserXuatKho,
                model.NVKiemHang,
                model.NoiXuat,
                model.NoiNhan,
                model.DienGiai

            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<KT_TonKho> KT_TonKhoLoi(KT_TonKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<KT_TonKho>("proKT_TonKhoLoi", new
            {
                model.action,
                model.Kieu,
                model.TuNgay,
                model.DenNgay
            }).ToList();
        }


        /// <summary>
        /// Create by Tri Minh, Date: 01/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> KT_XuatSale(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proKT_XuatSale", new
            {
                model.option,
                model.SoHoaDon,
                model.TuNgay,
                model.DenNgay,
                model.NgayXuat,
                model.NVKiemHang,
                model.Kieu,
                model.Size,
                model.SoLuong,
                model.UserXuatKho,
                model.GhiChu
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 01/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> KT_NhapSale(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proKT_NhapSale", new
            {
                model.option,
                model.SoHoaDon_Den,
                model.TuNgay,
                model.DenNgay
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<KT_TonKho> KT_TonKhoSale(KT_TonKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<KT_TonKho>("proKT_TonKhoSale", new
            {
                model.action,
                model.Kieu,
                model.TuNgay,
                model.DenNgay
            }).ToList();
        }

        /// <summary>
        ///  Create by Duy Tan. Date: 31/12/2020      
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> KT_NhapChinhKho(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proKT_NhapChinhKho", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
                model.MaNhapKho,
                model.SoHoaDon_Den,
                model.NoiNhan,
                model.NgayNhap,
                model.ID,
                model.NVKiemHang,
                model.UserNhapKho,
                model.ModifiedBy,
                model.GhiChu,
                model.DienGiai,
                model.Kieu,
                model.Size,
                model.SoLuong,
            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan, Date: 31/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> KT_XuatChinhKho(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proKT_XuatChinhKho", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
                model.ModifiedBy,
                model.MaXuatKho,
                model.SoHoaDon,
                model.NoiXuat,
                model.NgayXuat,
                model.ID,
                model.NVKiemHang,
                model.UserXuatKho,
                model.GhiChu,
                model.DienGiai,
                model.Kieu,
                model.Size,
                model.SoLuong

            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan, Date: 03/03/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<KT_TonKho_BaoCao> KT_TonKho_BaoCao(KT_TonKho_BaoCao_ViewModel model)
        {
            return _dapper.ExecProcedureData<KT_TonKho_BaoCao>("proKT_TonKho_BaoCao", new
            {
                model.action,
                model.Kieu,
                model.TuNgay,
                model.DenNgay

            }).ToList();
        }

    }

}

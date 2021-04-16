using System.Linq;
using System.Collections.Generic;
using VNG.Business.Entities.CuaHang;
using VNG.Business.Models.CuaHang;
using VNG.Business.Entities.Public;
using VNG.Business.Models.Public;

namespace API_VNG.Repository.CuaHang
{
    public class CuaHangRepository : ICuaHangRepository
    {
        private readonly IDapper _dapper;
        public CuaHangRepository(IDapper dapper)
        {
            _dapper = dapper;
        }
        /// <summary>
        /// Create by Tri Minh, Date: 29/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> CH_XuatKho(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proCH_XuatKho", new
            {
                model.option,
                model.ID,
                model.MaXuatKho,
                model.NoiXuat,
                model.TuNgay,
                model.DenNgay,
                model.SoHoaDon,
                model.NgayXuat,
                model.Kieu,
                model.Size,
                model.SoLuong,
                model.UserXuatKho,
                model.NVKiemHang,
                model.GhiChu,
                model.DienGiai,
                model.ModifiedBy
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 30/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> CH_NhapKho(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proCH_NhapKho", new
            {
                model.option,
                model.NoiNhan,
                model.TuNgay,
                model.DenNgay,
                model.NgayNhap,
                model.NVKiemHang,
                model.SoHoaDon_Den,
                model.UserNhapKho,
                model.GhiChu
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 24/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_VanChuyen> CH_VanChuyen(CH_VanChuyen_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_VanChuyen>("proCH_VanChuyen", new
            {
                model.option,
                model.NoiNhap,
                model.SoHoaDon,
                model.TuNgay,
                model.DenNgay
            }).ToList();
        }


        /// <summary>
        /// Create by Tri Minh, Date: 26/08/2020
        /// </summary>
        /// <param name="model"></param>
        /// Option = 1 Tồn kho theo từng cửa hàng
        /// Option = 2 Tìm kiếm "Kiểu" theo cửa hàng
        /// <returns></returns>
        public List<CH_TonKho> CH_TonKho(CH_TonKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_TonKho>("proCH_TonKho", new
            {
                model.option,
                model.Id,
                model.NoiTon,
                model.Kieu,
                model.Size,
                model.SoLuong,
                model.TuNgay,
                model.DenNgay
            }).ToList();
        }


        /// <summary>
        /// Create by Tri Minh, Date: 28/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> CH_TraDinhMucVeVungMien(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proCH_TraVeVungMien", new
            {
                model.option,
                model.SoHoaDon,
                model.MaXuatKho,
                model.Kieu,
                model.NoiXuat,
                model.NgayXuat,
                model.NVKiemHang,
                model.UserXuatKho,
                model.GhiChu
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 04/09/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_TonKhoDinhMuc> CH_TonKhoDinhMuc(CH_TonKhoDinhMuc_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_TonKhoDinhMuc>("proCH_TonKhoVoiDinhMuc", new
            {
                model.option,
                model.MaCuaHang,
                model.NgayXuat,
                model.UserXuatKho,
                model.GhiChu,
                model.NVKiemHang
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_QuanLyThuChi_ChiTiet> CH_QuanLyThuChi_ChiTiet(CH_QuanLyThuChi_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_QuanLyThuChi_ChiTiet>("proCH_QuanLyThuChi_ChiTiet", new
            {
                model.option,
                model.ID,
                model.MaCuaHang,
                model.TuNgay,
                model.DenNgay,
                model.LoaiPhieu,
                model.Ngay,
                model.MaNhanVien,
                model.LoaiPhatSinh,
                model.TienPhatSinh,
                model.Ca,
                model.LyDo,
                model.CreateBy,
                model.MaPhieu,
                model.ModifiedBy
            }).ToList();
        }


        /// <summary>
        /// Create by Tri Minh, Date: 28/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_QuanLyThuChi> CH_QuanLyThuChi(CH_QuanLyThuChi_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_QuanLyThuChi>("proQL_TongQuatThuChi", new
            {
                model.option,
                model.MaCuaHang
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> CH_NhapLoi(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proCH_NhapLoi", new
            {
                model.option,
                model.ID,
                model.TuNgay,
                model.DenNgay,
                model.NoiNhan,
                model.SoHoaDon_Den
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> CH_XuatLoi(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proCH_XuatLoi", new
            {
                model.option,
                model.MaXuatKho,
                model.SoHoaDon,
                model.ID,
                model.TuNgay,
                model.DenNgay,
                model.NoiXuat,
                model.NgayXuat,
                model.NVKiemHang,
                model.Kieu,
                model.Size,
                model.SoLuong,
                model.GhiChu,
                model.UserXuatKho,
                model.DienGiai
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_TonKho> CH_TonKhoLoi(CH_TonKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_TonKho>("proCH_TonKhoLoi", new
            {
                model.option,
                model.NoiTon,
                model.TuNgay,
                model.DenNgay
            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> CH_NhapDieuChinh(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proCH_NhapChinhKho", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
                model.MaNhapKho,
                model.SoHoaDon_Den,
                model.NoiNhan,
                model.NgayNhap,
                model.ID,
                model.DienGiai,
                model.NVKiemHang,
                model.UserNhapKho,
                model.GhiChu,
                model.Kieu,
                model.Size,
                model.SoLuong

            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> CH_XuatDieuChinh(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proCH_XuatChinhKho", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
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
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_TonKho_BaoCao> CH_TonKho_BaoCao(CH_TonKho_BaoCao_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_TonKho_BaoCao>("proCH_TonKho_BaoCao", new
            {
                model.action,
                model.NoiTon,
                model.ID,
                model.TuNgay,
                model.DenNgay,

            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_ThongKe> CH_ThongKe(CH_ThongKe_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_ThongKe>("proCH_ThongKe", new
            {
                model.action,
                model.MaCuaHang,
                model.TuNgay,
                model.DenNgay

            }).ToList();
        }


        /// <summary>
        /// Create by Duy Tan, Date: 06/03/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_DinhMuc_BaoCao> CH_DinhMuc_BaoCao(CH_DinhMuc_BaoCao_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_DinhMuc_BaoCao>("proCH_DinhMuc_BaoCao", new
            {
                model.action,
                model.MaCuaHang,
                model.Kieu,

            }).ToList();
        }

    }
}
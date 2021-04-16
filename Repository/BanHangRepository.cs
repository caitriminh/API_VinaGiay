using System.Linq;
using System.Collections.Generic;
using VNG.Business.Models.CuaHang;
using VNG.Business.Entities.CuaHang;

namespace API_VNG.Repository.BanHang
{
    public class BanHangRepository : IBanHangRepository
    {
        private readonly IDapper _dapper;
        public BanHangRepository(IDapper dapper)
        {
            _dapper = dapper;
        }
        /// <summary>
        /// Create by Tri Minh, Date: 23/12/2020
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        public List<CH_BanHang> CH_BanHang(CH_BanHang_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_BanHang>("proCH_BanHang", new
            {
                model.option,
                model.Id,
                model.MaCuaHang,
                model.MaKhachHang,
                model.SoHoaDonBan,
                model.SoLuong,
                model.BarcodeScan,
                model.MaPhieuTang,
                model.MaNhanVien,
                model.ThucNhan,
                model.CreateBy,
                model.TuNgay,
                model.DenNgay,
                model.MaNVTiepKhach,
                model.Kieu,
                model.Size
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 23/10/2020
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        public List<CH_DoiTraHang> CH_DoiTraHang(CH_DoiTraHang_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_DoiTraHang>("proCH_DoiTraHang", new
            {
                model.option,
                model.CuaHang,
                model.ID,
                model.TuNgay,
                model.DenNgay,
                model.LyDoDoiTra,
                model.CreateBy,
                model.ID2
            }).ToList();
        }


        /// <summary>
        /// Create by Tri Minh, Date: 28/10/2020
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        public List<CH_BaoCaoKetCa> CH_BaoCaoKetCa(CH_BaoCaoKetCa_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_BaoCaoKetCa>("proCH_BaoCaoKetCa", new
            {
                model.action,
                model.MaCuaHang,
                model.TuNgay,
                model.DenNgay,
                model.NgayBan
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 23/10/2020
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns>
        /// </returns>
        public List<CH_GiaySua> CH_GiaySua(CH_GiaySua_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_GiaySua>("proCH_GiaySua", new
            {
                model.option,
                model.CuaHang,
                model.SoGiaySua,
                model.TuNgay,
                model.DenNgay,
                model.NgayNhan,
                model.NgayDeNghiGiao,
                model.MaKhachHang,
                model.GhiChu,
                model.TienKhachDua,
                model.MaNhanVien,
                model.CreateBy,
                model.ModifiedBy
            }).ToList();
        }

        /// <summary>
        ///  Create by Tri Minh, Date: 18/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_ChiTietGiaySua> CH_ChiTietGiaySua(CH_ChiTietGiaySua_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_ChiTietGiaySua>("proCH_ChiTietGiaySua", new
            {
                model.option,
                model.ID,
                model.SoGiaySua,
                model.Kieu,
                model.Size,
                model.XuLy,
                model.MoTaLoi,
                model.SoLuong,
                model.GhiChu,
                model.Gia,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 18/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_DatHangNoiBo> CH_DatHangNoiBo(CH_DatHangNoiBo_ViewModel model)
        {
            return _dapper.ExecProcedureData<VNG.Business.Entities.CuaHang.CH_DatHangNoiBo>("proCH_DatHangNoiBo", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
                model.SoHoaDon,
                model.MaCuaHangDat,
                model.MaCuaHangBan,
                model.NgayDatHang,
                model.NgayGiao,
                model.MaNVBan,
                model.GhiChu,
                model.NguoiTao,
                model.NguoiThayDoi,
                model.Status,
                model.ThamSoXacNhan
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 19/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_ChiTietDatHangNoiBo> CH_ChiTietDatHangNoiBo(CH_ChiTietDatHangNoiBo_ViewModel model)
        {
            return _dapper.ExecProcedureData<VNG.Business.Entities.CuaHang.CH_ChiTietDatHangNoiBo>("proCH_ChiTietDatHangNoiBo", new
            {
                model.option,
                model.SoHoaDon,
                model.Id,
                model.Kieu,
                model.Size,
                model.SoLuong,
                model.Gia,
                model.GhiChu,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        #region GiayDatTuKhach
        /// <summary>
        /// Create by Duy Tân 26/11/20
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_GiayDat> CH_GiayDat(CH_GiayDat_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_GiayDat>("proCH_GiayDat", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
                model.HoaDonDatHang,
                model.NgayDatHang,
                model.CuaHang,
                model.MaNhanVien,
                model.MaKhachHang,
                model.GhiChu,
                model.NoiGiaoHang,
                model.TienKhachDua,
                model.TienCoc,
                model.CongThem,
                model.NgayYeuCauGiao,
                model.NgayGiaoHang,
                model.NguoiTao,
                model.NguoiThayDoi,
                model.Status
            }).ToList();
        }


        /// <summary>
        /// Create by Duy Tân 26/11/20
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_GiayDatChiTiet> CH_GiayDatChiTiet(CH_GiayDatChiTiet_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_GiayDatChiTiet>("proCH_GiayDatChiTiet", new
            {
                model.option,
                model.CuaHang,
                model.ID,
                model.HoaDonDatHang,
                model.Kieu,
                model.Size,
                model.SoLuong,
                model.GhiChu,
                model.Gia,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by: Tri Minh, Date: 28/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_ChiTietPhieuTang> CH_ChiTietPhieuTang(CH_ChiTietPhieuTang_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_ChiTietPhieuTang>("proCH_ChiTietPhieuTang", new
            {
                model.option,
                model.Id,
                model.MaPhieuTang,
                model.SoHoaDonBan,
                model.CuaHang,
                model.NgayBan,
                model.GiaTri,
                model.IsPhatHanh,
                model.CreateBy,
                model.ModifiedBy,
                model.GhiChu,
                model.MaSuKien
            }).ToList();
        }


        /// <summary>
        /// Create by: Duy Tan, Date: 28/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_PhieuTang> CH_PhieuTang(CH_PhieuTang_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_PhieuTang>("proCH_PhieuTang", new
            {
                model.action,
                model.ID,
                model.SoHoaDonBan,
                model.MaCuaHang,
                model.MaKhachHang,
                model.MaNhanVien,
                model.NgayBan,
                model.SuDung,
                model.NguoiTao,
                model.NguoiThayDoi,
                model.DienGiai,
                model.ThucNhan,
                model.ChiecKhau,
                model.MaNVTiepKhach

            }).ToList();
        }
        #endregion 

        public List<CH_GiaBan> CH_GiaBan(CH_GiaBan_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_GiaBan>("proCH_GiaBan", new
            {
                model.action,              
                model.MaCuaHang,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }
    }
}
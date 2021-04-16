using System.Collections.Generic;
using System.Linq;
using VNG.Business.Entities.System;
using VNG.Business.Models.System;

namespace API_VNG.Repository
{
    public class HeThongRepository : IHeThongRepository
    {
        private readonly IDapper _dapper;
        public HeThongRepository(IDapper dapper)
        {
            _dapper = dapper;
        }
        /// <summary>
        /// Create by Tri Minh, Date: 10/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SYS_Info> ThongTin(SYS_Info_ViewModel model)
        {
            return _dapper.ExecProcedureData<SYS_Info>("proHT_ThongTin", new
            {
                model.option,
                model.TenCongTy,
                model.TenGiaoDich,
                model.DiaChi,
                model.SoDT,
                model.SoFax,
                model.Email,
                model.Website,
                model.MST,
                model.QuanHuyen,
                model.TinhThanh
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 19/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SYS_DB_Log> DB_Log(SYS_DB_Log_ViewModel model)
        {
            return _dapper.ExecProcedureData<SYS_DB_Log>("proHT_DBLog", new
            {
                model.option,
                model.NoiThucHien,
                model.PhanHe,
                model.TuNgay,
                model.DenNgay,
                model.ID,
                model.DuLieuCu,
                model.DuLieuMoi, 
                model.ChucNang,
                model.NguoiTao,
                model.NoiDung
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 20/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SYS_User> NguoiDung(SYS_User_ViewModel model)
        {
            return _dapper.ExecProcedureData<SYS_User>("proHT_NguoiDung", new
            {
                model.option,
                model.TenDangNhap,
                model.MatKhau,
                model.MaNhanVien,
                model.GhiChu,
                model.NguoiTao,
                model.NguoiThayDoi,
                model.KichHoat,
                model.MatKhauMoi,
                model.MaNhom
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 21/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SYS_Setting> ThietLap(SYS_Setting_ViewModel model)
        {
            return _dapper.ExecProcedureData<SYS_Setting>("proHT_ThietLap", new
            {
                model.option,
                model.FTP_HinhAnh,
                model.DuongDan_Update,
                model.QuyDinhTichDiem,
                model.SoNgayGioHanTraHang,
                model.SoLuongToiThieuKhongTra,
                model.SoNgayVanChuyenMienNam,
                model.ThoiGianDatHangNoiBo

            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 22/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SYS_Permission> PhanQuyen(SYS_Permission_ViewModel model)
        {
            return _dapper.ExecProcedureData<SYS_Permission>("proHT_PhanQuyen", new
            {
                model.option,
                model.ID,
                model.Xem,
                model.Luu,
                model.Xoa,
                model.Sua,
                model.In,
                model.NguoiThayDoi,
                model.MaNhom,
                model.NguoiTao,
                model.TenDangNhap,
                model.MaMenu
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 22/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SYS_GroupPermission> NhomPhanQuyen(SYS_GroupPermission_ViewModel model)
        {
            return _dapper.ExecProcedureData<SYS_GroupPermission>("proHT_NhomPhanQuyen", new
            {
                model.option,
                model.ID,
                model.NhomPhanQuyen,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 06/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<HT_DangKyPhanMem> HT_DangKyPhanMem(HT_DangKyPhanMem_ViewModel model)
        {
            return _dapper.ExecProcedureData<HT_DangKyPhanMem>("proHT_DangKyPhanMem", new
            {
                model.action,
                model.SerialNumber,
                model.Key,
                model.TenMay,
                model.MaCuaHang
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 06/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SYS_Tutorial> HT_HuongDan(SYS_Tutorial_ViewModel model)
        {
            return _dapper.ExecProcedureData<SYS_Tutorial>("proHT_HuongDan", new
            {
                model.action,
                model.ID,
                model.Name,
                model.NoiDung,
                model.Link,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }
    }
}

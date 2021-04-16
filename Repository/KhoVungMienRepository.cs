using System.Linq;
using System.Collections.Generic;
using VNG.Business.Entities.Public;
using VNG.Business.Models.Public;
using VNG.Business.Entities.VungMien;
using VNG.Business.Models.VungMien;

namespace API_VNG.Repository.KhoVungMien
{
    public class KhoVungMienRepository : IKhoVungMienRepository
    {
        private readonly IDapper _dapper;
        public KhoVungMienRepository(IDapper dapper)
        {
            _dapper = dapper;
        }
        /// <summary>
        /// Create by Tri Minh. Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> VM_NhapKho(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proVM_NhapKho", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
                model.NoiNhan,
                model.NgayNhap,
                model.SoHoaDon_Den,
                model.UserNhapKho,
                model.NVKiemHang,
                model.GhiChu
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh. Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> VM_XuatKho(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proVM_XuatKho", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
                model.NoiXuat,
                model.SoHoaDon,
                model.MaXuatKho
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh. Date: 27/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> VM_XuatKhoTraKhoTong(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proVM_TraVeKhoTong", new
            {
                model.option,
                model.SoHoaDon,
                model.NoiXuat,
                model.NgayXuat,
                model.UserXuatKho,
                model.NVKiemHang,
                model.GhiChu,
                model.Kieu
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh. Date: 25/08/2020
        /// Function: Tồn kho vùng miền
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<VM_TonKho> VM_TonKho(VM_TonKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<VM_TonKho>("proVM_TonKho", new
            {
                model.action,
                model.TuNgay,
                model.DenNgay,
                model.NoiTon,
                model.Kieu,
                model.Size,
                model.SoLuong
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh. Date: 29/10/2020        
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<VM_VanChuyen> VM_VanChuyen(VM_VanChuyen_ViewModel model)
        {
            return _dapper.ExecProcedureData<VM_VanChuyen>("proVM_VanChuyen", new
            {
                model.option,

                model.SoHoaDon,
                model.NoiNhan,
                model.TuNgay,
                model.DenNgay
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh. Date: 26/11/2020       
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<VM_VanChuyen> VM_VanChuyen_HangLoi(VM_VanChuyen_ViewModel model)
        {
            return _dapper.ExecProcedureData<VM_VanChuyen>("proVM_VanChuyen_HangLoi", new
            {
                model.option,
                model.SoHoaDon,
                model.NoiNhan,
                model.TuNgay,
                model.DenNgay
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh. Date: 30/10/2020        
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<VM_YeuCauCuaHang> VM_VungMienXuatCuaHang(VM_YeuCauCuaHang_ViewModel model)
        {
            return _dapper.ExecProcedureData<VM_YeuCauCuaHang>("proVM_XuatDM_CuaHang", new
            {
                model.option,
                model.NoiXuat,
                model.flag,
                model.NVKiemHang,
                model.UserXuatKho,
                model.GhiChu,
                model.NgayXuat
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh. Date: 26/11/2020      
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> VM_XuatLoi(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proVM_XuatLoi", new
            {
                model.option,
                model.TuNgay,
                model.DenNgay,
                model.SoHoaDon,
                model.NoiXuat,
                model.NVKiemHang,
                model.UserXuatKho,
                model.NgayXuat
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh. Date: 27/11/2020      
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> VM_NhapLoi(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proVM_NhapLoi", new
            {
                model.option,
                model.SoHoaDon_Den,
                model.TuNgay,
                model.DenNgay,
                model.NoiNhan
            }).ToList();
        }

        /// <summary>
        ///  Create by Duy Tan. Date: 31/12/2020      
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NhapKho> VM_NhapChinhKho(NhapKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<NhapKho>("proVM_NhapChinhKho", new
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
                model.DienGiai,
                model.GhiChu,
                model.Kieu,
                model.Size,
                model.SoLuong

            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan, Date: 31/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<XuatKho> VM_XuatChinhKho(XuatKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<XuatKho>("proVM_XuatChinhKho", new
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
        public List<VM_TonKho_BaoCao> VM_TonKho_BaoCao(VM_TonKho_BaoCao_ViewModel model)
        {
            return _dapper.ExecProcedureData<VM_TonKho_BaoCao>("proVM_TonKho_BaoCao", new
            {
                model.action,
                model.Kieu,
                model.TuNgay,
                model.DenNgay,
                model.NoiTon
            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan, Date: 06/03/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<VM_DinhMuc_BaoCao> VM_DinhMuc_BaoCao(VM_DinhMuc_BaoCao_ViewModel model)
        {
            return _dapper.ExecProcedureData<VM_DinhMuc_BaoCao>("proVM_DinhMuc_BaoCao", new
            {
                model.action,
                model.MaVungMien,
                model.Kieu,

            }).ToList();
        }


    }
}
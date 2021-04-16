using System.Linq;
using System.Collections.Generic;
using VNG.Business.Entities.DTA;
using VNG.Business.Models.DTA;

namespace API_VNG.Repository.DanhMuc
{
    public class DanhMucRepository : IDanhMucRepository
    {
        private readonly IDapper _dapper;
        public DanhMucRepository(IDapper dapper)
        {
            _dapper = dapper;
        }
        /// <summary>
        /// Create by Tri Minh, Date: 22/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_MoTaLoi> DM_MoTaLoi(DM_MoTaLoi_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_MoTaLoi>("proDM_MoTaLoi", new
            {
                model.option,
                model.TenLoi,
                model.Id,
                model.IsUse,
                model.CreateBy,
                model.ModifiedBy
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 22/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_ChungLoaiHang> DM_ChungLoai(DM_ChungLoaiHang_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_ChungLoaiHang>("proDM_ChungLoai", new
            {
                model.action,
                model.ID,
                model.MaKhu,
                model.MaChungLoai,
                model.TenChungLoai,
                model.PhanThung,
                model.SuDung,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 23/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_CuaHang> DM_CuaHang(DM_CuaHang_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_CuaHang>("proDM_CuaHang", new
            {
                model.option,
                model.MaCuaHang,
                model.TenCuaHang,
                model.Code,
                model.MaVungMien,
                model.SoDienThoai,
                model.SoFax,
                model.Email,
                model.DiaChi,
                model.CreateBy,
                model.GhiChu,
                model.ModifiedBy,
                model.IsActive,
                model.IsCuaHang,
                model.UuTien
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 27/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_LoaiThuChi> DM_LoaiThuChi(DM_LoaiThuChi_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_LoaiThuChi>("proDM_LoaiThuChi", new
            {
                model.option,
                model.MaLoaiThuChi,
                model.LoaiPhieu,
                model.LoaiThuChi,
                model.CreateBy,
                model.IsUse,
                model.ModifiedBy
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 03/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_CaLamViec> DM_CaLamViec(DM_CaLamViec_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_CaLamViec>("proDM_CaLamViec", new
            {
                model.option
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 07/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_LenhThuHoi> DM_ThuHoi_DinhMuc(DM_LenhThuHoi_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_LenhThuHoi>("proDM_ThuHoiDinhMuc", new
            {
                model.action,
                model.ID,
                model.UuTien,
                model.NoiDung,
                model.SuDung,
                model.Mau,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 07/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_ThoiGianBaoHanh> DM_BaoHanh(DM_ThoiGianBaoHanh_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_ThoiGianBaoHanh>("proDM_BaoHanh", new
            {
                model.option,
                model.MaTGBH,
                model.NoiDung,
                model.SuDung,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 07/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_VungMien> DM_VungMien(DM_VungMien_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_VungMien>("proDM_VungMien", new
            {
                model.action,
                model.MaVungMien,
                model.TenVungMien,
                model.SuDung,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 08/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_Size> DM_Size(DM_Size_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_Size>("proDM_Size", new
            {
                model.option,
                model.ID,
                model.Size,
                model.SuDung,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }


        /// <summary>
        /// Create by Tri Minh, Date: 21/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_DonViTinh> DM_DonViTinh(DM_DonViTinh_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_DonViTinh>("proDM_DVT", new
            {
                model.option,
                model.DVT,
                model.ID,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 24/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_PhanLoai> DM_PhanLoai(DM_PhanLoai_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_PhanLoai>("proDM_PhanLoai", new
            {
                model.option,
                model.ID,
                model.MaPhanLoai,
                model.TenPhanLoai,
                model.SuDung,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 19/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_LoaiHang> DM_LoaiHang(DM_LoaiHang_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_LoaiHang>("proDM_LoaiHang", new
            {
                model.action,
                model.ID,
                model.MaLoaiHang,
                model.TenLoaiHang,
                model.SuDung,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 25/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_ThuongHieu> DM_ThuongHieu(DM_ThuongHieu_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_ThuongHieu>("proDM_ThuongHieu", new
            {
                model.action,
                model.ID,
                model.MaThuongHieu,
                model.ThuongHieu,
                model.SuDung,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 21/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_DongSanPham> DM_DongSanPham(DM_DongSanPham_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_DongSanPham>("proDM_DongSanPham", new
            {
                model.action,
                model.ID,
                model.MaDongSP,
                model.DongSP,
                model.SuDung,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }


        /// <summary>
        /// Create by Duy Tan, Date: 11/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_PhanKhu> DM_PhanKhu(DM_PhanKhu_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_PhanKhu>("proDM_PhanKhu", new
            {
                model.action,
                model.MaCuaHang,
                model.ID,
                model.SuDung,
                model.MaChungLoai,
                model.MaPhanLoai,
                model.NhomGia,
                model.NguoiTao,
                model.NguoiThayDoi,
                model.MaKhu
            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan, Date: 11/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_Khu> DM_Khu(DM_Khu_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_Khu>("proDM_Khu", new
            {
                model.action,
                model.MaKhu,
                model.TenKhu,
                model.ID,
                model.NguoiTao,
                model.NguoiThayDoi,
                model.SuDung
            }).ToList();
        }



        /// <summary>
        /// Create by Duy Tan, Date: 11/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_LoaiKhachHang> DM_LoaiKhachHang(DM_LoaiKhachHang_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_LoaiKhachHang>("proDM_LoaiKhachHang", new
            {
                model.action,
                model.ID,
                model.MaLoaiKhachHang,
                model.TenLoaiKhachHang,
                model.NguoiTao,
                model.NguoiThayDoi,
                model.SuDung
                ///
            }).ToList();
        }



        /// <summary>
        /// Create by Duy Tan, Date: 1/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_SuKien> DM_SuKien(DM_SuKien_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_SuKien>("proDM_SuKien", new
            {
                model.action,
                model.ID,
                model.MaSuKien,
                model.TenSuKien,
                model.NguoiTao,
                model.NguoiThayDoi,
                model.SuDung
                ///
            }).ToList();
        }


        /// <summary>
        /// Create by Duy Tan, Date: 1/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_NhomGia> DM_NhomGia(DM_NhomGia_ViewModel model)
        {
            return _dapper.ExecProcedureData<DM_NhomGia>("proDM_NhomGia", new
            {
                model.action,
                model.ID,
                model.MaNhomGia,
                model.TenNhomGia,
                model.MaMau,
                model.Gia,
                model.NguoiTao,
                model.NguoiThayDoi,
                model.SuDung
                ///
            }).ToList();
        }
    }
}
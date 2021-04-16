using System.Linq;
using System.Collections.Generic;
using VNG.Business.Models.QuanTri;
using VNG.Business.Entities.QuanTri;
using VNG.Business.Entities.CuaHang;
using VNG.Business.Models.CuaHang;

namespace API_VNG.Repository.QuanTri
{
    public class QuanTriRepository : IQuanTriRepository
    {
        private readonly IDapper _dapper;
        public QuanTriRepository(IDapper dapper)
        {
            _dapper = dapper;
        }
        /// <summary>
        /// Create by Tri Minh, Date: 22/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_Kieu> QT_Kieu(QT_Kieu_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_Kieu>("proQT_Kieu", new
            {
                model.option,
                model.Barcode,
                model.TenGoi,
                model.MaChungLoai,
                model.MaPhanLoai,
                model.MaLoaiHang,
                model.MaThuongHieu,
                model.NgayThietKe,
                model.De,
                model.MuGiay,
                model.LotTrong,
                model.DanhDau,
                model.IsCoHop,
                model.SuDung,
                model.GhiChu,
                model.NguoiThayDoi,
                model.Mau,
                model.Got,
                model.MaTGBH,
                model.MaThuHoi,
                model.Kieu,
                model.NguoiTao,
                model.MaDVT,
                model.GiaNhap,
                model.MaNhomGia
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 22/10/2020
        /// </summary> 
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_NhanVien> QT_NhanVien(QT_NhanVien_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_NhanVien>("proQT_NhanVien", new
            {
                model.option,
                model.MaNhanVien,
                model.HoTen,
                model.SoDienThoai,
                model.ThuongTru,
                model.TamTru,
                model.NgayVaoLam,
                model.NgaySinh,
                model.NguoiGioiThieu,
                model.Email,
                model.GhiChu,
                model.NguoiThayDoi,
                model.CMND,
                model.SuDung,
                model.MaCuaHang,
                model.NguoiTao
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 22/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_DinhMuc> QT_DinhMuc(QT_DinhMuc_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_DinhMuc>("proQT_DinhMuc", new
            {
                model.action,
                model.MaCuaHang
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 15/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_DinhMuc> QT_DinhMucChiTiet(QT_DinhMuc_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_DinhMuc>("proQT_DinhMucChiTiet", new
            {
                model.action,
                model.MaCuaHang,
                model.MaCuaHangDen,
                model.Kieu,
                model.Size,
                model.SoLuong,
                model.Id,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by: Tri Minh, Date: 28/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_QuanLyGia> QT_QuanLyGia(QT_QuanLyGia_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_QuanLyGia>("proQT_GiaBan", new
            {
                model.action,
                model.ID,
                model.NoiApDung,
                model.NgayApDung,
                model.Kieu,
                model.GiaXuat,
                model.GhiChu,
                model.NguoiTao,
                model.NguoiThayDoi

            }).ToList();
        }

        /// <summary>
        /// Create by: Tri Minh, Date: 18/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_SanPhamKhuyenMai> QT_KhuyenMai(QT_SanPhamKhuyenMai_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_SanPhamKhuyenMai>("proQT_KhuyenMai", new
            {
                model.option,
                model.Id,
                model.TuNgay,
                model.DenNgay,
                model.PhanTramGiam,
                model.GhiChu,
                model.KhongGioiHan,
                model.ModifiedBy,
                model.Kieu,
                model.Kieu_KhuyenMai,
                model.MaCuaHang,
                model.CreateBy

            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 24/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_ChanXuat> QT_ChanXuat(QT_ChanXuat_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_ChanXuat>("proQT_ChanXuat", new
            {
                model.action,
                model.ID,
                model.Loai,
                model.NoiApDung,
                model.MaPhanLoai,
                model.Kieu,
                model.TuNgay,
                model.DenNgay,
                model.GhiChu,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan , Date: 2/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_QuyDinhTinhDiem> QT_QuyDinhTinhDiem(QT_QuyDinhTinhDiem_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_QuyDinhTinhDiem>("proQT_QuyDinhTinhDiem", new
            {
                model.action,
                model.Id,
                model.SoDiem,
                model.GiaTri,
                model.HeSoQuyDoi,
                model.SoDiemToiThieu,
                model.NguoiTao,
                model.NgayApDung
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 24/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_QuanLyTichDiem> QT_QuanLyTichDiem(QT_QuanLyTichDiem_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_QuanLyTichDiem>("proQT_QuanLyTichDiem", new
            {
                model.option,
                model.MaKhachHang
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 12/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_LenhThuHoi> QT_LenhThuHoi(QT_LenhThuHoi_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_LenhThuHoi>("proQT_LenhThuHoi", new
            {
                model.action,
                model.ID,
                model.NgayThuHoi,
                model.MaCuaHang,
                model.NguoiTao,
                model.GhiChu,
                model.SuDung,
                model.NguoiThayDoi
            }).ToList();
        }


        /// <summary>
        /// Create by Tri Minh, Date: 23/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_KhachHang> QT_KhachHang(QT_KhachHang_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_KhachHang>("proQT_KhachHang", new
            {
                model.option,
                model.MaKhachHang,
                model.HoTen,
                model.CMND,
                model.NgaySinh,
                model.ThuongTru,
                model.SoDienThoai,
                model.Email,
                model.GhiChu,
                model.CreateBy,
                model.ModifiedBy,
                model.MaLoaiKhachHang
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 23/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_QuyDinhDoiTra> QT_QuyDinhDoiTra(QT_QuyDinhDoiTra_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_QuyDinhDoiTra>("proQT_QuyDinhDoiTra", new
            {
                model.action,
                model.MaCuaHang,
                model.SoNgay,
                model.SuDung,
                model.NguoiTao,
                model.NguoiThayDoi
            }).ToList();
        }


        /// <summary>
        /// Create by Tri Minh, Date: 14/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_ThongKeTongHop> QT_ThongKe_TongQuat(QT_ThongKeTongHop_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_ThongKeTongHop>("proQT_ThongKe_TongHop", new
            {
                model.option
            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan, Date: 14/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_PhatHanhPhieuTang> QT_PhatHanhPhieuTang(QT_PhatHanhPhieuTang_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_PhatHanhPhieuTang>("proQT_PhatHanhPhieuTang", new
            {
                model.action,
                model.ID,
                model.MaPhieuTang,
                model.MaCuaHang,
                model.NguoiPhatHanh,
                model.NgayPhatHanh,
                model.NguoiTao,
                model.NguoiThayDoi,
                model.SuDung
                ///
            }).ToList();
        }

        /// <summary>
        /// Create by Tri Minh, Date: 01/02/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_TonKho> QT_KetChuyenSoDu(CH_TonKho_ViewModel model)
        {
            return _dapper.ExecProcedureData<CH_TonKho>("proQT_KetChuyen", new
            {
                model.Thang
            }).ToList();
        }

        /// <summary>
        /// Create by Duy Tan, Date: 06/03/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<QT_DinhMuc_BaoCao> QT_DinhMuc_BaoCao(QT_DinhMuc_BaoCao_ViewModel model)
        {
            return _dapper.ExecProcedureData<QT_DinhMuc_BaoCao>("proQT_DinhMuc_BaoCao", new
            {
                model.action,
                model.MaCuaHang,
                model.Kieu,

            }).ToList();
        }

    }
}
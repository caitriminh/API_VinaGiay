using System.Collections.Generic;
using VNG.Business.Entities.CuaHang;
using VNG.Business.Entities.QuanTri;
using VNG.Business.Models.CuaHang;
using VNG.Business.Models.QuanTri;

namespace API_VNG.Repository.QuanTri
{
    public interface IQuanTriRepository
    {
        /// <summary>
        ///  Create by Tri Minh, Date: 22/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_Kieu> QT_Kieu(QT_Kieu_ViewModel model);
        /// <summary>
        /// Create by Tri Minh, Date: 22/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_NhanVien> QT_NhanVien(QT_NhanVien_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 03/09/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_DinhMuc> QT_DinhMuc(QT_DinhMuc_ViewModel model);

        List<QT_DinhMuc> QT_DinhMucChiTiet(QT_DinhMuc_ViewModel model);
        /// <summary>
        /// Create by Tri Minh, Date: 28/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_QuanLyGia> QT_QuanLyGia(QT_QuanLyGia_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 18/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_SanPhamKhuyenMai> QT_KhuyenMai(QT_SanPhamKhuyenMai_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 24/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_ChanXuat> QT_ChanXuat(QT_ChanXuat_ViewModel model);


        /// <summary>
        /// Create by Duy Tan  Date: 02/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_QuyDinhTinhDiem> QT_QuyDinhTinhDiem(QT_QuyDinhTinhDiem_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 24/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_QuanLyTichDiem> QT_QuanLyTichDiem(QT_QuanLyTichDiem_ViewModel model);

        /// <summary>
        /// Create by Tri Minh  Date: 12/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_LenhThuHoi> QT_LenhThuHoi(QT_LenhThuHoi_ViewModel model);

        List<QT_KhachHang> QT_KhachHang(QT_KhachHang_ViewModel model);


        /// <summary>
        /// Create by Tri Minh  Date: 14/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_ThongKeTongHop> QT_ThongKe_TongQuat(QT_ThongKeTongHop_ViewModel model);

        List<QT_QuyDinhDoiTra> QT_QuyDinhDoiTra(QT_QuyDinhDoiTra_ViewModel model);


        /// <summary>
        /// Create by Duy Tan  Date: 14/01/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_PhatHanhPhieuTang> QT_PhatHanhPhieuTang(QT_PhatHanhPhieuTang_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 01/02/2021
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_TonKho> QT_KetChuyenSoDu(CH_TonKho_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<QT_DinhMuc_BaoCao> QT_DinhMuc_BaoCao(QT_DinhMuc_BaoCao_ViewModel model);

    }
}
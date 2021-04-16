using System.Collections.Generic;
using VNG.Business.Entities.DTA;
using VNG.Business.Models.DTA;

namespace API_VNG.Repository.DanhMuc
{
    public interface IDanhMucRepository
    {

        /// <summary>
        /// Create by Tri Minh, Date: 22/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_MoTaLoi> DM_MoTaLoi(DM_MoTaLoi_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 23/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_ChungLoaiHang> DM_ChungLoai(DM_ChungLoaiHang_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 24/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_CuaHang> DM_CuaHang(DM_CuaHang_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 27/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_LoaiThuChi> DM_LoaiThuChi(DM_LoaiThuChi_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 03/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_CaLamViec> DM_CaLamViec(DM_CaLamViec_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 07/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_LenhThuHoi> DM_ThuHoi_DinhMuc(DM_LenhThuHoi_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 07/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_ThoiGianBaoHanh> DM_BaoHanh(DM_ThoiGianBaoHanh_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 07/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_VungMien> DM_VungMien(DM_VungMien_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 08/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_Size> DM_Size(DM_Size_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 19/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_LoaiHang> DM_LoaiHang(DM_LoaiHang_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 21/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_DonViTinh> DM_DonViTinh(DM_DonViTinh_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 24/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_PhanLoai> DM_PhanLoai(DM_PhanLoai_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 25/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<DM_ThuongHieu> DM_ThuongHieu(DM_ThuongHieu_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 21/12/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_DongSanPham> DM_DongSanPham(DM_DongSanPham_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 11/01/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_PhanKhu> DM_PhanKhu(DM_PhanKhu_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 11/01/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_Khu> DM_Khu(DM_Khu_ViewModel model);


        /// <summary>
        /// Create by Duy Tan, Date: 14/01/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_LoaiKhachHang> DM_LoaiKhachHang(DM_LoaiKhachHang_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 19/01/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_SuKien> DM_SuKien(DM_SuKien_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 19/01/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<DM_NhomGia> DM_NhomGia(DM_NhomGia_ViewModel model);
    }
}
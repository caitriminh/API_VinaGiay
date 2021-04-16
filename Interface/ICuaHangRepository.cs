using System.Collections.Generic;
using VNG.Business.Entities.CuaHang;
using VNG.Business.Entities.Public;
using VNG.Business.Models.CuaHang;
using VNG.Business.Models.Public;

namespace API_VNG.Repository.CuaHang
{
    public interface ICuaHangRepository
    {
        /// <summary>
        /// Create by Tri Minh, Date: 29/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> CH_XuatKho(XuatKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 30/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> CH_NhapKho(NhapKho_ViewModel model);
        /// <summary>
        /// Create by Tri Minh, Date: 26/08/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_TonKho> CH_TonKho(CH_TonKho_ViewModel model);


        /// <summary>
        /// Create by Tri Minh, Date: 26/08/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_VanChuyen> CH_VanChuyen(CH_VanChuyen_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 28/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> CH_TraDinhMucVeVungMien(XuatKho_ViewModel model);

        /// <summary>
        ///  Create by Tri Minh, Date: 04/09/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_TonKhoDinhMuc> CH_TonKhoDinhMuc(CH_TonKhoDinhMuc_ViewModel model);

        /// <summary>
        ///  Create by Tri Minh, Date: 27/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_QuanLyThuChi_ChiTiet> CH_QuanLyThuChi_ChiTiet(CH_QuanLyThuChi_ViewModel model);

        /// <summary>
        ///  Create by Tri Minh, Date: 28/10/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CH_QuanLyThuChi> CH_QuanLyThuChi(CH_QuanLyThuChi_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> CH_NhapLoi(NhapKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> CH_XuatLoi(XuatKho_ViewModel model);

        /// <summary>
        /// Create by Tri Minh, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_TonKho> CH_TonKhoLoi(CH_TonKho_ViewModel model);


        /// <summary>
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NhapKho> CH_NhapDieuChinh(NhapKho_ViewModel model);


        /// <summary>
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<XuatKho> CH_XuatDieuChinh(XuatKho_ViewModel model);


        /// <summary>
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_TonKho_BaoCao> CH_TonKho_BaoCao(CH_TonKho_BaoCao_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_ThongKe> CH_ThongKe(CH_ThongKe_ViewModel model);

        /// <summary>
        /// Create by Duy Tan, Date: 26/11/2020
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CH_DinhMuc_BaoCao> CH_DinhMuc_BaoCao(CH_DinhMuc_BaoCao_ViewModel model);
    }

}